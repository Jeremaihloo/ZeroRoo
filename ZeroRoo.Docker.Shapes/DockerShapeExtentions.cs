using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Docker.Navigation;

namespace ZeroRoo.Docker.Shapes
{
    public static class DockerShapeExtentions
    {
        public static IServiceCollection AddDockerShape(this IServiceCollection services)
        {
            services.AddSingleton<Dashboard>();
            services.AddSingleton<DockerShapeContext>();
            services.AddScoped<IMenuItemButtonBuilder, MenuItemButtonBuilder>();
            services.AddSingleton<IMenuItemButtonProvider, MenuItemButtonsProvider>();
            return services;
        }

        public static IRuntimeBuilder UseDockerNavigation(this IRuntimeBuilder builder)
        {
            var provider = builder.Services.BuildServiceProvider();
            var manager = provider.GetRequiredService<INavigationManager>();
            var menu = manager.BuildMenu();
            var menuProvider = provider.GetRequiredService<IMenuItemButtonProvider>();
            var menuItemBuilder = provider.GetRequiredService<IMenuItemButtonBuilder>();

            var buttons = menuProvider.GetButtons(menuItemBuilder, menu);

            return builder;
        }
    }
}
