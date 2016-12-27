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

namespace ZeroRoo.Terminal
{
    public partial class TerminalForm : QForm
    {
        public TerminalForm()
        {
            InitializeComponent();
        }

        private void qTabControl1_PageRemoved(object sender, DSkin.Controls.DSkinPageRemovedEventArgs e)
        {
            if(this.qtbMain.TabPages.Count==1)
            {
                this.Close();
            }
        }
    }
}
