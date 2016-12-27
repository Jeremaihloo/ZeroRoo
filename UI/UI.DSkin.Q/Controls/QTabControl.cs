using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSkin.Controls;

namespace UI.Q.Controls
{
    public class QTabControl : DSkinTabControl
    {
        public QTabControl()
            : base()
        {
            this.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ItemBackgroundImage = Resource.TabControl_ItemBackgroundImage;
            this.ItemBackgroundImageHover = Resource.TabControl_ItemBackgroundImageHover;
            this.ItemBackgroundImageSelected = Resource.TabControl_ItemBackgroundImageSelected;
            this.Font = new System.Drawing.Font("微软雅黑", 9);
            this.Borders.AllColor = System.Drawing.Color.Gray;
            this.ItemSize = new System.Drawing.Size(100, 36);
        }
    }
}
