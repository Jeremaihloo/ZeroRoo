using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Shapes
{
    public class MenuItemButtonBuilder : IMenuItemButtonBuilder
    {
        public MenuItemButtonBuilder(IActivityManager activityManager)
        {
            //this.activityManager = activityManager;
        }

        public IShape Build(DockerShapeContext context, MenuItem menuItem)
        {
            MenuItemButton btn = new MenuItemButton();
            btn.Text = menuItem.Text;
            btn.Name = menuItem.Name;
            btn.MenuItem = menuItem;

            //btn.Click += Btn_Click;

            return btn;
        }

        //private IActivityManager activityManager;

        //private void Btn_Click(object sender, EventArgs e)
        //{
        //    var activity = Activator.CreateInstance(menuItem.Activity) as IActivity;
        //    activityManager.Active(activity);
        //}
    }
}
