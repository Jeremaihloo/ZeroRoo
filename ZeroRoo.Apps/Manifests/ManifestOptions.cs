using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace ZeroRoo.Apps
{
    public class ManifestOptions 
    {
        public IList<ManifestOption> ManifestConfigurations { get; }
            = new List<ManifestOption>();
    }
}