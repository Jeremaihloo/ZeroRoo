using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laundry.LibCore.Models;
using Laundry.LibCore.Print.Templates;
using System.Drawing;

namespace Laundry.LibCore.Print
{
    public class LaundryPrinter
    {
        public Printer Printer { get; set; }
        public Bitmap QrCode { get; set; }

        public LaundryPrinter()
        {
            this.Printer = new Printer();
            this.QrCode = (Bitmap)Bitmap.FromFile("qrcode.jpg");
        }

        public void PrintTicket(LaundryTicket ticket)
        {
            TicketTemplate template = new TicketTemplate(ticket);
            this.Printer.Print(template, this.QrCode);
        }

        public void PrintFeeRecord(FeeRecord fee)
        {
            FeeRecordTemplate template = new FeeRecordTemplate();
            this.Printer.Print(template, this.QrCode);
        }
    }
}
