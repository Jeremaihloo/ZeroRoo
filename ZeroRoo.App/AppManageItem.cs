using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZeroRoo.App
{
    public class AppManageItem
    {
        public AppConfig Config { get; set; }

        public IApp App { get; set; }

        public Image Icon { get; set; }

        public IAppEnviroment Enviroment { get; set; }

        public int PID { get; set; }
    }
}
