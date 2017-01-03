using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laundry.LibCore.Models;
using Laundry.LibCore.Print;
using Laundry.LibCore.Print.Templates;
using UI.Q.Controls;

namespace Laundry.LibCore.Forms
{
    public partial class TicketViewBox : QPanel
    {
        public TicketViewBox()
        {
            this.pictureBox = new QPictureBox();
            this.Controls.Add(this.pictureBox);
        }

        private LaundryTicket ticket;
        public void SetTicket(LaundryTicket ticket)
        {
            this.ticket = ticket;
            this.drawTicket();
        }

        QPictureBox pictureBox;
        Image ticketViewBitmap;

        void drawTicket()
        {
            ticketViewBitmap = new TicketPreviewPrinter().PrintTicket(ticket);
            this.pictureBox.Image = ticketViewBitmap;
            this.pictureBox.Height = ticketViewBitmap.Height;
            this.pictureBox.Width = ticketViewBitmap.Width;
        }
    }
}
