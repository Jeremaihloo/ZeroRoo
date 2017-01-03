using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.App;

namespace ZeroRoo.Apps.AppStore
{
    public class App : WindowApp
    {

        public override void OnStart()
        {
            AppStoreForm form = new AppStoreForm();
            this.SetWindow(form);
        }

    }
}
