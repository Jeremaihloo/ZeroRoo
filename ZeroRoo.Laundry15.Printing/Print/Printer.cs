using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;

namespace Laundry.LibCore.Print
{
    public class Printer
    {
        IPrintTemplate Template;

        PrintDrawer drawer;

        Bitmap qrcode;

        public Printer()
        {
            this.drawer = new PrintDrawer();
        }

        public Size PageSize = new Size(224, 600);

        public void Print(IPrintTemplate template, Bitmap qrcode)
        {
            this.qrcode = qrcode;
            this.Template = template;
            this.PageSize.Height = (int)this.drawer.MessureHeight(template.GetLines());

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += pd_PrintPage;
            //设置边距
            Margins margin = new Margins(10, 10, 10, 10);

            pd.DefaultPageSettings.Margins = margin;

            //纸张设置默认
            PaperSize pageSize = new PaperSize("自定义纸张", this.PageSize.Width, this.PageSize.Height);
            pd.DefaultPageSettings.PaperSize = pageSize;

            pd.Print();
        }

        //public void PreView(List<PrintLine> lines, bool hasQRCode = true)
        //{
        //    this.HasQRCode = hasQRCode;
        //    if (!this.HasQRCode)
        //        this.PageHeight = 350;
        //    this.Lines = lines;

        //    PrintDocument pd = new PrintDocument();
        //    pd.PrintPage += pd_PrintPage;
        //    //设置边距

        //    Margins margin = new Margins(10, 10, 10, 10);

        //    pd.DefaultPageSettings.Margins = margin;
        //    //纸张设置默认
        //    PaperSize pageSize = new PaperSize("自定义纸张", 228, (int)MessureHeight(lines) + 150);
        //    pd.DefaultPageSettings.PaperSize = pageSize;

        //    PrintPreviewDialog dialog = new PrintPreviewDialog();
        //    dialog.Document = pd;
        //    dialog.ShowDialog();
        //}

        void pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            this.drawer.Draw(this.Template, this.PageSize, e.Graphics, this.qrcode);
        }
    }
}
