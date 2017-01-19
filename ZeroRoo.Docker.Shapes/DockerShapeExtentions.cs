using DSkin.Controls;
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
            services.AddSingleton<IShapeContainer, MenuItemContainer>();
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
            var dashboard = provider.GetRequiredService<Dashboard>();
            var container = provider.GetRequiredService<IShapeContainer>();
            var c = (System.Windows.Forms.Control)container;
            dashboard.Controls.Add(c);

            var buttons = menuProvider.GetButtons(menuItemBuilder, menu);
            container.AddRange(buttons);

            dashboard.Width = c.Width + provider.GetRequiredService<DockerShapeContext>().DockerPadding * 2;
            builder.Services.AddSingleton<Dashboard>(dashboard);
            return builder;
        }
    }
}
