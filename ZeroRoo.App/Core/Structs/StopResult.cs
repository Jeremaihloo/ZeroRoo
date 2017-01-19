using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps
{
    public class StopResult
    {
        public bool Cancel
        {
            get
            {
                return this.Args.Where(item => item.Cancel == true).Any();
            }
        }

        public List<AppStopEventArgs> Args { get; set; }

        public List<AppStopEventArgs> CancelArgs
        {
            get
            {
                return this.CancelArgs.Where(item => item.Cancel == true).ToList();
            }
        }

        public StopResult()
        {
            this.Args = new List<AppStopEventArgs>();
        }
    }
}
