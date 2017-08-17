using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.Docker.Shapes;

namespace ZeroRoo.Docker.JsServices
{
    public class DesktopMenuService
    {
        private INavigationManager navigationManager;
        private IMenuItemButtonBuilder menuItemButtonBuilder;
        private IMenuItemButtonProvider menuItemButtonProvider;

        public DesktopMenuService(INavigationManager navigationManager,
                                    IMenuItemButtonProvider menuItemButtonProvider,
                                    IMenuItemButtonBuilder menuItemButtonBuilder)
        {
            this.navigationManager = navigationManager;
            this.menuItemButtonProvider = menuItemButtonProvider;
            this.menuItemButtonBuilder = menuItemButtonBuilder;
        }

        public IEnumerable<MenuItemButton> GetButtons()
        {
            var menu = this.navigationManager.BuildMenu();

            var buttons = this.menuItemButtonProvider.GetButtons(this.menuItemButtonBuilder, menu);

            return buttons.Select(h => h as MenuItemButton).AsEnumerable();
        }
    }
}
