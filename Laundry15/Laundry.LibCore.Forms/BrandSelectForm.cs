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
    public partial class BrandSelectForm : QForm
    {
        public BrandSelectForm()
        {
            InitializeComponent();
        }
        private List<Brand> list = new List<Brand>();
        private BrandRepository rep = new BrandRepository();

        private Brand selectBrand = new Brand();

        public void Set(Brand b)
        {
            this.selectBrand = b;
        }

        private void BrandSelectForm_Load(object sender, EventArgs e)
        {
            this.list = rep.List();
            this.lvBrand.Columns.Add("品牌", this.lvBrand.Width - 30);

            foreach(var item in this.list)
            {
                ListViewItem lvi = new ListViewItem(item.Text);
                this.lvBrand.Items.Add(lvi);
            }
        }

        public static Brand Result { get; set; }

        private void lvBrand_DoubleClick(object sender, EventArgs e)
        {
            var index = this.lvBrand.SelectedItems[0].Index;
            Result = this.list[index];
            this.Close();
        }

        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    foreach(var item in this.fpBox.Controls)
        //    {
        //        var rbtn = item as RadioButton;
        //        if(rbtn.Checked)
        //        {
        //            this.selectBrand = this.list.FirstOrDefault(i => i.ID == (int)rbtn.Tag);
        //        }
        //    }
        //    Result = this.selectBrand;
        //    this.Close();
        //}
    }
}
