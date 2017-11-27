using System;
using System.Collections.Generic;
using System.IO;
namespace ZeroRoo.FileSystem
{
    public class DefaultFilesMapping
    {
        private IDictionary<string, string> maps;
        private IRuntimeEnviroment env;

        public DefaultFilesMapping(IRuntimeEnviroment env)
        {
            this.env = env;
            maps = new Dictionary<string, string>();
            maps.Add(SpecialFileNames.Apps.ToString(), GetAbs(SpecialFileNames.Apps));
            maps.Add(SpecialFileNames.Cache.ToString(), GetAbs(SpecialFileNames.Cache));
            maps.Add(SpecialFileNames.Data.ToString(), GetAbs(SpecialFileNames.Data));
            maps.Add(SpecialFileNames.Desktop.ToString(), GetAbs(SpecialFileNames.Desktop));
            maps.Add(SpecialFileNames.Resource.ToString(), GetAbs(SpecialFileNames.Resource));
            maps.Add(SpecialFileNames.Tmp.ToString(), GetAbs(SpecialFileNames.Tmp));

        }

        private string GetAbs(SpecialFileNames name)
        {
            //return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            //env.ApplicationName, name.ToString());
            return Path.Combine(Directory.GetCurrentDirectory(), name.ToString());
        }

        public string Get(string name)
        {
            return maps[name];
        }

        public string Get(SpecialFileNames name)
        {
            return Get(name.ToString());
        }
    }
}
