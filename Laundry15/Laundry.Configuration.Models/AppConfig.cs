using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Configuration.Models
{
    public class AppConfig
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Enable { get; set; }

        public bool Visible { get; set; }

        public string Icon { get; set; }

        public string Dll { get; set; }

        public bool AutoStart { get; set; }
    }
}
