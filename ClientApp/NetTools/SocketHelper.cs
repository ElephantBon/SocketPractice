﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.NetTools
{
    public class SocketHelper : ISocket
    {
        public TcpClient _tcpClient { get; set; }

        public bool Connect(string serverIP, int serverPort)
        {
            try {
                _tcpClient = new TcpClient(serverIP, serverPort);
                return true;
            }
            catch(Exception ex) {
                return false;
            }
        }

        public void Disconnect()
        {
            _tcpClient?.Close();
        }

        public byte[] GetFileData()
        {
            if(_tcpClient != null) {
                byte[] data = new byte[1024 * 5000];
                _tcpClient.Client.Receive(data);
                return data;
            }
            else
                return new byte[0];
        }

        public string GetFileState()
        {
            if(_tcpClient != null) {
                byte[] data = new byte[1024 * 5000];
                _tcpClient.Client.Receive(data);
                return Encoding.ASCII.GetString(data).TrimEnd('\0');
            }
            else
                return null;
        }

        public void Send(string requestFileName)
        {
            if(_tcpClient != null) {
                byte[] sendData = Encoding.ASCII.GetBytes(requestFileName);
                _tcpClient.Client.Send(sendData);
            }
        }
    }
}
