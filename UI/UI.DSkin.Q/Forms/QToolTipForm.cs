using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q.Controls;

namespace UI.Q.Forms
{
    public partial class QToolTipForm : QForm
    {
        public static QToolTipForm NewBind(DSkin.Controls.DSkinBaseControl tipControl, string text = "default text", int tipHeight = 20)
        {
            var toolTipForm = new QToolTipForm(tipControl, text, tipHeight);
            toolTipForm.TopLevel = true;
            toolTipForm.TopMost = true;
            return toolTipForm;
        }

        public enum TooTipShowMode
        {
            OnMouseMove,
            OnMouseClick
        }

        public int TipHeight { get; set; }

        public QLabel Label { get; set; }

        public DSkin.Controls.DSkinBaseControl TipControl { get; set; }

        public QToolTipForm(DSkin.Controls.DSkinBaseControl tipControl, string text = "default text", int tipHeight=20)
        {
            InitializeComponent();

            this.TipHeight = tipHeight;
            this.TipControl = tipControl;
            this.TipControl.MouseEnter += tipControl_MouseEnter;
            this.TipControl.MouseLeave += tipControl_MouseLeave;

            this.Label = new QLabel();
            this.Label.AutoSize = false;
            this.Label.TextAlign = ContentAlignment.MiddleCenter;
            this.Label.Dock = DockStyle.Fill;
            this.Label.ForeColor = Color.White;
            this.Label.Text = text;
            this.Controls.Add(this.Label);

            this.TopMost = true;
        }

        private void tipControl_MouseLeave(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tipControl_MouseEnter(object sender, EventArgs e)
        {
            this.CalculateLocation();
            this.Show();
        }

        private void CalculateLocation()
        {
            if (this.TipControl.Width > this.Width)
            {
                this.Location = this.TipControl.FindForm().PointToScreen(new Point(this.TipControl.Left + (this.TipControl.Width - this.Width) / 2,
                    this.TipControl.Top - this.TipHeight));
            }
            else
            {
                this.Location = this.TipControl.FindForm().PointToScreen(new Point(this.TipControl.Left - (this.Width - this.TipControl.Width) / 2,
                    this.TipControl.Top - this.TipHeight));
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.CaptionHeight = 0;
            this.Size = new Size(100, 10);
            this.Text = "";
            this.ShowInTaskbar = false;
            this.ShowSystemButtons = false;
            this.TopMost = true;
            this.DrawIcon = false;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.BackColor = Color.FromArgb(200, 0, 0, 0);

            this.CalculateLocation();
        }
    }
}
