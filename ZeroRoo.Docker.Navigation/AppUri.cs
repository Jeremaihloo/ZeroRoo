using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZeroRoo.Docker.Navigation
{
    public enum AppUriType
    {
        HtmlFile,
        WebUrl,
        ServiceAction,
        NativeApp,
        File,
        Dir,
        Activity,
        None
    }

    public class AppUri
    {
        private static Dictionary<string, AppUriType> protocols = new Dictionary<string, AppUriType>()
        {
            {"HtmlFile*", AppUriType.HtmlFile },
            {"WebUrl*" , AppUriType.WebUrl},
            {"ServiceAction*", AppUriType.ServiceAction },
            {"Native*", AppUriType.NativeApp },
            {"File*", AppUriType.File },
            {"Dir*", AppUriType.Dir },
            {"Activity*", AppUriType.Activity }
        };

        public string FullPath { get; set; }
        public AppUriType UriType { get; set; }

        public virtual AppUriType Type
        {
            get
            {
                try
                {
                    var r = protocols.Where(h => this.FullPath.StartsWith(h.Key)).FirstOrDefault();
                    return r.Value;
                }
                catch
                {
                    return AppUriType.None;
                }
            }
        }
        
        public AppUri(string path)
        {
            this.FullPath = path;
        }

        public bool Match(string routePattern)
        {
            var m = new Regex(routePattern);
            return m.IsMatch(this.FullPath);
        }
    }
}
