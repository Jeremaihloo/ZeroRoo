using Laundry.LibCore.Forms;
using Laundry.LibCore.Models;
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

namespace Laundry.Apps.Search
{
    public partial class SearchForm : QForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private VipRepository vipRepository = new VipRepository();
        private LaundryRepository laundryRepository = new LaundryRepository();

        private List<Vip> vipList = new List<Vip>();
        private List<LaundryTicket> ticketList = new List<LaundryTicket>();

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            this.vipList = this.vipRepository.Search(this.txtSearch.Text);
            this.bindVips();

            this.ticketList = this.laundryRepository.Search(this.txtSearch.Text);
            this.bindTickets();
        }

        void bindVips()
        {
            this.lvUsers.Rows.Clear();

            for (var i = 0; i < this.vipList.Count; i++)
            {
                var item = this.vipList[i];
                DSkin.Controls.DSkinGridListRow lvi = new DSkin.Controls.DSkinGridListRow();
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.VipID });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Name });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Phone });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Address });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Sex });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Balance.ToString() });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.FeeSum.ToString() });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.TicketCount.ToString() });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.ClotheCount.ToString() });
                this.lvUsers.Rows.Add(lvi);
            }
        }

        void bindTickets()
        {
            this.lvTickets.Rows.Clear();

            for(var i=0;i<this.ticketList.Count;i++)
            {
                var item = this.ticketList[i];
                DSkin.Controls.DSkinGridListRow lvi = new DSkin.Controls.DSkinGridListRow();
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Vip.Name });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.Vip.Phone });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.ClotheRecords.Count.ToString() });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.ClotheRecords.Where(t => t.State == TicketClotheState.HasClean).ToList().Count.ToString() });
                lvi.Cells.Add(new DSkin.Controls.DSkinGridListCell() { Text = item.HasPay ? "已付" : "未付" });
                this.lvTickets.Rows.Add(lvi);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void lvTickets_DoubleClick(object sender, EventArgs e)
        {
            TicketViewForm form = new TicketViewForm();
            form.SetTicket(this.ticketList[(int)this.lvTickets.SelectedItem.Tag]);
            form.ShowDialog();
        }
    }
}
