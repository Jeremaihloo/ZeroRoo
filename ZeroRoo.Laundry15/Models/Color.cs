
using System;

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
        public int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateAt { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateAt { get; set; }
    }
}
