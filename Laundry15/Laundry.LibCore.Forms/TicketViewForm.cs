using Laundry.LibCore.Models;
using Laundry.LibCore.Print;
using Laundry.LibCore.Print.Templates;
using Laundry.LibCore.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Q;

namespace Laundry.LibCore.Forms
{
    public partial class TicketViewForm : QForm
    {
        public TicketViewForm()
        {
            InitializeComponent();
        }
        private LaundryRepository laundryRepository = new LaundryRepository();
        private LaundryTicket ticket;
        public void SetTicket(LaundryTicket ticket)
        {
            this.ticket = ticket;
            this.BindClothes();
        }

        string[] states = new string[] { "未洗", "已洗", "已取" };

        private void BindClothes()
        {
            this.lvClothe.Items.Clear();
            foreach (var item in ticket.ClotheRecords)
            {
                ListViewItem lvi = new ListViewItem(item.Name);
                lvi.SubItems.Add(item.Price.ToString());
                lvi.SubItems.Add(item.Color);
                lvi.SubItems.Add(states[(int)item.State]);
                lvi.SubItems.Add(item.Loacation);
                lvi.SubItems.Add(item.Brand);
                var lf = new List<string>();
                foreach (var f in item.FlawRecords)
                {
                    lf.Add(f.Text);
                }
                var flaw = string.Join(",", lf);
                lvi.SubItems.Add(flaw);
                lvi.SubItems.Add(item.Mark);
                lvi.SubItems.Add(item.RealTakeOffAt == default(DateTime) ? "" : item.RealTakeOffAt.ToString("yyyy年MM月dd日 HH:MM"));
                this.lvClothe.Items.Add(lvi);
            }
            for(var i=0;i<this.lvClothe.Columns.Count;i++)
            {
                this.lvClothe.Columns[i].Width = -2;
            }
        }

        private void TicketViewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            TicketFeeForm form = new TicketFeeForm();
            form.SetTicket(this.ticket);
            form.ShowDialog();
        }
    }
}
