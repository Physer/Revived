using System;
using System.Drawing;
using System.Windows.Forms;

namespace Revived.Client
{
    public class Client : Form
    {
        private static readonly Lazy<Client> _client = new Lazy<Client>(() => new Client());
        public static Client Instance => _client.Value;
        private Client() { Size = new Size(1280, 1024); }
    }
}
