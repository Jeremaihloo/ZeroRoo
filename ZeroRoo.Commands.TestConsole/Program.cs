using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using ZeroRoo.Commands.Parameters;
using Microsoft.Extensions.DependencyInjection;

namespace ZeroRoo.Commands.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();

            services.AddCommands();

            services.AddScoped<ICommandHandler, MyCommand>();

            var serviceProvider = services.BuildServiceProvider();

            var cmdParser = serviceProvider.GetService<ICommandParser>();
            var pParser = serviceProvider.GetService<ICommandParametersParser>();

            var cmdParams = pParser.Parse(cmdParser.Parse("commands"));
            var context = new CommandParameters()
            {
                Arguments = "commands".Split(' '),
                Switches = cmdParams.Switches,
                Output = new StringWriter()
            };

            var _manager = serviceProvider.GetService<ICommandManager>();

            CommandHostAgent hostAgent = new CommandHostAgent(_manager);
            hostAgent.RunSingleCommandAsync(Console.In, Console.Out, context.Arguments.ToArray(), context.Switches)
                .Wait();

            

            Console.WriteLine(context.Output.ToString());

            Console.ReadKey();
        }
    }
}
