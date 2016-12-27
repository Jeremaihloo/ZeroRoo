using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Configuration;
using System.Reflection;
using System.Diagnostics;
using System.Drawing;

namespace ZeroRoo.App
{
    public class AppLoader
    {
        public bool HasLoad = false;


        public List<AppManageItem> AppManageItems { get; set; }


        public AppLoader()
        {
            this.AppManageItems = new List<AppManageItem>();
        }

        public List<AppConfig> CollectAppConfigs()
        {
            var list = new List<AppConfig>();
            var configFiles = Directory.GetFileSystemEntries(ConfigManager.Default.WorkSpace, "*.AppConfig.json");
            
            foreach(var item in configFiles)
            {
                FileInfo info = new FileInfo(item);
                var arr = info.Name.Split('.');
                var name = string.Join(".", arr.Take(arr.Length - 2));
                list.Add(ConfigManager.Default.Config<AppConfig>(name));
            }
            return list;
        }

        public void LoadApps()
        {

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            var appConfigs = this.CollectAppConfigs();
            foreach (var item in appConfigs)
            {
                var dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Apps", item.ID, item.Target);
                var assembly = Assembly.LoadFile(dllPath);

                var types = assembly.GetTypes();
                var tmpAppList = new List<Type>();
                foreach (var t in types)
                {
                    if (typeof(IApp).IsAssignableFrom(t))
                    {
                        tmpAppList.Add(t);
                    }
                }
                var config = tmpAppList.FirstOrDefault(c => c.FullName.IndexOf(item.ID) == 0);
                if (config == null)
                {
                    throw new EntryPointNotFoundException(item.ID);
                }

                var mItem = this.CreateAppManageItem(config, item);
                this.AppManageItems.Add(mItem);
            }

             this.HasLoad = true;
        }

        private AppManageItem CreateAppManageItem(Type type, AppConfig config)
        {
            IApp app;
            Image icon;
            AppManageItem mItem;
            switch (config.Type)
            {
                case AppType.WindowApp:
                case AppType.Service:
                    app = (IApp)Activator.CreateInstance(type);
                    break;
                case AppType.Traditional:
                    app = new TraditionalApp();
                    break;
                default:
                    throw new Exception("Unknow App Type");
            }
            var iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Apps", config.ID, config.Icon);
            if (!File.Exists(iconPath))
                iconPath = "default_icon.png";
            icon = Image.FromFile(iconPath);
            mItem = new AppManageItem() { Config = config, App = app, Icon = icon };
            return mItem;
        }

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Debug.WriteLine(string.Format("FromAssembly: {0} Dependency: {1}", args.RequestingAssembly.FullName, args.Name));
            AssemblyName assemblyName = new AssemblyName(args.Name);
            var files = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Apps"), assemblyName.Name + ".dll", SearchOption.AllDirectories);
            if (files == null || files.Length == 0)
            {
                throw new FileNotFoundException("dll not found");
            }
            FileInfo info = new FileInfo(files[0]);
            
            return Assembly.LoadFrom(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Apps", info.FullName));
        }

        public void Load()
        {
            this.LoadApps();
        }
        
        public Dictionary<string, string> CheckConfigChange(AppConfig oldConfig, AppConfig currentConfig)
        {
            var dic = new Dictionary<string, string>();
            var properties = typeof(AppConfig).GetProperties();
            foreach (var item in properties)
            {
                var oldValue = item.GetValue(oldConfig);
                var currentValue = item.GetValue(currentConfig);

                if (oldValue != currentValue)
                {
                    var att = item.GetCustomAttribute<ConfigPropertyAttribute>();
                    dic[att.Title] = dic[att.Description];
                }
            }
            return dic;
        }
    }
}
