
namespace iPeach.Sns.WeChat.Api.Request
{
    /// <summary>
    /// 获取授权请求
    /// </summary>
    public class AuthRequest : WeChatRequest
    {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// AppSecret
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Action
        /// </summary>
        public override string Action => $"/sns/jscode2session?appid={AppId}&secret={AppSecret}&js_code={Code}&grant_type=authorization_code";
    }
}
