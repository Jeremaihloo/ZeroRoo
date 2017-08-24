using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.FileSystem;

namespace ZeroRoo.Docker.Cores.Services
{
    public class GetAppMenuItems : IAppService
    {
        private INavigationManager navigationManager;
        private IFileSystem fileSystem;

        public GetAppMenuItems(INavigationManager navigationManager, IFileSystem fileSystem)
        {
            this.navigationManager = navigationManager;
            this.fileSystem = fileSystem;
        }

        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            var menu = this.navigationManager.BuildMenu();
            var appDirProvider = new PhysicalFileProvider(this.fileSystem.GetAppsDir().PhysicalPath);
            foreach (var item in menu)
            {
                item.Icon = $"http://localhost:8000/Apps/{item.App}/{item.Icon}";
                item.Target = $"http://localhost:8000/Apps/{item.App}/{item.Target}";
            }
            msg.Data = menu.ToArray();
            route.SendMessage(msg);
        }
    }
}
