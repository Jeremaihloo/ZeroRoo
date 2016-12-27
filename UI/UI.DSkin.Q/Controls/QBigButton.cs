using DSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Q.Controls
{
    public class QBigButton: QButton
    {
        public QBigButton()
            :base()
        {
            this.Size = new Size(140, 50);
            this.Font = new Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        }
    }
}
