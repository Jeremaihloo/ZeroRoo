using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.App;

namespace ZeroRoo.Apps.TaskManager
{
    public class App: WindowApp
    {
        public override void OnStart()
        {
            var form = new TaskManagerForm();
            this.SetWindow(form);
        }
    }
}
