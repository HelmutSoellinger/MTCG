using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MTCG.Server
{
    internal class HTTPServer
    {
        public  IPAddress Address { get; set; }
        public int Port { get; set; }

        public HTTPServer(IPAddress address, int port)
        {
            Address = address;
            Port = port;
        }

        public void RunServer()
        {
            // ===== I. Start the HTTP-Server =====
            var httpServer = new TcpListener(Address, Port);
            httpServer.Start();

            while (true)
            {
                var clientSocket = httpServer.AcceptTcpClient();
                ClientProcessor clientProcessor = new ClientProcessor(clientSocket);
                clientProcessor.ProcessClient();
                //use Threadpool to process the client-request 
                //ThreadPool.QueueUserWorkItem(clientProcessor.ProcessClient);  Thread safe classen
            }
        }
    }
}
