using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Abstractions.Manifests
{
    public interface IManifestBuilder
    {
        IManifestInfo GetManifest(string subPath);
    }
}
