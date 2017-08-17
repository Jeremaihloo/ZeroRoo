using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Laundry.LibCore.Print
{
    public class PrintLine
    {
        public string Line { get; set; }
        public int FontSize { get; set; }
        public StringAlignment StringAlignment { get; set; }
        public PrintLine(string line, int fontSize, StringAlignment sa)
        {
            this.Line = line;
            this.FontSize = fontSize;
            this.StringAlignment = sa;
        }
        public PrintLine(string lin,int fontSize)
        {
            this.Line = lin;
            this.FontSize = fontSize;
            this.StringAlignment = StringAlignment.Near;
        }
    }
}
