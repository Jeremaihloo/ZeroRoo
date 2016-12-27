using System;

namespace Laundry.LibCore.Models
{
    /// <summary>
    /// 品牌
    /// </summary>

    public class Brand
    {
        /// <summary>
        /// ID
        /// </summary>

        public int ID { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>

        public string Text { get; set; }

        /// <summary>
        /// 显示顺序
        /// </summary>
        public int ViewIndex { get; set; }

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
