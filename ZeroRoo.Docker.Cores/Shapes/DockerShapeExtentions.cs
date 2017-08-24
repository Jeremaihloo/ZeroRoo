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
            return services;
        }
    }
}
