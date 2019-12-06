
using System.ComponentModel;

namespace iPeach.Sns.WeChat.Domain
{
    /// <summary>
    /// 微信结果代码
    /// </summary>
    public enum WeChatResultCode
    {
        /// <summary>
        /// 获取微信访问配置异常
        /// </summary>
        [Description("获取微信访问配置异常")]
        GetAccessConfigFail = 3000000,
    }
}
