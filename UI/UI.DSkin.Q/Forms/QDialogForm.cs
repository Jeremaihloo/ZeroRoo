using DSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Q.Forms
{
    public partial class QDialogForm : QForm
    {
        public QDialogForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public QDialogForm(string text, string caption, System.Windows.Forms.MessageBoxButtons buttons)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

            this.txtBox.Text = text;
            this.Text = caption;
            this.qFlowLayoutPanel1.Controls.Clear();
            switch (buttons)
            {
                case MessageBoxButtons.AbortRetryIgnore:
                    this.qFlowLayoutPanel1.Controls.Add(this.btnAbort);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnRetry);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnIgnore);
                    break;
                case MessageBoxButtons.OK:
                    this.qFlowLayoutPanel1.Controls.Add(this.btnOk);
                    break;
                case MessageBoxButtons.OKCancel:
                    this.qFlowLayoutPanel1.Controls.Add(this.btnOk);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnCancel);
                    break;
                case MessageBoxButtons.RetryCancel:
                    this.qFlowLayoutPanel1.Controls.Add(this.btnRetry);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnCancel);
                    break;
                case MessageBoxButtons.YesNo:
                    this.qFlowLayoutPanel1.Controls.Add(this.btnYes);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnNo);
                    break;
                case MessageBoxButtons.YesNoCancel:
                    this.qFlowLayoutPanel1.Controls.Add(this.btnYes);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnNo);
                    this.qFlowLayoutPanel1.Controls.Add(this.btnCancel);
                    break;
                default:
                    break;
            }
            this.qFlowLayoutPanel1.Width = this.qFlowLayoutPanel1.Controls.Count * (this.btnOk.Width + this.btnOk.Margin.Left * 2);
            this.qFlowLayoutPanel1.Location = new Point((this.Width - this.qFlowLayoutPanel1.Width) / 2, this.qFlowLayoutPanel1.Top);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.OK;
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.No;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.Cancel;
            this.Close();
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.Abort;
            this.Close();
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.Retry;
            this.Close();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            QMessageBox.Result = DialogResult.Ignore;
            this.Close();
        }
    }
}
