using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public class ConfigPropertyAttribute : Attribute
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
