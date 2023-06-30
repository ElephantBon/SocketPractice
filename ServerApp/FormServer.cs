using System.Net.Sockets;
using System.Text;

namespace ServerApp
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();

            // initialize UI properties that related to business logic
            foreach(Control ct in tlpClientInfo.Controls)   // everything of client info are read-only
                if(ct is TextBox)
                    ((TextBox)ct).ReadOnly = true;

            ServerHelper.StartServer(8000);
        }

        private void lisbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormServer_FormClosed(object sender, FormClosedEventArgs e)
        {
            // close server on closing form
            ServerHelper.CloseServer();
        }
    }
}