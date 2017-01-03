using ZeroRoo.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Apps.Search
{
    public class App : WindowApp
    {
        public override void OnStart()
        {
            var form = new SearchForm();
            this.SetWindow(form);
        }
    }
}
