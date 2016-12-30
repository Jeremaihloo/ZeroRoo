using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace ZeroRoo.Commands.Builtin
{
    public class HelpCommand : DefaultCommandHandler
    {
        private readonly CommandHandlerDescriptorBuilder _builder = new CommandHandlerDescriptorBuilder();

        private readonly IServiceProvider _serviceProvider;

        public HelpCommand(IServiceProvider serviceProvider) : base ()
        {
            this._serviceProvider = serviceProvider;   
        }

        [CommandName("help")]
        [CommandHelp("help", "\tDisplay help text for all available commands")]
        public async Task AllCommandsAsync()
        {
            await Context.Output.WriteLineAsync("List of available commands:");
            await Context.Output.WriteLineAsync("---------------------------");
            await Context.Output.WriteLineAsync();

            var descriptors = GetCommandDescriptors().OrderBy(d => d.Names.First());

            foreach (var descriptor in descriptors)
            {
                await Context.Output.WriteLineAsync(GetHelpText(descriptor));
                await Context.Output.WriteLineAsync();
            }
        }


        [CommandName("help")]
        [CommandHelp("help <command>", "\tDisplay help text for <command>")]
        public async Task SingleCommandAsync(string[] commandNameStrings)
        {
            string command = string.Join(" ", commandNameStrings);
            var descriptors = GetCommandDescriptors()
                .Where(t => t.Names.Any(x => x.StartsWith(command, StringComparison.OrdinalIgnoreCase)))
                .OrderBy(d => d.Names);

            if (!descriptors.Any())
            {
                await Context.Output.WriteLineAsync($"Command {command} doesn't exist");
            }
            else
            {
                foreach (var descriptor in descriptors)
                {
                    await Context.Output.WriteLineAsync(GetHelpText(descriptor));
                    await Context.Output.WriteLineAsync();
                }
            }
        }

        private IEnumerable<CommandDescriptor> GetCommandDescriptors()
        {
            var commandhandlers = _serviceProvider.GetServices<ICommandHandler>();
            return commandhandlers.SelectMany(x => _builder.Build(x.GetType()).Commands);
        }

        private string GetHelpText(CommandDescriptor descriptor)
        {
            if (string.IsNullOrEmpty(descriptor.HelpText))
            {
                return $"{descriptor.MethodInfo.DeclaringType?.FullName}.{descriptor.MethodInfo.Name}: no help text";
            }

            return descriptor.HelpText;
        }
    }
}