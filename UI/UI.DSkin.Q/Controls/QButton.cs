using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSkin.Controls;
using System.Drawing;

namespace UI.Q.Controls
{
    public class QButton:DSkinButton
    {
        public QButton()
        {
            this.Font = new Font("微软雅黑", 9);
            this.BaseColor = Color.FromArgb(200, ((int)(((byte)(29)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.ButtonBorderColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.ForeColor = Color.White;
            this.HoverColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.PressColor = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(140)))), ((int)(((byte)(222)))));
            this.IsPureColor = true;
            this.Radius = 4;
        }
    }
}
