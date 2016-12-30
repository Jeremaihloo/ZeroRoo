using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Terminal.Core
{
    public class TerminalSession
    {
        public string WorkDirectory { get; set; }
        
        public TerminalSession(string workDir)
        {
            this.WorkDirectory = workDir;
        }
    }
}
