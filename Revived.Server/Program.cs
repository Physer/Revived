using System;
using System.Net;
using System.Net.Sockets;
using static System.Console;

namespace Revived.Server
{
    public class Program
    {
        private static readonly bool _isAlive = true;
        private static TcpListener _listener;

        private const int _portNumber = 7529;
        public static void Main(string[] args)
        {
            WriteLine("Initializing server...");
            InitializeServer();
            WriteLine($"Listening on port {_portNumber}");
            while (_isAlive)
            {
                var currentKey = ReadKey();
                if(currentKey.Key == ConsoleKey.Q && currentKey.Modifiers.HasFlag(ConsoleModifiers.Control))
                {
                    WriteLine("Shutting down server...");
                    ShutdownServer();
                    Environment.Exit(0);
                }
            }
        }

        private static void InitializeServer()
        {
            _listener = new TcpListener(IPAddress.Any, _portNumber);
            _listener.Start();
        }

        private static void ShutdownServer()
        {
            _listener.Stop();
        }
    }
}
