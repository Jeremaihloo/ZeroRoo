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
using UI.Q;
using System.Runtime.InteropServices;

namespace Laundry.LibCore.Forms
{
    public partial class TicketClotheForm : QForm
    {
        public TicketClotheForm()
        {
            InitializeComponent();
        }

        private void TicketClotheForm_Load(object sender, EventArgs e)
        {
            if (this.clothe != null)
            {
                try
                {
                    this.txtName.Text = this.clothe.Name;
                    this.txtPrice.Text = this.clothe.Price.ToString();
                    this.txtBrand.Text = this.clothe.Brand;
                    this.txtColor.Text = this.clothe.Color;
                    var ls = new List<string>();
                    foreach (var item in this.clothe.FlawRecords)
                    {
                        ls.Add(item.Text);
                    }
                    this.txtFlaws.Text = string.Join(",", ls);
                    this.txtMark.Text = this.clothe.Mark;
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                this.clothe = new TicketClotheRecord();
            }
        }
        private TicketClotheRecord clothe = null;

        public static TicketClotheRecord Result { get; set; }

        public void Set(TicketClotheRecord c)
        {
            this.clothe = c;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            PriceSelectForm.Result = null;
            PriceSelectForm price = new PriceSelectForm();
            price.ShowDialog();
            if (PriceSelectForm.Result != null)
            {
                this.clothe.Name = PriceSelectForm.Result.Name;
                this.txtName.Text = PriceSelectForm.Result.Name;
                this.txtPrice.Text = PriceSelectForm.Result.PriceString;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorSelectForm form = new ColorSelectForm();
            form.ShowDialog();
            if (ColorSelectForm.Result != null)
            {
                this.clothe.Color = ColorSelectForm.Result.Text;
                this.txtColor.Text = ColorSelectForm.Result.Text;
            }
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            BrandSelectForm brand = new BrandSelectForm();
            brand.ShowDialog();
            if (BrandSelectForm.Result != null)
            {
                this.clothe.Brand = BrandSelectForm.Result.Text;
                this.txtBrand.Text = BrandSelectForm.Result.Text;
            }
        }

        private void btnFlaw_Click(object sender, EventArgs e)
        {
            FlawSelectForm.FlawRecordList = null;
            FlawSelectForm flaw = new FlawSelectForm();
            flaw.ShowDialog();
            this.clothe.FlawRecords = FlawSelectForm.FlawRecordList;
            if (this.clothe.FlawRecords != null)
            {
                this.txtFlaws.Text = string.Join(",", this.clothe.FlawRecords.Select(item => item.Text).ToArray());
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // 检查价格格式
            int price;
            if (!int.TryParse(this.txtPrice.Text, out price)||string.IsNullOrEmpty(this.txtPrice.Text))
            {
                MessageBox.Show("请检查你填写的价格，可能没填写或者包含空格，逗号，横杠");
                return;
            }
            this.clothe.Price = decimal.Parse(this.txtPrice.Text);
            this.clothe.Mark = this.txtMark.Text;
            Result = this.clothe;
            this.Close();
        }
    }
}
