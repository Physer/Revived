using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revived.Client
{
    public class Program
    {
        private static readonly bool _isAlive = true;

        public static void Main(string[] args)
        {
            // Start the client
            Task.Run(() => Application.Run(Client.Instance));

            // Load the game loop
            Loop();
        }

        private static void Loop()
        {
            while(_isAlive)
            {

            }
        }
    }
}
