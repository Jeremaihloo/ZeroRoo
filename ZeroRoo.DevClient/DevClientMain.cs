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
    public partial class DevClientMain : QForm
    {
        public DevClientMain()
        {
            InitializeComponent();
        }

        private void btnRemoteMessage_Click(object sender, EventArgs e)
        {
            RemoteMessageForm form = new RemoteMessageForm();
            form.Show();
        }
    }
}
