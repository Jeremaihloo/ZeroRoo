using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.DevClient.RemoteClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteMessageClient client = new RemoteMessageClient();
            client.SendConnection("192.168.1.45", 6006);
            client.Send(string.Join(" | ", args));
        }
    }
}
