
using System.Text.Json;
using System.Threading.Tasks;

using iMaxSys.Max.Security.Cryptography;

using iPeach.Sns.Base.Api;
using iPeach.Sns.Base.Domain.Auth;
using iPeach.Sns.Base.Domain.Open;
using iPeach.Sns.WeChat.Api;
using iPeach.Sns.WeChat.Api.Request;
using iPeach.Sns.WeChat.Api.Response;
using iPeach.Sns.WeChat.Domain;
using iPeach.Sns.WeChat.Domain.Open;

namespace iMaxSys.SDK.SNS.WeChat.Services
{
    /// <summary>
    /// 微信授权服务
    /// </summary>
    public class WeChatService : IWeChatService
    {
        /// <summary>
        /// 获取访问配置
        /// </summary>
        /// <param name="snsAuth"></param>
        /// <returns></returns>
        public async Task<AccessConfig> GetAccessConfigAsync(SnsAuth snsAuth)
        {
            AuthRequest authRequest = new AuthRequest
            {
                AppId = snsAuth.AppId,
                AppSecret = snsAuth.AppSecret,
                Code = snsAuth.Code,
                Method = "GET"
            };  
            AuthResponse response = await WeChatClient.ExecuteAsync<AuthResponse>(authRequest, WeChatResultCode.GetAccessConfigFail);
            return new AccessConfig
            {
                AppId = authRequest.AppId,
                AppSecret = authRequest.AppSecret,
                ExtId = response.OpenId,
                UnionId = response.UnionId,
                SessionKey = response.SessionKey
            };
        }

        /// <summary>
        /// 获取电话号码
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public SnsPhoneNumber GetPhoneNumber(string data, string key, string iv)
        {
            string json = AES.Decrypt(data, key, iv);
            return JsonSerializer.Deserialize<WeChatPhoneNumber>(json);
        }
    }
}
