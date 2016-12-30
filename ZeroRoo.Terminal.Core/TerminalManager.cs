using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Terminal.Core
{
    public class TerminalManager
    {
        private List<TerminalSession> CurrentSessions { get; set; }

        public TerminalSession CreateDefaultSession()
        {
            return this.CreateSession(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        public TerminalManager()
        {
            this.CurrentSessions = new List<TerminalSession>();
        }

        public List<TerminalSession> GetLastSessions()
        {
            return new List<TerminalSession>();
        }

        public TerminalSession CreateSession(string workDir)
        {
            var session = new TerminalSession(workDir);
            this.CurrentSessions.Add(session);
            return session;
        }
    }
}
