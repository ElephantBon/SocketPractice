using System.Net.Sockets;
using System.Text;

namespace ClientApp
{
    public partial class FormClient : Form
    {


        public FormClient()
        {
            InitializeComponent();

            // initialize UI properties that related to business logic
            tbDownloadResult.ReadOnly = true;

            // test data
            tbServerIP.Text = "127.0.0.1";
            tbServerPort.Text = "8000";
            tbRequestFileName.Text = "test.txt";
            tbSaveFilePath.Text = @"D:\Downloads\";
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // retrieve data from UI
            string serverIP = tbServerIP.Text.Trim();
            string serverPort = tbServerPort.Text.Trim();
            string requestFileName = tbRequestFileName.Text.Trim();
            string saveFilePath = tbSaveFilePath.Text.Trim() + requestFileName;

            // examine data correction
            int serverPortNum;
            if(!int.TryParse(serverPort, out serverPortNum)) {
                MessageBox.Show("Invalid Server Port.");
                return;
            }

            // establish connection to server
            TcpClient tcpClient = new TcpClient();
            tcpClient.Connect(serverIP, serverPortNum);

            // request : file name
            byte[] sendData = Encoding.ASCII.GetBytes(requestFileName);
            tcpClient.Client.Send(sendData);

            // response
            byte[] data = new byte[1024 * 5000];
            tcpClient.Client.Receive(data);
            string fileState = Encoding.ASCII.GetString(data).TrimEnd('\0');
            switch(fileState) {
                case "File exists":
                    int receivedBytesLen = tcpClient.Client.Receive(data);
                    using(BinaryWriter bWrite = new BinaryWriter(File.Open(saveFilePath, FileMode.Append))) {
                        bWrite.Write(data, 0, receivedBytesLen);
                    }
                    tbDownloadResult.Text = "File downloaded.";
                    break;
                case "File not exists":
                    tbDownloadResult.Text = "File not exists.";
                    break;
                default:
                    break;
            }

            // close connection
            tcpClient.Close();
        }
    }
}