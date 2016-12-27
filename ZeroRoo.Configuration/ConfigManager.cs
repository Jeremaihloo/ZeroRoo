using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ZeroRoo.Configuration
{
    public class ConfigManager
    {
        private static ConfigManager defaultConfigManager;
        public static ConfigManager Default
        {
            get {
                if (defaultConfigManager==null)
                {
                    defaultConfigManager = new ConfigManager();
                }
                return defaultConfigManager;
            }
        }

        public ConfigManager()
        {

        }

        public virtual T Config<T>(string name = "")
        {
            try
            {
                var json = GetConfigContent<T>(name);
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch
            {
                var o = Activator.CreateInstance<T>();
                Save<T>(o, name);
                return o;
            }
        }

        private string _WorkSpace = "";
        public virtual string WorkSpace
        {
            get
            {
                return string.IsNullOrEmpty(_WorkSpace) ? "Configs" : _WorkSpace;
            }
            set
            {
                _WorkSpace = value;
            }
        }

        public virtual void Save<T>(T entity, string name = "")
        {
            File.WriteAllText(GetConfigFilePath<T>(name), JsonConvert.SerializeObject(entity, Formatting.Indented), Encoding.Default);
        }

        public virtual string GetConfigContent<T>(string name = "")
        {
            return File.ReadAllText(GetConfigFilePath<T>(name), Encoding.Default);
        }

        public virtual string GetConfigFilePath<T>(string name = "")
        {
            if(!Directory.Exists(this.WorkSpace))
            {
                Directory.CreateDirectory(this.WorkSpace);
            }
            var path = Path.Combine(this.WorkSpace, name + (string.IsNullOrEmpty(name) ? "" : ".") + typeof(T).Name + ".json");
            return path;
        }


    }
}
