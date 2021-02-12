using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revived.Client
{
    public class Program
    {
        private static readonly bool _isAlive = true;

        public static void Main(string[] args)
        {
            Task.Run(() => Application.Run(Client.Instance));
            Loop();
        }

        private static void Loop()
        {
            var backgroundColor = Color.Black;
            while(_isAlive)
            {
                backgroundColor = backgroundColor == Color.Black ? Color.White : Color.Black;
                Client.Instance.BackColor = backgroundColor;

                Thread.Sleep(500);
            }
        }
    }
}
