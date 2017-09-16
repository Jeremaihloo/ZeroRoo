using System;
using ZeroRoo.Docker.Navigation;
namespace ZeroRoo.Apps.LaundryAgent
{
    public class Menu : INavigationProvider
    {
        public void BuildNavigation(NavigationBuilder builder)
        {
            builder.Add("ZeroRoo.Apps.LaundryAgent", "agent_main", "代卖衣服", "agent.png", x => { }, "laundry-agent");
        }
    }
}
