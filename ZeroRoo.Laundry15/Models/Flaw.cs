using System;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 衣服瑕疵
    /// </summary>

    public class Flaw
    {
        [Description("编号")]
        public int ID { get; set; }

        [Description("内容")]
        public string Text { get; set; }

        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        [Description("更新时间")]
        public DateTime UpdateAt { get; set; }
    }
}
