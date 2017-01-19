using ZeroRoo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;
using System.Reflection;
using ZeroRoo;

namespace ZUnitTestProject
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        public void EventsTest()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddScoped<StubEventHandler>();

            var provider = services.BuildServiceProvider();

            var result = provider.GetService(typeof(StubEventHandler));

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void EventsAreCorrectlyDispatchedToEventHandlers()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddScoped<StubEventHandler>();
            
            var provider = services.BuildServiceProvider();

            var twoServices = provider.CreateChildContainer(services);

            twoServices.AddScoped<IEventBus, DefaultZeroEventBus>();
            twoServices.AddSingleton<IEventBusState, EventBusState>();

            var applicationServiceDescriptors = services.Where(x => x.Lifetime == ServiceLifetime.Singleton);

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
                    services.AddScoped(i, serviceProvider =>
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

            var eventBus = shellServiceProvider.GetService<IEventBus>() as DefaultZeroEventBus;

            var stub1 = shellServiceProvider.GetService(typeof(StubEventHandler)) as StubEventHandler;

            Assert.AreEqual(0, stub1.Count);
            eventBus.Notify<ITestEventHandler>(x => x.Increment());
            Assert.AreEqual(1, stub1.Count);
        }

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToEventHandlers()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 5200;
        //    arguments["b"] = 2600;
        //    eventBus.Notify("ITestEventHandler.Substract", arguments);
        //    Assert.AreEqual(2600, stub1.Result);
        //}


        //[TestMethod]
        //public void EventParametersArePassedInCorrectOrderToEventHandlers()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 2600;
        //    arguments["b"] = 5200;
        //    eventBus.Notify("ITestEventHandler.Substract", arguments);
        //    Assert.AreEqual(-2600, stub1.Result);
        //}

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToMatchingMethod()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.Null(stub1.Summary);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = "a";
        //    arguments["b"] = "b";
        //    arguments["c"] = "c";
        //    eventBus.Notify("ITestEventHandler.Concat", arguments);
        //    Assert.AreEqual("abc", stub1.Summary);
        //}

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToExactlyMatchingMethod()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 1000;
        //    arguments["b"] = 100;
        //    arguments["c"] = 10;
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(1110, stub1.Result);
        //}

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToBestMatchingMethodAndExtraParametersAreIgnored()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 1000;
        //    arguments["b"] = 100;
        //    arguments["c"] = 10;
        //    arguments["e"] = 1;
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(1110, stub1.Result);
        //}

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToBestMatchingMethodAndExtraParametersAreIgnored2()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 1000;
        //    arguments["e"] = 1;
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(3000, stub1.Result);
        //}

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToExactlyMatchingMethodWhenThereIsOne()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 1000;
        //    arguments["b"] = 100;
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(2200, stub1.Result);
        //}

        //[TestMethod]
        //public void EventParametersAreCorrectlyPassedToExactlyMatchingMethodWhenThereIsOne2()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["a"] = 1000;
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(3000, stub1.Result);
        //}

        //[TestMethod]
        //public void EventHandlerWontBeCalledWhenNoParameterMatchExists()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    arguments["e"] = 1;
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(0, stub1.Result);
        //}

        //[TestMethod]
        //public void EventHandlerWontBeCalledWhenNoParameterMatchExists2()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.AreEqual(0, stub1.Result);
        //    Dictionary<string, object> arguments = new Dictionary<string, object>();
        //    eventBus.Notify("ITestEventHandler.Sum", arguments);
        //    Assert.AreEqual(0, stub1.Result);
        //}

        //[TestMethod]
        //public void EventBusThrowsIfMessageNameIsNotCorrectlyFormatted()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    Assert.Throws<ArgumentException>(() => eventBus.Notify("StubEventHandlerIncrement", new Dictionary<string, object>()));
        //}

        //[TestMethod]
        //public void InterceptorCanCoerceResultingCollection()
        //{
        //    var data = new object[] { "5", "18", "2" };
        //    var adjusted = DefaultZeroEventBus.Adjust(data, typeof(IEnumerable<string>));
        //    Assert.IsAssignableFrom<IEnumerable<object>>(data);
        //    Assert.IsNotType<IEnumerable<string>>(data);
        //    Assert.IsAssignableFrom<IEnumerable<string>>(adjusted);
        //}

        //[TestMethod]
        //public void EnumerableResultsAreTreatedLikeSelectMany()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    var results = eventBus.Notify("ITestEventHandler.Gather", new Dictionary<string, object> { { "a", 42 }, { "b", "alpha" } }).Cast<string>();
        //    Assert.AreEqual(3, results.Count());
        //    Assert.("42", results);
        //    Assert.Contains("alpha", results);
        //    Assert.Contains("[42,alpha]", results);
        //}

        //[TestMethod]
        //public void StringResultsAreTreatedLikeSelect()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    var results = eventBus.Notify("ITestEventHandler.GetString", new Dictionary<string, object>()).Cast<string>();
        //    Assert.AreEqual(2, results.Count());
        //    Assert.Contains("Foo", results);
        //    Assert.Contains("Bar", results);
        //}

        //[TestMethod]
        //public void NonStringNonEnumerableResultsAreTreatedLikeSelect()
        //{
        //    var stub1 = new StubEventHandler();
        //    var stub2 = new StubEventHandler2();
        //    var eventBus = new DefaultZeroEventBus(new IEventHandler[] { stub1, stub2 });

        //    var results = eventBus.Notify("ITestEventHandler.GetInt", new Dictionary<string, object>()).Cast<int>();
        //    Assert.AreEqual(2, results.Count());
        //    Assert.Contains(1, results);
        //    Assert.Contains(2, results);
        //}


        public interface ITestEventHandler : IEventHandler
        {
            void Increment();
            void Sum(int a);
            void Sum(int a, int b);
            void Sum(int a, int b, int c);
            void Substract(int a, int b);
            void Concat(string a, string b, string c);
            IEnumerable<string> Gather(int a, string b);
            string GetString();
            int GetInt();
        }

        public class StubEventHandler : ITestEventHandler
        {
            public int Count { get; set; }
            public int Result { get; set; }
            public string Summary { get; set; }

            public void Increment()
            {
                Count++;
            }

            public void Sum(int a)
            {
                Result = 3 * a;
            }

            public void Sum(int a, int b)
            {
                Result = 2 * (a + b);
            }

            public void Sum(int a, int b, int c)
            {
                Result = a + b + c;
            }

            public void Substract(int a, int b)
            {
                Result = a - b;
            }

            public void Concat(string a, string b, string c)
            {
                Summary = a + b + c;
            }

            public IEnumerable<string> Gather(int a, string b)
            {
                yield return string.Format("[{0},{1}]", a, b);
            }

            public string GetString()
            {
                return "Foo";
            }

            public int GetInt()
            {
                return 1;
            }
        }
        public class StubEventHandler2 : ITestEventHandler
        {
            public void Increment()
            {
            }

            public void Sum(int a)
            {
            }

            public void Sum(int a, int b)
            {
            }

            public void Sum(int a, int b, int c)
            {
            }

            public void Substract(int a, int b)
            {
            }

            public void Concat(string a, string b, string c)
            {
            }

            public IEnumerable<string> Gather(int a, string b)
            {
                return new[] { a.ToString(), b };
            }

            public string GetString()
            {
                return "Bar";
            }

            public int GetInt()
            {
                return 2;
            }
        }
    }
}