using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using ZeroRoo.Commands.Parameters;
using Microsoft.Extensions.DependencyInjection;
using ZeroRoo.Apps.Laundry;

namespace ZeroRoo.Commands.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddCommands();

            services.AddScoped<ICommandHandler, MyCommand>();
            services.AddScoped<ICommandHandler, LaundryCommands>();
            services.AddScoped<ICommandHandler, DemoCommand>();

            var serviceProvider = services.BuildServiceProvider();

            var cmdParser = serviceProvider.GetService<ICommandParser>();
            var pParser = serviceProvider.GetService<ICommandParametersParser>();

            var commandLine = "";
            if (args.Length == 0)
            {
                commandLine = "help";
            }
            else
            {
                commandLine = string.Join(" ", args);
            }
            var cmdParams = pParser.Parse(cmdParser.Parse(commandLine));
            var context = new CommandParameters()
            {
                Arguments = cmdParams.Arguments,
                Switches = cmdParams.Switches
            };

            var _manager = serviceProvider.GetService<ICommandManager>();

            CommandHostAgent hostAgent = new CommandHostAgent(_manager);

            hostAgent.RunSingleCommandAsync(Console.In, Console.Out, context.Arguments.ToArray(), context.Switches)
                .Wait();

        }
    }
}
