using Microsoft.Extensions.Logging;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Loaders;

namespace ZeroRoo.Apps.Loaders
{
    public class DefaultAppLoader : IAppLoader
    {
        private readonly IAppLibraryService _extensionLibraryService;
        private readonly ILogger _logger;

        public DefaultAppLoader(
            IAppLibraryService extensionLibraryService,
            ILogger<DefaultAppLoader> logger)
        {
            _extensionLibraryService = extensionLibraryService;
            _logger = logger;
        }

        public string Name => GetType().Name;

        public int Order => 20;

        public AppEntry Load(IAppInfo extensionInfo)
        {
            try
            {
                var assembly = _extensionLibraryService.LoadAppAssembly(extensionInfo);

                if (assembly == null)
                {
                    return null;
                }

                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Loaded referenced ambient extension \"{0}\": assembly name=\"{1}\"", extensionInfo.Id, assembly.FullName);
                }

                return new AppEntry
                {
                    ExtensionInfo = extensionInfo,
                    Assembly = assembly,
                    ExportedTypes = assembly.GetTypes()
                };
            }
            catch
            {
                return null;
            }
        }
    }
}