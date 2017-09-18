namespace ZeroRoo.Laundry15.Models
{
    /// <summary>
    /// 消费类型
    /// </summary>
    public enum FeeType
    {
        Empty = -1, 
        /// <summary>
        /// 洗衣服
        /// </summary>
        LuandryTicket = 0,
        /// <summary>
        /// 充值
        /// </summary>
        Recharge = 1,
        /// <summary>
        /// 办会员
        /// </summary>
        CreateVip = 3,
        /// <summary>
        /// 其他
        /// </summary>
        Other = 4
    }
}
