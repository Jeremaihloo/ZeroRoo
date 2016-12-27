using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Laundry.Configuration.Models
{
    public enum RunMode
    {
        Debug = 0,
        Production = 1
    }

    public class GlobalConfig
    {
        public GlobalConfig()
        {
            this.DbName = "db.db";
            this.DataDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            this.DataDirectory = Directory.GetCurrentDirectory();
            this.RunMode = RunMode.Debug;
        }
        
        public RunMode RunMode { get; set; }
        
        public string DataDirectory { get; set; }

        public string DbName { get; set; }

        public string DbFullPath
        {
            get { return Path.Combine(this.DataDirectory, this.DbName); }
        }
    }
}
