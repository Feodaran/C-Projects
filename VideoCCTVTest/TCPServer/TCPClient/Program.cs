using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;


namespace TCPClient
{
    public static class TCPClient
    {
        public static void Main(string[] args)
        {
            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
            clientSocket.Connect("VideoServerSim.exe", 13000);
            while (true)
            {
                NetworkStream serverStream = clientSocket.GetStream();
                byte[] outStream = System.Text.Encoding.ASCII.GetBytes(Console.ReadLine());
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
            }


            FileStream VideoServerSim = new FileStream("VideoServerSim.exe", FileMode.Open, FileAccess.Read, FileShare.Read);



            TcpListener listener = new TcpListener(IPAddress.Any, 13000);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                Task.Factory.StartNew(() =>
                {
                    //Create a new file for every connection
                    using (var file = File.Create(Guid.NewGuid() + ".dat"))
                    {
                        client.GetStream().CopyTo(file);
                    }

                }, TaskCreationOptions.LongRunning);

            }
        }
    }
}
