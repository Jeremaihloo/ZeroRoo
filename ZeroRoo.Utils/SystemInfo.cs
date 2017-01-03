using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Utils
{
    public class SystemInfo
    {
        public bool Debug
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(DebuggableAttribute), false).Length > 0;
            }
        }
    }
}
