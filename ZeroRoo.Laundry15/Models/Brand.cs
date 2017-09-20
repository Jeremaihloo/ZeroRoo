using System;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 品牌
    /// </summary>

    public class Brand
    {
        /// <summary>
        /// ID
        /// </summary>
        [Description("编号")]
        public int ID { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [Description("品牌名称")]

        public string Text { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        [Description("显示顺序")]
        public int ViewIndex { get; set; }

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
