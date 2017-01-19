using Microsoft.Extensions.DependencyInjection;

namespace ZeroRoo.Apps.Manifests
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddManifestDefinition(
            this IServiceCollection services,
            string definitionName,
            string moduleType)
        {
            return services.Configure<ManifestOptions>(configureOptions: options =>
            {
                var option = new ManifestOption {
                    ManifestFileName = definitionName,
                    Type = moduleType
                };

                options.ManifestConfigurations.Add(option);
            });
        }
    }
}