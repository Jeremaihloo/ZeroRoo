using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Services;
using ZeroRoo.FileSystem;

namespace ZeroRoo.DefaultApp.Services
{
    public class GetDesktopFiles : IAppService
    {
        private IFileSystem fileSystem;

        public GetDesktopFiles(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public string GetIconLocation(string filename)
        {
            var icon = Icon.ExtractAssociatedIcon(filename);
            var fileProvider = new PhysicalFileProvider(this.fileSystem.GetDesktopFilesDir().PhysicalPath);

            var file = fileProvider.GetFileInfo($"{filename}.icon");
            if (!file.Exists)
            {
                icon.ToBitmap().Save(file.PhysicalPath);
            }
            return file.PhysicalPath;
        }

        struct DesktopFile
        {
            public string Name;
            public string Target;
            public bool IsDir;
            public string Icon;
        }
        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            var fileProvider = new PhysicalFileProvider(this.fileSystem.GetDesktopFilesDir().PhysicalPath);
            var contents = fileProvider
                            .GetDirectoryContents("")
                            .Select(h => new DesktopFile
                            {
                                Name = h.Name,
                                Target = h.PhysicalPath,
                                IsDir = h.IsDirectory,
                                Icon = ""
                            }).ToArray();
            //for (var i = 0; i < contents.Length; i++)
            //{
            //    contents[i].Icon = GetIconLocation(contents[i].Target);
            //}
            msg.Data = contents;
            route.SendMessage(msg);
        }
    }
}
