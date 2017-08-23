using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.Docker.Shapes;
using ZeroRoo.FileSystem;
using Microsoft.Extensions.FileProviders;
using System.IO;
using ZeroRoo.Apps.Services;

namespace ZeroRoo.Docker.Cores.Services
{
    public class DesktopMenuService : IAppService
    {
        public string Name { get; set; }

        private INavigationManager navigationManager;
        private IMenuItemButtonBuilder menuItemButtonBuilder;
        private IMenuItemButtonProvider menuItemButtonProvider;
        private IFileSystem fileSystem;

        public DesktopMenuService(INavigationManager navigationManager,
                                    IMenuItemButtonProvider menuItemButtonProvider,
                                    IMenuItemButtonBuilder menuItemButtonBuilder,
                                    IFileSystem fileSystem)
        {
            this.navigationManager = navigationManager;
            this.menuItemButtonProvider = menuItemButtonProvider;
            this.menuItemButtonBuilder = menuItemButtonBuilder;
            this.fileSystem = fileSystem;
        }

        public IShape[] GetDockButtons(AppServiceMessage msg)
        {
            var menu = this.navigationManager.BuildMenu();

            var buttons = this.menuItemButtonProvider.GetButtons(this.menuItemButtonBuilder, menu);

            var appDirProvider = new PhysicalFileProvider(this.fileSystem.GetAppsDir().PhysicalPath);
            foreach(var item in buttons)
            {
                var h = item as MenuItemButton;
                h.MenuItem.Icon = $"http://localhost:8000/Apps/{h.MenuItem.App}/{h.MenuItem.Icon}";
                h.MenuItem.Activity.HtmlUri = $"http://localhost:8000/Apps/{h.MenuItem.App}/{h.MenuItem.Activity.HtmlUri}";
            }
            return buttons.ToArray();
        }
    }
}
