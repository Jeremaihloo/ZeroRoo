using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Command
{
    [Command]
    public class HelloCommand
    {
        public HelloCommand()
        {
            Console.WriteLine("执行这个命令一定会执行！");
        }

        [SubCommand]
        public void SayHello()
        {
            Console.WriteLine("Hello World !");
        }

        [SubCommand]
        public void SayHello(string sth)
        {
            Console.WriteLine("Hello {0} !", sth);
        }

        [SubCommand]
        public void SayHello(string todo, string sth = "Jeremaihloo")
        {
            Console.WriteLine("{0} {1} !", todo, sth);
        }

        [SubCommand]
        public void Lujiejie(string c, bool getfile)
        {

        }
    }
}
