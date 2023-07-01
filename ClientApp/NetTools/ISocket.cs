using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.NetTools
{
    public interface ISocket
    {
        TcpClient _tcpClient { get; set; }

        bool Connect(string serverIP, int serverPort);

        void Disconnect();

        byte[] GetFileData();

        string GetFileState();

        void Send(string requestFileName);
    }
}
