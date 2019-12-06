
using System.ComponentModel;


namespace iMaxSys.SDK.SNS.Base.Domain
{
    /// <summary>
    /// 平台
    /// </summary>
    public enum Platform
    {
        /// <summary>
        /// 微信小程序
        /// </summary>
        [Description("微信小程序")]
        WeChatLite = 1000,

        /// <summary>
        /// 支付宝小程序
        /// </summary>
        [Description("支付宝小程序")]
        AliPayLite = 1000
    }
}
