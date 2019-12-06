using System;

using iPeach.Framework.Web;

namespace iPeach.Api.ViewModels.Member
{
    /// <summary>
    /// 微信小程序登录请求
    /// </summary>
    public class WeChatLiteLoginRequest : Request
    {
        /// <summary>
        /// Sid
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Code
        /// </summary>
        public string Code { get; set; }
    }
}
