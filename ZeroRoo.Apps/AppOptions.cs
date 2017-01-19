using System.Collections.Generic;

namespace ZeroRoo.Apps
{
    public class AppOptions
    {
        public IList<string> SearchPaths { get; }
            = new List<string>();
    }
}