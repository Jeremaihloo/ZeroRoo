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
            builder.Add("Sample1", "Chrome", "Sample", "chrome.png", x => { }, "sample");
        }
    }
}
