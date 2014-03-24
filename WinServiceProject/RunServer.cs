using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace WinServiceProject
{
    public class RunServer
    {
        static void ListenForRequests()
        {
            int CONNECT_QUEUE_LENGTH = 2;

            Socket listenSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listenSock.Bind(new IPEndPoint(IPAddress.Loopback, 9999));
            listenSock.Listen(CONNECT_QUEUE_LENGTH);

            while (true)
            {
                using (Socket newConnection = listenSock.Accept())
                {
                    // Send the data.
                    //byte[] msg = Encoding.UTF8.GetBytes("Starting console!");
                    //newConnection.Send(msg, SocketFlags.None);
                    Process cmdLine = new Process();
                    cmdLine.StartInfo.FileName = "c:\\WINDOWS\\system32\\cmd.exe";
                    cmdLine.Start();
                }
            }
        }

        public void start()
        {
            // Start the listening thread.
            Thread listener = new Thread(new ThreadStart(ListenForRequests));
            listener.IsBackground = true;
            listener.Start();
        }
    }
}
