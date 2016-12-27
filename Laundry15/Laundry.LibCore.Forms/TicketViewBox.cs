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
            InitializeComponent();
        }

        private LaundryTicket ticket;
        public void SetTicket(LaundryTicket ticket)
        {
            this.ticket = ticket;
            this.drawTicket();
        }

        Bitmap ticketViewBitmap;

        void drawTicket()
        {
            var drawer = new PrintDrawer();
            var template = new TicketTemplate(this.ticket);
            var size = new Size(224, (int)drawer.MessureHeight(template.GetLines()));
            ticketViewBitmap = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(ticketViewBitmap);
            drawer.Draw(template, size, g, (Bitmap)Image.FromFile("qrcode.jpg"));
            g.Dispose();
            this.pbxTicketView.Image = ticketViewBitmap;
            this.pbxTicketView.Height = ticketViewBitmap.Height;
            this.Height = this.pbxTicketView.Height;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Width = this.pbxTicketView.Width;
            this.pbxTicketView.Height = this.Height;
        }
    }
}
