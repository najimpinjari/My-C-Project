using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Chat_Application
{
    class Program
    {
        static async Task Main()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 8888);
            server.Start();
            Console.WriteLine("Server started. Waiting for connections...");

            TcpClient client = await server.AcceptTcpClientAsync();
            Console.WriteLine("Client connected!");

            NetworkStream stream = client.GetStream();
            while (true)
            {
                byte[] buffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine($"Client: {message}");

                Console.Write("Server: ");
                string response = Console.ReadLine();
                byte[] responseBytes = Encoding.UTF8.GetBytes(response);
                await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
            }
        }
    }
}
