
using Laundry.LibCore.Print.Templates;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Laundry15.Models;

namespace Laundry.LibCore.Print
{
    public class TicketPreviewPrinter
    {
        public Printer Printer { get; set; }
        public Bitmap QrCode { get; set; }

        public TicketPreviewPrinter()
        {
            this.Printer = new Printer();
            this.QrCode = null;
        }

        public Image PrintTicket(LaundryTicket ticket)
        {
            var drawer = new PrintDrawer();
            var template = new TicketTemplate(ticket);
            var size = new Size(224, (int)drawer.MessureHeight(template.GetLines()));
            var ticketViewBitmap = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(ticketViewBitmap);
            drawer.Draw(template, size, g, (Bitmap)Image.FromFile("qrcode.jpg"));
            g.Dispose();
            return ticketViewBitmap;
        }

        public Image PrintFeeRecord(FeeRecord fee)
        {
            return null;
        }
    }
}
