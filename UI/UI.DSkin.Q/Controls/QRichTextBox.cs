using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Q.Controls
{
    public class QRichTextBox: DSkin.Controls.DSkinChatRichTextBox
    {
        public QRichTextBox()
        {
            this.Font = new System.Drawing.Font("微软雅黑", 9);
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
