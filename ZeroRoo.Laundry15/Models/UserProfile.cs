
using System;
using System.ComponentModel;

namespace ZeroRoo.Laundry15.Models
{

    public class UserProfile
    {
        [Description("编号")]
        public int ID { get; set; }

        [Description("角色")]
        public UserRole Role { get; set; }

        [Description("Vip编号")]
        public string VipID { get; set; }

        [Description("姓名")]
        public string Name { get; set; }

        [Description("地址")]
        public string Address { get; set; }

        [Description("性别")]
        public string Sex { get; set; }

        [Description("电话")]
        public string Phone { get; set; }

        [Description("余额")]
        public decimal Balance { get; set; }

        [Description("创建时间")]
        public DateTime CreateAt { get; set; }

        [Description("修改时间")]
        public DateTime UpdateAt { get; set; }

        /// <summary>
        /// 累计消费
        /// </summary>
        [Description("累计消费")]
        public decimal FeeSum { get; set; }

        /// <summary>
        /// 衣单数量
        /// </summary>
        [Description("衣单数量")]
        public int TicketCount { get; set; }

        /// <summary>
        /// 衣服数量
        /// </summary>
        [Description("衣服数量")]
        public int ClotheCount { get; set; }
    }
}
