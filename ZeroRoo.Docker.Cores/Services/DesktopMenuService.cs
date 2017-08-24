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
        private IFileSystem fileSystem;

        public DesktopMenuService(INavigationManager navigationManager,
                                    IFileSystem fileSystem)
        {
            this.navigationManager = navigationManager;
            this.fileSystem = fileSystem;
        }

        public MenuItem[] GetAppMenuItems(AppServiceMessage msg)
        {
            var menu = this.navigationManager.BuildMenu();
            var appDirProvider = new PhysicalFileProvider(this.fileSystem.GetAppsDir().PhysicalPath);
            foreach(var item in menu)
            {
                item.Icon = $"http://localhost:8000/Apps/{item.App}/{item.Icon}";
                item.Activity.HtmlUri = $"http://localhost:8000/Apps/{item.App}/{item.Activity.HtmlUri}";
            }
            return menu.ToArray();
        }
    }
}
