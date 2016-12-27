using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Q.Controls
{
    public class QProgressBar: DSkin.Controls.DSkinProgressBar
    {
        public QProgressBar()
        {
            this.Font = new Font("微软雅黑", 9);
            this.BackColor = Color.WhiteSmoke;
            this.ForeColor = Color.White;
            this.ForeColors = new Color[] { Color.FromArgb(41, 140, 222) };
            this.IsDrawText = true;
            this.Size = new Size(300, 20);
        }
    }
}
