using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.NetTools
{
    public class SocketHelperMock : ISocket
    {
        public TcpClient _tcpClient { get; set; }

        public bool Connect(string serverIP, int serverPort)
        {
            return (serverIP == "127.0.0.1" && serverPort == 8000);
        }

        public void Disconnect()
        {
        }

        public byte[] GetFileData()
        {
            return new byte[] { 116, 101, 115, 116, 49, 48, 49, 0 };
        }

        public string GetFileState()
        {
            return "File exists";
        }

        public void Send(string requestFileName)
        {
        }
    }
}
