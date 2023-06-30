using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
    internal static class ServerHelper
    {
        private static BackgroundWorker _worker;
        private static TcpListener _tcpListener;

        internal static void StartServer(int port)
        {
            // start server
            _tcpListener = new TcpListener(port);
            _tcpListener.Start();

            _worker = new BackgroundWorker();
            _worker.DoWork += new DoWorkEventHandler(_worker_DoWork);
            _worker.WorkerSupportsCancellation = true;
            _worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(_worker_RunWorkerCompleted);

            _worker.RunWorkerAsync();
        }

        internal static void CloseServer()
        {
            _worker?.CancelAsync();
        }

        private static void _worker_DoWork(object? sender, DoWorkEventArgs e)
        {
            while(!_worker.CancellationPending) {
                // waiting for client
                Socket clientSocket = _tcpListener.AcceptSocket();

                // waiting for request file name
                byte[] clientData = new byte[1024];
                clientSocket.Receive(clientData);
                string requestFileName = "D:\\" + Encoding.ASCII.GetString(clientData).TrimEnd('\0');

                // send file state
                if(File.Exists(requestFileName)) {
                    byte[] sendData = Encoding.ASCII.GetBytes("File exists");
                    clientSocket.Send(sendData);

                    // send file content
                    clientSocket.SendFile(requestFileName);
                }
                else {
                    byte[] sendData = Encoding.ASCII.GetBytes("File not exists");
                    clientSocket.Send(sendData);
                }
            }
        }

        private static void _worker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs e)
        {
            _tcpListener?.Stop();
        }
    }
}
