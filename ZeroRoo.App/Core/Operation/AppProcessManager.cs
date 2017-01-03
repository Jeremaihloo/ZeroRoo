using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Configuration;

namespace ZeroRoo.App
{
    public class AppProcessManager
    {
        public List<AppManageItem> Running { get; set; }

        public AppLoader appLoader = null;

        private AppSystem system = new AppSystem();

        private Dictionary<string, object> globalEnv = new Dictionary<string, object>();
        
        public AppProcessManager(AppLoader loader)
        {
            if(loader.HasLoad == false)
            {
                loader.Load();
            }
            this.appLoader = loader;
            this.Running = new List<AppManageItem>();
        }

        private bool IfDebug()
        {
            bool ifDebug = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(DebuggableAttribute), false).Length > 0;
            return ifDebug;
        }

        public void AutoStartApps()
        {
            var list = this.appLoader.AppManageItems.Where(item => item.Config.StartWay == StartWay.Auto);
            foreach(var item in list)
            {
                this.Start(item);
            }
        }
        
        public IAppEnviroment CreateEnv(AppManageItem manageItem)
        {
            IAppEnviroment env = new AppEnviroment();

            env.AppConfig = manageItem.Config;
            foreach (var item in this.globalEnv)
            {
                env.Set(item.Key, item.Value);
            }
            return env;
        }

        public void SetGlobalEnviroment(string key, object value)
        {
            this.globalEnv[key] = value;
        }

        public void Start(AppManageItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            if(item.Config.Mode == AppMode.Single && this.Running.Where(h=>h.Config.ID==item.Config.ID).Any())
            {
                this.Running.FirstOrDefault(h => h.Config.ID == item.Config.ID).App.OnWakeUp();
            }
            else
            {
                var env = this.CreateEnv(item);

                env.Set("IFDEBUG", this.IfDebug());

                item.Enviroment = env;

                item.App.OnStart();

                item.PID = NewPID();

                item.App.Stopping += App_Stop;

                this.Running.Add(item);
            }
            
        }

        private void App_Stop(object sender, EventArgs e)
        {
            var item = this.Running.FirstOrDefault(h => h.App == (sender as IApp));
            this.Running.Remove(item);
        }

        public void Start(string ID)
        {
            this.Start(this.appLoader.AppManageItems.FirstOrDefault(item => item.Config.ID == ID));
        }

        public StopResult Stop(string ID)
        {
            StopResult stopResult = new StopResult();

            var list = this.Running.Where(item => item.Config.ID == ID).ToList();
            foreach(var item in list)
            {
                var stop = this.Stop(item.PID);
                stopResult.Args.Add(stop);
            }
            return stopResult;
        }

        public AppStopEventArgs Stop(int pid)
        {
            var stop = new AppStopEventArgs();
            var app = this.Running.FirstOrDefault(item => item.PID == pid);
            app.App.OnStop(stop);
            return stop;
        }

        private static int pidIndex = 10000;

        public int NewPID()
        {
            return pidIndex++;
        }
    }
}
