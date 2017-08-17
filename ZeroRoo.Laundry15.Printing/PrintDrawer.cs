using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laundry.LibCore.Print
{
    public class PrintDrawer
    {
        public PrintDrawer()
        {
            
        }

        public float MessureHeight(List<PrintLine> lines)
        {
            float height = 0;
            for (int i = 0; i < lines.Count; i++)
            {
                var line = lines[i];
                Graphics e = Graphics.FromImage(new Bitmap(1, 1));
                SizeF s = e.MeasureString(line.Line, new Font("宋体", line.FontSize));
                height += s.Height;
            }
            return height;
        }

        public void Draw(IPrintTemplate template, Size pageSize, Graphics g, Bitmap qrcode)
        {
            //this.pageSize.Height = (int)MessureHeight(this.Template.GetLines()) + 150;

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            int pos = 0;
            foreach (var line in template.GetLines())
            {
                sf.Alignment = line.StringAlignment;
                SizeF s = g.MeasureString(line.Line, new Font("宋体", line.FontSize));

                g.DrawString(line.Line, new Font("宋体", line.FontSize), Brushes.Black, new RectangleF(0, pos, pageSize.Width, s.Height), sf);

                pos += (int)s.Height;
            }

            if (qrcode != null)
            {
                g.DrawImage(qrcode, (pageSize.Width - 86) / 2, pos, 86, 86);
            }

            //var pd = (PrintDocument)sender;
            //pd.DefaultPageSettings.PaperSize = new PaperSize("自定义纸张", 228, pos + 20);
        }
    }
    
}
