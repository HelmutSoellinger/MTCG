using MTCG.Server;
using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Our first simple HTTP-Server: http://localhost:10001/");

HTTPServer server = new HTTPServer(IPAddress.Loopback, 10001);
server.RunServer();

return;

