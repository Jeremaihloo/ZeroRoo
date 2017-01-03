using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroRoo.Configuration;

namespace ZeroRoo.App
{
    public class AppConfigManager: ConfigManager
    {
        /// <summary>
        /// 所有的配置文件都要放入池子里，统一进行管理
        /// </summary>
        private Dictionary<string, object> configsPool;

        public virtual AppConfig AppConfig(string name)
        {
            return this.Config<AppConfig>(name + ".App");
        }

        public virtual T AppPrivateConfig<T>(T config, string appName)
        {
            return this.Config<T>(typeof(T).Name + "." + appName + ".App");
        }

        private AppSystemConfigs appSystemConfigs = null;
        public AppSystemConfigs AppSystemConfigs()
        {
            if (appSystemConfigs == null)
                return this.Config<AppSystemConfigs>();
            return appSystemConfigs;
        }
    }
}
