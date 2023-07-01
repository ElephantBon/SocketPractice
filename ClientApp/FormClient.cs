using ClientApp.NetTools;
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
            string saveFilePath = tbSaveFilePath.Text.Trim();

            DownloadFile(serverIP, serverPort, requestFileName, saveFilePath);
        }

        // todo:non-public
        public bool DownloadFile(string serverIP, string serverPort, string requestFileName, string saveFilePath)
        {
            // examine data correction
            int serverPortNum;
            if(!int.TryParse(serverPort, out serverPortNum)) {
                tbDownloadResult.Text = "Invalid server port.";
                return false;
            }

            // establish connection to server
            ISocket socketHelper;
            //if(UnitTestDetector.IsRunningFromNUnit)
            //    socketHelper = new SocketHelperMock();
            //else
                socketHelper = new SocketHelper();

            if(!socketHelper.Connect(serverIP, serverPortNum)) {
                tbDownloadResult.Text = "Fail to connect server.";
                return false;
            }

            // request : file name
            socketHelper.Send(requestFileName);

            // response
            bool downloadSuccess = true;
            string fileState = socketHelper.GetFileState();
            switch(fileState) {
                case "File exists":
                    byte[] fileData = socketHelper.GetFileData();

                    // create directory if not exists
                    if(!Directory.Exists(saveFilePath))
                        try {
                            Directory.CreateDirectory(saveFilePath);
                        }
                        catch(Exception ex) {
                            tbDownloadResult.Text = ex.Message;
                            downloadSuccess = false;
                            break;
                        }

                    // fix saveFilePath
                    if(!saveFilePath.EndsWith("\\"))
                        saveFilePath += "\\";

                    using(BinaryWriter bWrite = new BinaryWriter(File.Open(saveFilePath + requestFileName, FileMode.Append))) {
                        try {
                            bWrite.Write(fileData, 0, fileData.Length);
                            tbDownloadResult.Text = "File downloaded.";
                        }
                        catch(Exception ex) {
                            tbDownloadResult.Text = ex.Message;
                        }
                    }
                    break;
                case "File not exists":
                    tbDownloadResult.Text = "File not exists.";
                    break;
                default:
                    downloadSuccess = false;
                    break;
            }

            // close connection
            socketHelper.Disconnect();

            return downloadSuccess;
        }
    }
}