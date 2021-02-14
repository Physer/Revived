using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revived.Client
{
    public class Program
    {
        private static readonly bool _isAlive = true;
        private static TcpClient _client;

        public static void Main(string[] args)
        {
            // Start the client
            Task.Run(() => Application.Run(Client.Instance));

            // Initialize the connection
            InitializeConnection();

            // Load the game loop
            Loop();
        }

        private static void InitializeConnection()
        {
            _client = new TcpClient("localhost", 7529);
        }

        private static void Loop()
        {
            while(_isAlive)
            {

            }
        }
    }
}
