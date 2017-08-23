using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace Sample1
{
    public class Menu : INavigationProvider
    {
        public void BuildNavigation(NavigationBuilder builder)
        {
            for (var i = 0; i < 20; i++)
            {
                builder.Add("Sample1", "Chrome", "Chrome", "chrome.png", x => { }, new SampleActivity());
            }
        }
    }
}
