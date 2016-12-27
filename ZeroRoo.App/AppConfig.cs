using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.App
{
    public enum AppMode
    {
        Single = 0,
        Multi = 1
    }

    public enum AppType
    {
        /// <summary>
        /// 窗口类型的App
        /// </summary>
        WindowApp = 0,
        /// <summary>
        /// 后端服务
        /// </summary>
        Service = 1,
        /// <summary>
        /// 传统Windows应用程序
        /// </summary>
        Traditional = 2,
        /// <summary>
        /// 程序包
        /// </summary>
        Library = 3
    }

    public enum StartWay
    {
        Normal = 0,
        Auto = 1
    }

    public class AppConfig
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Version { get; set; }

        public string[] Dependency { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool Enable { get; set; }

        public bool Visible { get; set; }

        public string Icon { get; set; }

        public string Target { get; set; }

        public StartWay StartWay { get; set; }

        public AppMode Mode { get; set; }

        public AppType Type { get; set; }
    }
}
