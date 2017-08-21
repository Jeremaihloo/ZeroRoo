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
            builder.Add("Sample1", "Chrome", "Chrome", "chrome.png", x => { }, new SampleActivity());
            builder.Add("Sample1", "Firefox", "Firefox", "firefox.png", x => { }, new SampleActivity());

        }
    }
}
