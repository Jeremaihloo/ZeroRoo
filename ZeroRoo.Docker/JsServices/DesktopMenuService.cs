using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.Docker.Shapes;
using ZeroRoo.Docker.JsServices.Structs;
using ZeroRoo.FileSystem;
using Microsoft.Extensions.FileProviders;
using System.IO;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.JsServices
{
    public class DesktopMenuService : IAppService
    {
        public string Name { get; set; }

        private INavigationManager navigationManager;
        private IMenuItemButtonBuilder menuItemButtonBuilder;
        private IMenuItemButtonProvider menuItemButtonProvider;
        private IActivityManager activityManager;
        private IFileSystem fileSystem;

        public DesktopMenuService(INavigationManager navigationManager,
                                    IMenuItemButtonProvider menuItemButtonProvider,
                                    IMenuItemButtonBuilder menuItemButtonBuilder,
                                    IActivityManager activityManager,
                                    IFileSystem fileSystem)
        {
            this.navigationManager = navigationManager;
            this.menuItemButtonProvider = menuItemButtonProvider;
            this.menuItemButtonBuilder = menuItemButtonBuilder;
            this.activityManager = activityManager;
            this.fileSystem = fileSystem;
        }

        public IShape[] GetButtons()
        {
            var menu = this.navigationManager.BuildMenu();

            var buttons = this.menuItemButtonProvider.GetButtons(this.menuItemButtonBuilder, menu);

            var appDirProvider = new PhysicalFileProvider(this.fileSystem.GetAppsDir().PhysicalPath);
            foreach(var item in buttons)
            {
                var h = item as MenuItemButton;
                h.MenuItem.Icon = Path.Combine(appDirProvider.Root, h.MenuItem.App, h.MenuItem.Icon);
                h.MenuItem.Activity.HtmlUri = Path.Combine(appDirProvider.Root, h.MenuItem.App, h.MenuItem.Activity.HtmlUri);
            }
            return buttons.ToArray();
        }

        public void Open(string name)
        {
            var menu = this.navigationManager.BuildMenu();
            var current = menu.FirstOrDefault(h => h.Name == name);
            if (current != null)
            {
                this.activityManager.Active(current.Activity as IActivity);
            }
        }
    }
}
