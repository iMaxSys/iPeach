
using System;

using iPeach.Framework.Web;

namespace iPeach.Api.ViewModels.Member
{
    /// <summary>
    /// 微信登录应答
    /// </summary>
    public class WeChatLiteLoginResponse : Response
    {
        /// <summary>
        /// 令牌
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        public string Expires { get; set; }
    }
}
