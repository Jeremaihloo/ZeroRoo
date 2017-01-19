using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Apps.Abstractions.Manifests
{
    public interface IManifestProvider
    {
        int Priority { get; }
        IConfigurationBuilder GetManifestConfiguration(IConfigurationBuilder configurationBuilder, string subPath);
    }
}
