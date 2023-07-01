using ClientApp.NetTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    public class FormClientViewModel
    {
        private ISocket _socketHelper;

        public FormClientViewModel(ISocket _socketHelper)
        {
            this._socketHelper = _socketHelper;
        }

        public string DownloadResult { get; internal set; }

        // todo:non-public
        public bool DownloadFile(string serverIP, string serverPort, string requestFileName, string saveFilePath)
        {
            // examine data correction
            int serverPortNum;
            if(!int.TryParse(serverPort, out serverPortNum)) {
                DownloadResult = "Invalid server port.";
                return false;
            }

            // establish connection to server
            if(!_socketHelper.Connect(serverIP, serverPortNum)) {
                DownloadResult = "Fail to connect server.";
                return false;
            }

            // request : file name
            _socketHelper.Send(requestFileName);

            // response
            bool downloadSuccess = true;
            string fileState = _socketHelper.GetFileState();
            switch(fileState) {
                case "File exists":
                    byte[] fileData = _socketHelper.GetFileData();

                    // create directory if not exists
                    if(!Directory.Exists(saveFilePath))
                        try {
                            Directory.CreateDirectory(saveFilePath);
                        }
                        catch(Exception ex) {
                            DownloadResult = ex.Message;
                            downloadSuccess = false;
                            break;
                        }

                    // fix saveFilePath
                    if(!saveFilePath.EndsWith("\\"))
                        saveFilePath += "\\";

                    using(BinaryWriter bWrite = new BinaryWriter(File.Open(saveFilePath + requestFileName, FileMode.Append))) {
                        try {
                            bWrite.Write(fileData, 0, fileData.Length);
                            DownloadResult = "File downloaded.";
                        }
                        catch(Exception ex) {
                            DownloadResult = ex.Message;
                        }
                    }
                    break;
                case "File not exists":
                    DownloadResult = "File not exists.";
                    break;
                default:
                    downloadSuccess = false;
                    break;
            }

            // close connection
            _socketHelper.Disconnect();

            return downloadSuccess;
        }
    }
}
