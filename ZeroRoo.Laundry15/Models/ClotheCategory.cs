using System;
using System.Collections.Generic;
using System.ComponentModel;
using ZeroRoo.Laundry15.Models;

namespace ZeroRoo.Laundry15.Models
{
    public class ClotheCategory
    {
        [Description("编号")]
        public int ID { get; set; }

        [Description("内容")]
        public string Text { get; set; }

        [Description("衣服")]
        public IList<Price> ClotheInfos { get; set; }

        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        [Description("修改时间")]
        public DateTime UpdateAt { get; set; }
    }
}