using System;
using System.Collections.Generic;
using System.Reflection;

namespace ZeroRoo.Apps.Abstractions.Loaders
{
    public class AppEntry
    {
        public IAppInfo ExtensionInfo { get; set; }
        public Assembly Assembly { get; set; }
        public IEnumerable<Type> ExportedTypes { get; set; }
        public bool IsError { get; set; }
    }
}