using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Commands.Parameters;

namespace ZeroRoo.Commands
{
    public class ZeroRooCommandHost : ICommandHost
    {
        public string WorkDirectory { get; set; }

        public TextReader Input { get; set; }

        public TextWriter Output { get; set; }

        public IServiceProvider ServiceProvider { get; set; }

        public ZeroRooCommandHost(
            IServiceProvider serviceProvider,
            TextReader input,
            TextWriter output, string workDirectory)
        {
            this.ServiceProvider = serviceProvider;
            this.Input = input;
            this.Output = output;
            this.WorkDirectory = workDirectory;
        }

        public Task<CommandReturnCodes> RunSingleCommandAsync(string cmdLine)
        {
            return null;
        }
    }
}
