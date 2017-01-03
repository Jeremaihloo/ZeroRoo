using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ZeroRoo.Commands.Parameters
{
    public interface ICommandParser
    {
        IEnumerable<string> Parse(string commandLine);
    }
}