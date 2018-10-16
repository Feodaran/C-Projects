using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace TCPServer
{
    public static class TCPServer
    {
       
        
        public static void Main(string [] args)
        {
            IPAddress ipAd = IPAddress.Parse("127.0.0.1");
            TcpListener serverSocket = new TcpListener(ipAd, 13000);
            TcpClient clientSocket = default(TcpClient);
            serverSocket.Start();
            Console.WriteLine(" ****** Server Started *****");
            clientSocket = serverSocket.AcceptTcpClient();
            Console.WriteLine("Accepted connection from client");


            while ((true))
            {
                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    byte[] bytesForm = new byte[10025];
                    if (networkStream.DataAvailable)
                    {
                        //bytesForm is meant to be "bytesFrom".
                        networkStream.Read(bytesForm, 0, (int)clientSocket.ReceiveBufferSize);
                        string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesForm);
                        dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf('\0'));
                        Console.WriteLine("Data from client - " + dataFromClient);
                        networkStream.Flush();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

           
        }
    }
}
