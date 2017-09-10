using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;

namespace Server_Console
{
    class ClientHandler
    {
        private Socket Socket;

        public ClientHandler(Socket socket)
        {
            Socket = socket;
        }

        public void Comunication()
        {
            NetworkStream stream = new NetworkStream(Socket);
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream);
            writer.AutoFlush = true;
            writer.WriteLine("10000");
            ///text 
        }
    }
}
