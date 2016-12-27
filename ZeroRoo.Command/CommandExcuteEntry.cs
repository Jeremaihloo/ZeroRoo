using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Command
{
    public class CommandExcuteEntry
    {
        public string Name { get; set; }

        public string SubCommand { get; set; }

        public Dictionary<string,string> Configs { get; set; }

        public Dictionary<string,string> Options { get; set; }
    }
}
