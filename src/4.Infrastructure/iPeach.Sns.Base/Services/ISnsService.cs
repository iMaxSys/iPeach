using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using iPeach.Sns.Base.Api;
using iPeach.Sns.Base.Api.Reqeust;
using iPeach.Sns.Base.Domain.Auth;
using iPeach.Sns.Base.Domain.Open;

namespace iMaxSys.SDK.SNS.Base.Services
{
    /// <summary>
    /// 授权服务
    /// </summary>
    public interface ISnsService
    {
        /// <summary>
        /// 获取访问配额
        /// </summary>
        /// <param name="snsAuth"></param>
        /// <returns></returns>
        Task<AccessConfig> GetAccessConfigAsync(SnsAuth snsAuth);

        /// <summary>
        /// 获取电话号码
        /// </summary>
        /// <param name="data"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        SnsPhoneNumber GetPhoneNumber(string data, string key, string iv);
    }
}
