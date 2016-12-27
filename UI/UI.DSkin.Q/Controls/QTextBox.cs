using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Q.Controls
{
    public class QTextBox: DSkin.Controls.DSkinTextBox
    {
        public QTextBox()
        {
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BitmapCache = false;
            this.Borders.AllWidth = 1;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Location = new System.Drawing.Point(4, 4);
            this.Margin = new System.Windows.Forms.Padding(3, 11, 3, 3);
            this.Size = new System.Drawing.Size(186, 22);
            this.TabIndex = 0;
            this.TransparencyKey = System.Drawing.Color.White;
            this.WaterFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WaterTextOffset = new System.Drawing.Point(0, 2);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            //this.BackgroundImage = Resource.text_box_bg_normal;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            //this.BackgroundImage = Resource.text_box_bg_blue;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            //this.BackgroundImage = Resource.text_box_bg_blue;
        }
    }
}
