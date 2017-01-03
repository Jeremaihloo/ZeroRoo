using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry.LibCore.Repository;
using Laundry.LibCore.Models;
using UI.Q;
using UI.Q.Forms;
using DSkin.DirectUI;
using ZeroRoo.Utils;

namespace Laundry.LibCore.Forms
{
    public partial class PriceSelectForm : QSelectorForm
    {
        public PriceSelectForm()
        {
            InitializeComponent();

            this.KeySelectorBar.SelectKeyChanged += KeySelectorBar_SelectKeyChanged;
        }

        private void KeySelectorBar_SelectKeyChanged(object sender, UI.Q.Core.SelectKeyChangedEventArgs e)
        {
            PinYinBuilder builder = new PinYinBuilder();

            var tmp = this.list.FirstOrDefault(h => h.Text == e.Char);

            this.Bind(tmp.ClotheInfos.ToArray());
        }

        ClotheCategoryRepository rep = new ClotheCategoryRepository();

        List<ClotheCategory> list = new List<ClotheCategory>();

        ClotheCategory currentCategory = null;
        private void PriceSelectForm_Load(object sender, EventArgs e)
        {
            this.list = rep.List();
            this.currentCategory = this.list[0];

            PinYinBuilder builder = new PinYinBuilder();
            var pins = this.list.Select(h => h.Text).ToArray();
            this.KeySelectorBar.Keys = pins;

            var tmp = new List<Price>();
            this.Bind(this.list.SelectMany(h=>h.ClotheInfos).ToArray());
        }

        private void Bind(Price[] datas)
        {
            this.SelectDataListBox.Items.Clear();
            foreach (var item in datas)
            {
                var label = createItemLabel(item);
                this.SelectDataListBox.Items.Add(label);
            }
        }

        private DuiLabel createItemLabel(Price item)
        {
            var label = new DuiLabel();
            label.Width = this.Width;
            label.Height = 25;
            label.Text = string.Format("{0:-10}{1:-10}", item.Name, item.PriceString);
            label.Tag = item;
            label.TextAlign = ContentAlignment.MiddleLeft;
            label.MouseEnter += Label_MouseEnter;
            label.MouseLeave += Label_MouseLeave;
            label.MouseDoubleClick += Label_MouseDoubleClick; ;
            return label;
        }

        private void Label_MouseDoubleClick(object sender, DuiMouseEventArgs e)
        {
            Result = ((DuiLabel)sender).Tag as Price;
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

        public static Price Result { get; set; }
    }
}
