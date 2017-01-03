using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Q.Forms;

namespace UI.Q
{
    public static class QMessageBox
    {
        public static System.Windows.Forms.DialogResult Result;

        public static System.Windows.Forms.DialogResult Show(string text, string caption = "信息", System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK)
        {
            QDialogForm form = new QDialogForm(text, caption, buttons);
            form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            form.Show();
            return Result;
        }

        public static System.Windows.Forms.DialogResult Show(System.Windows.Forms.IWin32Window owner, string text, string caption = "信息", System.Windows.Forms.MessageBoxButtons buttons = System.Windows.Forms.MessageBoxButtons.OK)
        {
            QDialogForm form = new QDialogForm(text, caption, buttons);
            form.ShowDialog(owner);
            return Result;
        }
    }
}
