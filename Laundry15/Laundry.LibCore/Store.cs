using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace Laundry.LibCore
{
    public class Store
    {
        public Store()
        {
            this.Name = "美国UCC国际洗衣";
            this.Phone = "13761561263";
            this.Address = "上海市闵行区金平路19号";
        }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
    }
}
