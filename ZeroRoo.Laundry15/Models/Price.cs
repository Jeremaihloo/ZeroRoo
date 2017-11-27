using System;
using System.ComponentModel;

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
        [Description("编号")]
        public int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Description("名称")]
        public string Name { get; set; }

        /// <summary>
        /// 价格字符串，可能是一个区间 eg.19-20
        /// </summary>
        [Description("价格")]
        public string PriceString { get; set; }

        /// <summary>
        /// 是否参与折扣
        /// </summary>
        [Description("是否参与打折")]
        public bool CanDiscount { get; set; }

        /// <summary>
        /// 当前是否打折
        /// </summary>
        [Description("当前是否打折")]
        public bool IsDiscount { get; set; }

        /// <summary>
        /// 当前折扣
        /// </summary>
        [Description("当前折扣")]
        public decimal NowDiscount { get; set; }

        public int CategoryID { get; set; }
        /// <summary>
        /// 衣服分类
        /// </summary>
        public ClotheCategory Category { get; set; }

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
