using System;
using System.Collections.Generic;
using System.Linq;

namespace ZeroRoo.Commands
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CommandSwitchesAttribute : Attribute
    {
        private readonly string _switches;

        public CommandSwitchesAttribute(string switches)
        {
            _switches = switches;
        }

        public IEnumerable<string> Switches
        {
            get
            {
                return (_switches ?? "").Trim().Split(',').Select(s => s.Trim());
            }
        }
    }
}