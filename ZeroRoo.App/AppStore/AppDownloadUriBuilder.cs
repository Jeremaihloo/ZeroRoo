using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps
{
    public class AppDownloadUriBuilder
    {
        public string BaseString { get; set; }

        public AppDownloadUriBuilder()
        {
            this.BaseString = "file://";
        }
    }
}
