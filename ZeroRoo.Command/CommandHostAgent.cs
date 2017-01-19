using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ZeroRoo.Commands
{
    public class CommandHostAgent
    {
        private ICommandManager commandManager;
        public CommandHostAgent(ICommandManager manager)
        {
            this.commandManager = manager;
        }

        public async Task<CommandReturnCodes> RunSingleCommandAsync(TextReader input, TextWriter output, string[] args, IDictionary<string, string> switches)
        {
            return await RunCommandAsync(input, output, args, switches);
        }

        public async Task<CommandReturnCodes> RunCommandAsync(TextReader input, TextWriter output, string[] args, IDictionary<string, string> switches)
        {
            try
            {
                var parameters = new CommandParameters
                {
                    Arguments = args,
                    Switches = switches,
                    Input = input,
                    Output = output
                };

                await commandManager.ExecuteAsync(parameters);

                return CommandReturnCodes.Ok;
            }
            catch (CommandHostRetryException ex)
            {
                // Special "Retry" return code for our host
                await output.WriteLineAsync($"{ex.Message} (Retrying...)");
                return CommandReturnCodes.Retry;
            }
            catch (Exception ex)
            {
                if (ex is TargetInvocationException &&
                    ex.InnerException != null)
                {
                    // If this is an exception coming from reflection and there is an innerexception which is the actual one, redirect
                    ex = ex.InnerException;
                }
                await OutputExceptionAsync(output, string.Format("Error executing command \"{0}\"", string.Join(" ", args)), ex);
                return CommandReturnCodes.Fail;
            }
        }

        private async Task OutputExceptionAsync(TextWriter output, string title, Exception exception)
        {
            // Display header
            await output.WriteLineAsync();
            await output.WriteLineAsync($"{title}");

            // Push exceptions in a stack so we display from inner most to outer most
            var errors = new Stack<Exception>();
            for (var scan = exception; scan != null; scan = scan.InnerException)
            {
                errors.Push(scan);
            }

            // Display inner most exception details
            exception = errors.Peek();
            await output.WriteLineAsync("--------------------------------------------------------------------------------");
            await output.WriteLineAsync();
            await output.WriteLineAsync(string.Format("{0}", exception.Message));
            await output.WriteLineAsync();

            if (!(exception is ZeroCoreException) &&
                exception.InnerException == null)
            {
                await output.WriteLineAsync(string.Format("Exception Details: {0}: {1}", exception.GetType().FullName, exception.Message));
                await output.WriteLineAsync();
                await output.WriteLineAsync("Stack Trace:");
                await output.WriteLineAsync();

                // Display exceptions from inner most to outer most
                foreach (var error in errors)
                {
                    await output.WriteLineAsync(string.Format("[{0}: {1}]", error.GetType().Name, error.Message));
                    await output.WriteLineAsync(string.Format("{0}", error.StackTrace));
                    await output.WriteLineAsync();
                }
            }

            // Display footer
            await output.WriteLineAsync("--------------------------------------------------------------------------------");
            await output.WriteLineAsync();
        }
    }
}