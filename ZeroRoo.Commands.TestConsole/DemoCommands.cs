using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Commands.TestConsole
{
    public class MyCommand : DefaultCommandHandler
    {
        public MyCommand() : base() { }

        public string FooBar()
        {
            return "success!";
        }

        [CommandName("Foo Bar")]
        public string Foo_Bar(string bleah)
        {
            return bleah;
        }
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
