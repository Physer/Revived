using System;
using System.Threading;
using static System.Console;

namespace Revived.Server
{
    public class Program
    {
        private static readonly bool _isAlive = true;
        public static void Main(string[] args)
        {
            WriteLine("Initializing server...");
            while (_isAlive)
            {
                var currentKey = ReadKey();
                if(currentKey.Key == ConsoleKey.Q && currentKey.Modifiers.HasFlag(ConsoleModifiers.Control))
                {
                    WriteLine("Shutting down server...");
                    Shutdown();
                    Environment.Exit(0);
                }
            }
        }

        private static void Shutdown()
        {
            Thread.Sleep(3000);
        }
    }
}
