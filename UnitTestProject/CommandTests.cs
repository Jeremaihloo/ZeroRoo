using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZeroRoo;
using Microsoft.Extensions.DependencyInjection;
using ZeroRoo.Commands;
using System.IO;
using ZeroRoo.Commands.Parameters;
using System.Diagnostics;
using System.Collections.Generic;

namespace UnitTestProject
{

    [TestClass]
    public class CommandTests
    {
        IServiceCollection services = new ServiceCollection();

        IServiceProvider serviceProvider;

        ICommandManager _manager;

        public CommandTests()
        {
            services.AddCommands();

            services.AddScoped<ICommandHandler, DemoCommand>();

            serviceProvider = services.BuildServiceProvider();

            _manager = serviceProvider.GetService<ICommandManager>();
        }

        [TestMethod]
        public void TestMethod1()
        {
            CommandHostAgent hostAgent = new CommandHostAgent(_manager);

            var output = new StringWriter();

            var switches = new Dictionary<string, string>();
            switches.Add("User", "testUser");
            hostAgent.RunSingleCommandAsync(Console.In, output, "Baz".Split(' '), switches).Wait();

            Trace.WriteLine(output.ToString());
        }

        public class DemoCommand : DefaultCommandHandler
        {
            public DemoCommand() : base() { }

            [CommandSwitch]
            public bool Verbose { get; set; }

            [CommandSwitch]
            public int Level { get; set; }

            [CommandSwitch]
            public string User { get; set; }

            public string Foo()
            {
                return "Command Foo Executed";
            }

            [CommandName("Bar")]
            public string Hello()
            {
                return "Hello World!";
            }

            [CommandSwitches("Verbose, Level, User")]
            [CommandHelp("Baz help")]
            public string Baz()
            {
                string trace = "Command Baz Called";

                if (Verbose)
                {
                    trace += " : This was a test";
                }

                if (Level == 2)
                {
                    trace += " : Entering Level 2";
                }

                if (!String.IsNullOrEmpty(User))
                {
                    trace += " : current user is " + User;
                }

                return trace;
            }

            public string Concat(string left, string right)
            {
                return left + right;
            }

            public string ConcatParams(params string[] parameters)
            {
                string concatenated = "";
                foreach (var s in parameters)
                {
                    concatenated += s;
                }
                return concatenated;
            }

            public string ConcatAllParams(string leftmost, params string[] rest)
            {
                string concatenated = leftmost;
                foreach (var s in rest)
                {
                    concatenated += s;
                }
                return concatenated;
            }

            public void Log()
            {
                return;
            }
        }
    }
}