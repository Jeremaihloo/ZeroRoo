using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Terminal.Core
{
    public class TerminalHost
    {
        public TerminalTextBox Box { get; set; }

        public TerminalSession Session { get; set; }

        public StringReader Reader { get; set; }

        public StringWriter Writer { get; set; }

        public TerminalHost()
        {
            
        }
    }
}
