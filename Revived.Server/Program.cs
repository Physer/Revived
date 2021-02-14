using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using static System.Console;

namespace Revived.Server
{
    public class Program
    {
        private static readonly bool _isAlive = true;
        private static TcpListener _listener;
        private static ConcurrentBag<TcpClient> _clients = new ConcurrentBag<TcpClient>();

        private const int _portNumber = 7529;
        public static async Task Main(string[] args)
        {
            WriteLine("Initializing server...");
            InitializeServer();
            WriteLine($"Listening on port {_portNumber}");
            while (_isAlive)
            {
                ListenForShutdown();
                await ListenForConnections();

            }
        }

        private static async Task ListenForConnections()
        {
            var client = await _listener.AcceptTcpClientAsync();
            if (!(client is null))
            {
                WriteLine("Accepted connection");
                _clients.Add(client);
            }
        }

        private static void InitializeServer()
        {
            _listener = new TcpListener(IPAddress.Any, _portNumber);
            _listener.Start();
        }

        private static void ListenForShutdown()
        {
            var currentKey = ReadKey();
            if (currentKey.Key == ConsoleKey.Q && currentKey.Modifiers.HasFlag(ConsoleModifiers.Control))
            {
                WriteLine("Shutting down server...");
                _listener.Stop();
                Environment.Exit(0);
            }            
        }
    }
}
