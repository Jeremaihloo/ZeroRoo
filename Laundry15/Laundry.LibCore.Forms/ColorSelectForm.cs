using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry.LibCore.Models;
using Laundry.LibCore.Repository;
using UI.Q;
using UI.Q.Forms;
using DSkin.DirectUI;
using ZeroRoo.Utils;

namespace Laundry.LibCore.Forms
{
    public partial class ColorSelectForm : QSelectorForm
    {
        public ColorSelectForm()
        {
            InitializeComponent();

            this.KeySelectorBar.SelectKeyChanged += KeySelectorBar_SelectKeyChanged;
        }

        private void KeySelectorBar_SelectKeyChanged(object sender, UI.Q.Core.SelectKeyChangedEventArgs e)
        {
            PinYinBuilder builder = new PinYinBuilder();

            var list = this.list
                .Where(item => item.Text.Length > 0)
                .Where(item => builder.GetHanz2PinYinFirst(item.Text[0]) == e.Char)
                .ToArray();

            this.Bind(list);
        }

        private List<Models.Color> list = new List<Models.Color>();
        private ColorRepository rep = new ColorRepository();

        private Models.Color selectColor = new Models.Color();

        private void ColorSelectForm_Load(object sender, EventArgs e)
        {
            this.list = rep.List();

            this.Bind(this.list.ToArray());
        }

        private void Bind(Models.Color[] datas)
        {
            this.SelectDataListBox.Items.Clear();
            foreach (var item in datas)
            {
                var label = new DuiLabel();
                label.Width = this.Width;
                label.Height = 25;
                label.Text = item.Text;
                label.Tag = item;
                label.TextAlign = ContentAlignment.MiddleLeft;
                label.MouseEnter += Label_MouseEnter;
                label.MouseLeave += Label_MouseLeave;
                label.MouseDoubleClick += Label_MouseDoubleClick; ;
                this.SelectDataListBox.Items.Add(label);
            }
        }

        private void Label_MouseDoubleClick(object sender, DuiMouseEventArgs e)
        {
            Result = (sender as DuiLabel).Tag as Models.Color;
            this.Close();
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            ((DuiLabel)sender).BackColor = System.Drawing.Color.Transparent;
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            ((DuiLabel)sender).BackColor = System.Drawing.Color.FromArgb(120, 252, 240, 193);
        }

        public static Models.Color Result { get; set; }
    }
}
