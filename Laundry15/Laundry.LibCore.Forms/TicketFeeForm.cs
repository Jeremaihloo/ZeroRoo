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

namespace Laundry.LibCore.Forms
{
    public partial class TicketFeeForm : QForm
    {
        public TicketFeeForm()
        {
            InitializeComponent();
        }

        private LaundryRepository laundryRepository = new LaundryRepository();
        private LaundryTicket ticket;

        public void SetTicket(LaundryTicket ticket)
        {
            this.ticket = ticket;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var fee = new FeeRecord();
            fee.Vip = ticket.Vip;
            fee.FeeType = FeeType.LuandryTicket;
            fee.FromCash = this.nudFromCash.Value;
            fee.FromVip = this.nudFromVip.Value;
            this.laundryRepository.Pay(fee.Vip.ID, ticket.ID, fee.FromCash, fee.FromVip);
        }
    }
}
