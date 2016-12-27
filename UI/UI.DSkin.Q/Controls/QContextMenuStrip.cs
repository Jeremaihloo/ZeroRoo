using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Q.Controls
{
    public class QContextMenuStrip: DSkin.Controls.DSkinContextMenuStrip
    {
        public QContextMenuStrip()
        {
            this.Base = System.Drawing.Color.FromArgb(105, 200, 254);
            this.Arrow = System.Drawing.Color.Black;
            this.Back = System.Drawing.Color.White;
            this.BackRadius = 4;
            this.Fore = System.Drawing.Color.Black;
            this.HoverFore = System.Drawing.Color.White;
            this.RadiusStyle = DSkin.Common.RoundStyle.None;
            this.SkinAllColor = true;
            this.ItemAnamorphosis = false;
            this.ItemBorder = System.Drawing.Color.FromArgb(60, 148, 212);
            this.ItemBorderShow = false;
            this.ItemHover = System.Drawing.Color.FromArgb(60, 148, 212);
            this.ItemPressed = System.Drawing.Color.FromArgb(60, 148, 212);
            this.ItemRadius = 1;
            this.ItemRadiusStyle = DSkin.Common.RoundStyle.None;
            this.ItemSplitter = System.Drawing.Color.FromArgb(60, 148, 212);
            this.TitleAnamorphosis = false;
            this.TitleColor = System.Drawing.Color.FromArgb(227, 233, 236);
            this.TitleLineColor = System.Drawing.Color.Transparent;
            this.TitleRadius = 1;
            this.TitleRadiusStyle = DSkin.Common.RoundStyle.None;
        }
    }
}
