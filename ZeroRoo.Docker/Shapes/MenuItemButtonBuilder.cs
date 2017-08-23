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

        public IShape Build(DockerShapeContext context, MenuItem menuItem)
        {
            MenuItemButton btn = new MenuItemButton();
            btn.Text = menuItem.Text;
            btn.Name = menuItem.Name;
            btn.MenuItem = menuItem;
            
            return btn;
        }
    }
}
