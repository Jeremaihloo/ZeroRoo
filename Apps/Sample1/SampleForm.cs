using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZeroRoo.Docker.Navigation;

namespace Sample1
{
    public partial class SampleForm : Form, IActivity
    {
        public SampleForm()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        public void OnActive()
        {
            if (!this.IsDisposed)
                this.Show();
        }

        public void OnCreate()
        {
            this.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var dForm = new DSkin.Forms.DSkinForm();
            dForm.Show();
        }
    }
}
