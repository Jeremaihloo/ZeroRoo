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

        public void OnService(AppServiceRoute route, AppServiceMessage msg)
        {
            throw new NotImplementedException();
        }

        //public DesktopFileButton[] GetDesktopFiles()
        //{
        //    var fileProvider = new PhysicalFileProvider(this.fileSystem.GetDesktopFilesDir().PhysicalPath);
        //    var contents = fileProvider
        //                    .GetDirectoryContents("")
        //                    .Select(h => new DesktopFileButton()
        //                    {
        //                        Name = h.Name,
        //                        FileUri = h.PhysicalPath,
        //                        IsDir = h.IsDirectory,
        //                        Icon = GetIconLocation(h.PhysicalPath)
        //                    }).ToArray();
        //    return contents;
        //}
    }
}
