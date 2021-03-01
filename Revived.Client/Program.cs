using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Revived.Client
{
    public static class Program
    {
        private static readonly bool _isAlive = true;
        private static TcpClient _client;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            InitializeClient();
            //Loop();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Client());
        }

        private static void InitializeClient()
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
