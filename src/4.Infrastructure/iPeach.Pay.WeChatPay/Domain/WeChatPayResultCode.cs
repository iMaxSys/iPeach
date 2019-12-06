
using System.ComponentModel;

namespace iPeach.Pay.WeChatPay.Domain
{
    /// <summary>
    /// 微信支付结果代码
    /// </summary>
    public enum WeChatPayResultCode
    {
        /// <summary>
        /// 微信支付接口提交返回异常
        /// </summary>
        [Description("接口提交返回异常")]
        ReturnError = 300000,
        /// <summary>
        /// 微信支付接口返回结果无签名或签名为空
        /// </summary>
        [Description("微信支付接口返回结果无签名或签名为空")]
        NoSignOrEmpty = 300001,
        /// <summary>
        /// 数据包中不包含签名类型
        /// </summary>
        [Description("数据包中不包含签名类型")]
        SignTypeNotExists = 300002,
        /// <summary>
        /// 微信支付接口返回数据验签失败
        /// </summary>
        [Description("微信支付接口返回数据验签失败")]
        CheckSignFail = 300003,
        /// <summary>
        /// 微信支付下单失败
        /// </summary>
        [Description("微信支付下单失败")]
        OrderFail = 3000034
    }
}
