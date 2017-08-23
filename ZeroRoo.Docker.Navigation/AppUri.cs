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
        Activity,
        File,
        WebUrl,
        NativeApp
    }

    public class AppUri
    {
        public string Path { get; set; }
        public AppUriType UriType { get; set; }
        public string HtmlPath { get; set; }
        public IDictionary<string, object> QueryArgs { get; set; }

        public AppUri(string path)
        {
            this.Path = path;
        }

        public bool Match(string routePattern)
        {
            var m = new Regex(routePattern);
            return m.IsMatch(this.Path);
        }
    }
}
