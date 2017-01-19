using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Events;

namespace ZeroRoo.Apps
{
    public class AppContainerFactory: IAppContainerFactory
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger _logger;
        private readonly ILoggerFactory _loggerFactory;
        private readonly IServiceCollection _applicationServices;
        private readonly IRuntimeEnviroment _runtimeEnvironment;

        public AppContainerFactory(
            IServiceProvider serviceProvider,
            ILoggerFactory loggerFactory,
            ILogger<AppContainerFactory> logger,
            IServiceCollection applicationServices,
            IRuntimeEnviroment hostingEnvironment)
        {
            _applicationServices = applicationServices;
            _serviceProvider = serviceProvider;
            _loggerFactory = loggerFactory;
            _runtimeEnvironment = hostingEnvironment;
            _logger = logger;
        }

        public IServiceProvider CreateContainer(IServiceProvider provider)
        {
            var twoServices = provider.CreateChildContainer(_applicationServices);

            twoServices.AddScoped<IEventBus, DefaultZeroEventBus>();
            twoServices.AddSingleton<IEventBusState, EventBusState>();

            var applicationServiceDescriptors = _applicationServices.Where(x => x.Lifetime == ServiceLifetime.Singleton);

            var eventHandlers = twoServices
                .Union(applicationServiceDescriptors)
                .Select(x => x.ImplementationType)
                .Distinct()
                .Where(t => t != null && typeof(IEventHandler).IsAssignableFrom(t) && t.GetTypeInfo().IsClass)
                .ToArray();

            foreach (var handlerClass in eventHandlers)
            {
                // Register dynamic proxies to intercept direct calls if an IEventHandler is resolved, dispatching the call to
                // the event bus.

                foreach (var i in handlerClass.GetInterfaces().Where(t => t != typeof(IEventHandler) && typeof(IEventHandler).IsAssignableFrom(t)))
                {
                    twoServices.AddScoped(i, serviceProvider =>
                    {
                        var proxy = DefaultZeroEventBus.CreateProxy(i);
                        proxy.EventBus = serviceProvider.GetService<IEventBus>();
                        return proxy;
                    });
                }
            }

            var shellServiceProvider = twoServices.BuildServiceProvider();

            using (var scope = shellServiceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var eventBusState = scope.ServiceProvider.GetService<IEventBusState>();

                // Register any IEventHandler method in the event bus
                foreach (var handlerClass in eventHandlers)
                {
                    foreach (var handlerInterface in handlerClass.GetInterfaces().Where(x => typeof(IEventHandler).IsAssignableFrom(x) && typeof(IEventHandler) != x))
                    {
                        foreach (var interfaceMethod in handlerInterface.GetMethods())
                        {
                            //var classMethod = handlerClass.GetMethods().Where(x => x.Name == interfaceMethod.Name && x.GetParameters().Length == interfaceMethod.GetParameters().Length).FirstOrDefault();
                            Func<IServiceProvider, IDictionary<string, object>, Task> d = (sp, parameters) => DefaultZeroEventBus.Invoke(sp, parameters, interfaceMethod, handlerClass);
                            var messageName = $"{handlerInterface.Name}.{interfaceMethod.Name}";
                            var className = handlerClass.FullName;
                            eventBusState.Add(messageName, d);
                        }
                    }
                }
            }
            return shellServiceProvider;
        }
    }
}
