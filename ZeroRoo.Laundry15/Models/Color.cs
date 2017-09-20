
using System;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 颜色
    /// </summary>

    public class Color
    {
        /// <summary>
        /// ID
        /// </summary>
        [Description("编号")]
        public int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Description("内容")]
        public string Text { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [Description("修改时间")]
        public DateTime UpdateAt { get; set; }
    }
}
