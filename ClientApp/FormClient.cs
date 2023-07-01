using ClientApp.NetTools;
using System.Net.Sockets;
using System.Text;

namespace ClientApp
{
    public partial class FormClient : Form
    {
        private FormClientViewModel _viewModel;

        public FormClient()
        {
            InitializeComponent();

            // initialize UI properties that related to business logic
            tbDownloadResult.ReadOnly = true;

            _viewModel = new FormClientViewModel(new SocketHelper());

#if DEBUG
            // test data
            tbServerIP.Text = "127.0.0.1";
            tbServerPort.Text = "8000";
            tbRequestFileName.Text = "test.txt";
            tbSaveFilePath.Text = @"D:\Downloads\";
#endif
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            // retrieve data from UI
            string serverIP = tbServerIP.Text.Trim();
            string serverPort = tbServerPort.Text.Trim();
            string requestFileName = tbRequestFileName.Text.Trim();
            string saveFilePath = tbSaveFilePath.Text.Trim();

            _viewModel.DownloadFile(serverIP, serverPort, requestFileName, saveFilePath);
            tbDownloadResult.Text = _viewModel.DownloadResult;
        }
    }
}