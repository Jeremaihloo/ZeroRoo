using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Apps.Laundry
{
    public class Menu : INavigationProvider
    {
        public void BuildNavigation(NavigationBuilder builder)
        {
            builder.Add("CreateTicketTest", "开单测试", "icon.png", x => { }, typeof(TestForm));
            //var testForm = new LaundryTicketForm();
            builder.Add("CreateTicket", "开单", "icon.png", x => { }, typeof(LaundryTicketForm));
        }
    }
}
