using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q;

namespace ZeroRoo.DevClient
{
    public partial class RemoteMessageForm : QForm
    {
        RemoteMessageServer server = new RemoteMessageServer();

        public RemoteMessageForm()
        {
            InitializeComponent();

            this.server.ClientConnected += Server_ClientConnected;
            this.server.Received += Server_Received;

            this.rtxtMessage.AppendText("server listened at 6006\n");
        }

        private void Server_Received(System.Net.EndPoint end, string message)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.rtxtMessage.AppendText(string.Format("client {0} received\n", end.ToString()));
                this.rtxtMessage.AppendText(string.Format("message: {0} \n", message));
            }));
            
        }

        private void Server_ClientConnected(System.Net.EndPoint end)
        {
            this.BeginInvoke(new Action(() =>
            {
                this.rtxtMessage.AppendText(string.Format("client {0} connected\n", end.ToString()));
            }));
        }
    }
}
