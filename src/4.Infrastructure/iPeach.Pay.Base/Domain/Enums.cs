
using System.ComponentModel;

namespace iPeach.Pay.Base.Domain
{
    /// <summary>
    /// 支付类型
    /// </summary>
    public enum PayType
    {
        /// <summary>
        /// 微信支付
        /// </summary>
        [Description("微信支付")]
        WeChatPay = 100,

        /// <summary>
        /// 支付宝支付
        /// </summary>
        [Description("支付宝支付")]
        AliPay = 200,

        /// <summary>
        /// 银联支付
        /// </summary>
        [Description("银联支付")]
        UnionPay = 300
    }

    /// <summary>
    /// 支付模式
    /// </summary>
    public enum PayMode
    {
        /// <summary>
        /// 刷卡/直接支付
        /// </summary>
        [Description("刷卡/直接支付")]
        Direct = 0,

        /// <summary>
        /// 扫码支付
        /// </summary>
        [Description("扫码支付")]
        Scan = 1,

        /// <summary>
        /// App支付
        /// </summary>
        [Description("App支付")]
        App = 2,

        /// <summary>
        /// 公众平台支付
        /// </summary>
        [Description("公众平台支付")]
        Mp = 3,

        /// <summary>
        /// H5支付
        /// </summary>
        [Description("H5支付")]
        H5 = 4,

        /// <summary>
        /// 小程序支付
        /// </summary>
        [Description("小程序支付")]
        Lite = 5
    }

    /// <summary>
    /// 支付状态
    /// </summary>
    public enum PayStatus
    {
        /// <summary>
        /// 未支付
        /// </summary>
        [Description("未支付")]
        Start = 0,

        /// <summary>
        /// 已支付
        /// </summary>
        [Description("已支付")]
        Paid = 1,

        /// <summary>
        /// 退款中
        /// </summary>
        [Description("退款中")]
        Apply = 2,

        /// <summary>
        /// 已退款
        /// </summary>
        [Description("已退款")]
        Refund = 3,

        /// <summary>
        /// 已失效
        /// </summary>
        [Description("已失效")]
        Invalid = 4
    }
}
