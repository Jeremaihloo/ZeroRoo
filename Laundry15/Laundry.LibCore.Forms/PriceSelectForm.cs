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

namespace Laundry.LibCore.Forms
{
    public partial class PriceSelectForm : QForm
    {
        public PriceSelectForm()
        {
            InitializeComponent();
        }

        ClotheCategoryRepository rep = new ClotheCategoryRepository();

        List<ClotheCategory> list = new List<ClotheCategory>();

        ClotheCategory currentCategory = null;
        private void PriceSelectForm_Load(object sender, EventArgs e)
        {
            this.lvPrice.Columns.Add("名称", 250);
            this.lvPrice.Columns.Add("价格", 150);

            this.list = rep.List();
            this.currentCategory = this.list[0];

            this.fpCategory.Controls.Clear();
            foreach(var item in list)
            {
                Button btn = new Button();
                btn.Tag = item.ID;
                btn.Text = item.Text;
                //btn.Dock = DockStyle.Fill;
                
                this.fpCategory.Controls.Add(btn);
                btn.Height = btn.Parent.Height -10;
                btn.Click += Btn_Click;
            }


            Bind();
        }

        void Bind()
        {
            this.lvPrice.Items.Clear();
            foreach (var item in this.currentCategory.ClotheInfos)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.Tag = item.ID;
                lvi.SubItems.Add(item.PriceString);
                this.lvPrice.Items.Add(lvi);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.currentCategory = this.list[(int)((Button)sender).Tag - 1];

            this.Bind();
        }
        public static Price Result { get; set; }

        private void lvPrice_DoubleClick(object sender, EventArgs e)
        {
            var selected = this.lvPrice.SelectedItems[0];
            Result = this.currentCategory.ClotheInfos.FirstOrDefault(item => item.ID == (int)selected.Tag);
            this.Close();
        }
    }
}
