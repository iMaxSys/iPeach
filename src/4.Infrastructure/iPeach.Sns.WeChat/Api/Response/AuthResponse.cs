
namespace iPeach.Sns.WeChat.Api.Response
{
    public class AuthResponse
    {
        /// <summary>
        /// SessionKey
        /// </summary>
        /// [JsonProperty(PropertyName = "session_key")]
        public string SessionKey { get; set; }

        /// <summary>
        /// OpenId
        /// </summary>
        public string OpenId { get; set; }

        /// <summary>
        /// UnionId
        /// </summary>
        public string UnionId { get; set; }
    }
}
