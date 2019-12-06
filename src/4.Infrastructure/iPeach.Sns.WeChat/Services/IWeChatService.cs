
using iMaxSys.Max.DependencyInjection;
using iMaxSys.SDK.SNS.Base.Services;

namespace iMaxSys.SDK.SNS.WeChat.Services
{
    /// <summary>
    /// 微信授权服务
    /// </summary>
    public interface IWeChatService : IDependency, ISnsService
    {
    }
}
