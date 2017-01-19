using System.Collections.Generic;
using Microsoft.Extensions.FileProviders;
using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps.Abstractions
{
    public interface IAppInfo
    {
        /// <summary>
        /// The id of the extension
        /// </summary>
        string Id { get; }

        IFileInfo AppFileInfo { get; }

        /// <summary>
        /// The path to the extension
        /// </summary>
        string SubPath { get; }

        bool Exists { get; }

        /// <summary>
        /// The manifest file of the extension
        /// </summary>
        IManifestInfo Manifest { get; }

        /// <summary>
        /// List of features in extension
        /// </summary>
        IEnumerable<IFeatureInfo> Features { get; }
    }
}
