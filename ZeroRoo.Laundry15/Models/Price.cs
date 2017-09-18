using System;

namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 价格表
    /// </summary>
    public class Price
    {
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 价格字符串，可能是一个区间 eg.19-20
        /// </summary>
        public string PriceString { get; set; }

        /// <summary>
        /// 是否参与折扣
        /// </summary>
        public bool CanDiscount { get; set; }

        /// <summary>
        /// 当前是否打折
        /// </summary>
        public bool IsDiscount { get; set; }

        /// <summary>
        /// 当前折扣
        /// </summary>
        public decimal NowDiscount { get; set; }

        public int CategoryID { get; set; }
        /// <summary>
        /// 衣服分类
        /// </summary>
        public ClotheCategory Category { get; set; }

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
