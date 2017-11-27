using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.Docker.Navigation;
using ZeroRoo.FileSystem;

namespace ZeroRoo.DefaultApp.Services
{
    public class GetAppMenuItems : IAppService
    {
        private INavigationManager navigationManager;
        private IFileProvider provider;
        private DefaultFilesMapping mappings;

        public GetAppMenuItems(INavigationManager navigationManager, IRuntimeEnviroment env, DefaultFilesMapping mappings)
        {
            this.navigationManager = navigationManager;
            this.provider = env.RootFileProvider;
        }

        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            var menu = this.navigationManager.BuildMenu();
            var appDirProvider = new PhysicalFileProvider(this.mappings.Get(SpecialFileNames.Apps));
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
