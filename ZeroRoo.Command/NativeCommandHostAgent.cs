using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Commands
{
    public class NativeCommandHostAgent
    {
        public string WorkDirectory { get; set; }

        public NativeCommandHostAgent(string workDirectory)
        {
            this.WorkDirectory = workDirectory;
        }

        public async Task RunCommandAsync(string line)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = true;   //不创建窗口
            startInfo.UseShellExecute = false;
            //不使用系统外壳程序启动,重定向输出的话必须设为false
            startInfo.RedirectStandardOutput = true; //重定向输出，
            startInfo.RedirectStandardError = true;
        }
    }
}
