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

namespace ZeroRoo.Docker.Shapes
{
    public partial class Dashboard : QForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Size = new Size(500, 50);
            this.ShowInTaskbar = false;
            this.ShowSystemButtons = false;
            this.TopMost = true;
            this.DrawIcon = false;
            this.BackColor = Color.FromArgb(100, 255, 255, 255);
            this.Location = new Point((Screen.GetWorkingArea(this).Width - this.Width) / 2,
                Screen.GetWorkingArea(this).Height - this.Height);
            this.Text = "";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MoveMode = DSkin.Forms.MoveModes.None;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            this.Location = new Point((Screen.GetWorkingArea(this).Width - this.Width) / 2,
                Screen.GetWorkingArea(this).Height - this.Height);
        }
    }
}
