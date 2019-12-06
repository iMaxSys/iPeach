

using iPeach.Sns.Base.Api.Reqeust;

namespace iPeach.Sns.WeChat.Api.Request
{
    /// <summary>
    /// 微信请求
    /// </summary>
    public abstract class WeChatRequest : SnsRequest
    {
        protected const string BASEAPIURL = "https://api.weixin.qq.com";

        /// <summary>
        /// 方法(默认POST)
        /// </summary>
        public string Method { get; set; } = "POST";

        /// <summary>
        /// API接口名称
        /// </summary>
        public abstract string Action { get; }

        //接口Url
        public string Url { get { return $"{BASEAPIURL}{Action}"; } }
    }
}
