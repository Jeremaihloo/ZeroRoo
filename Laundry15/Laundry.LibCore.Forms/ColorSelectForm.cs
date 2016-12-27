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

namespace Laundry.LibCore.Forms
{
    public partial class ColorSelectForm : QForm
    {
        public ColorSelectForm()
        {
            InitializeComponent();
        }

        private List<Models.Color> list = new List<Models.Color>();
        private ColorRepository rep = new ColorRepository();

        private Models.Color selectColor = new Models.Color();

        private void ColorSelectForm_Load(object sender, EventArgs e)
        {
            this.list = rep.List();
            this.lvColor.Columns.Add("颜色", this.lvColor.Width - 30);

            foreach(var item in this.list)
            {
                ListViewItem lvi = new ListViewItem(item.Text);
                this.lvColor.Items.Add(lvi);
            }
        }

        public static Models.Color Result { get; set; }

        //private void btnOk_Click(object sender, EventArgs e)
        //{
        //    foreach(var item in this.fpBox.Controls)
        //    {
        //        var rbtn = item as RadioButton;
        //        if(rbtn.Checked)
        //        {
        //            this.selectColor = this.list.FirstOrDefault(i => i.ID == (int)rbtn.Tag);
        //        }
        //    }
        //    Result = this.selectColor;
        //    this.Close();
        //}

        private void lvColor_DoubleClick(object sender, EventArgs e)
        {
            var index = this.lvColor.SelectedItems[0].Index;
            Result = this.list[index];
            this.Close();
        }
    }
}
