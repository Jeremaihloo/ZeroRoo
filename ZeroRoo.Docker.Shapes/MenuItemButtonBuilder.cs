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
            this.activityManager = activityManager;
        }

        public IShape Build(DockerShapeContext context, MenuItem menuItem)
        {
            MenuItemButton btn = new MenuItemButton();
            btn.Text = menuItem.Text;
            btn.Name = menuItem.Name;
            btn.Tag = menuItem;
            btn.Size = context.MenuItemButtonSize;
            btn.Click += Btn_Click;

            return btn;
        }

        private IActivityManager activityManager;

        private void Btn_Click(object sender, EventArgs e)
        {
            var menuItem = ((System.Windows.Forms.Control)sender).Tag as MenuItem;
            var activity = Activator.CreateInstance(menuItem.Activity) as IActivity;
            activityManager.Active(activity);
        }
    }
}
