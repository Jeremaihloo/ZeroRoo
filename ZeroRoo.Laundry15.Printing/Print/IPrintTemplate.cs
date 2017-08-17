using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laundry.LibCore.Print
{
    public interface IPrintTemplate
    {
        List<PrintLine> GetLines();
    }
}
