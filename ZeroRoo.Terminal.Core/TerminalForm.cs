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
using UI.Q.Controls;
using ZeroRoo.Terminal.Core;

namespace ZeroRoo.Terminal
{
    public partial class TerminalForm : QForm
    {
        public TerminalForm()
        {
            InitializeComponent();
        }
        private TerminalManager manager = new TerminalManager();

        private void qTabControl1_PageRemoved(object sender, DSkin.Controls.DSkinPageRemovedEventArgs e)
        {
            if (this.qtbMain.TabPages.Count == 1)
            {
                this.Close();
            }
        }

        private void TerminalForm_Load(object sender, EventArgs e)
        {
            this.qtbMain.TabPages.Clear();
            var lastSession = manager.GetLastSessions();
            if (lastSession.Count == 0)
            {
                var session = manager.CreateDefaultSession();
                DSkin.Controls.DSkinTabPage page = new DSkin.Controls.DSkinTabPage();
                QPanel panel = new QPanel();
                panel.Dock = DockStyle.Fill;
                panel.Padding = new Padding(10, 10, 10, 10);

                TerminalTextBox box = new TerminalTextBox();
                box.NewCommandLine();
                box.Dock = DockStyle.Fill;
                box.Multiline = true;
                box.NewLineSubmit += Box_NewLineSubmit;
                page.Text = session.WorkDirectory;
                page.Padding = new Padding(10, 10, 10, 10);
                panel.DUIControls.Add(box);
                page.Controls.Add(panel);
                this.qtbMain.TabPages.Add(page);
                this.qtbMain.SelectedTab = page;
            }
        }

        private void Box_NewLineSubmit(TerminalTextBox box, string commandLine)
        {
            box.NewCommandLine();
        }
    }
}
