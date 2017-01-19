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
            services.AddScoped<IShapeContainer, MenuItemContainer>();
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
            var buttons = menuProvider.GetButtons(menuItemBuilder, menu);
            container.AddRange(buttons);
            var c = (System.Windows.Forms.Control)container;
            c.Dock = System.Windows.Forms.DockStyle.Fill;
            dashboard.Controls.Add(c);
            return builder;
        }
    }
}
