using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Abstractions.Manifests;

namespace ZeroRoo.Apps.Abstractions
{
    public interface IAppInfo
    {
        string Id { get; }
        IFileInfo AppFileInfo { get; set; }
        string SubPath { get; }
        IManifestInfo Manifest { get; }
    }
}
