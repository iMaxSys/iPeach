
using System;
using System.Threading.Tasks;

using iMaxSys.Max.Identity.Domain;
using iMaxSys.Max.DependencyInjection;

using iPeach.Domain.Models;

namespace iPeach.Domain
{
    /// <summary>
    /// 会员服务接口
    /// </summary>
    public interface IMemberService : IDependency
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="memberRegister">注册信息</param>
        /// <returns></returns>
        Task RegisterAsync(MemberRegister memberRegister);

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sid">sid</param>
        /// <param name="code">code</param>
        /// <returns></returns>
        Task<AccessChain> LoginAsync(long sid, string code);

        /// <summary>
        /// 登出
        /// </summary>
        void Logout();

        /// <summary>
        /// 修改密码
        /// </summary>
        void ChangePassword();

        /// <summary>
        /// 绑定第三方平台账号
        /// </summary>
        void BindThirdAccount();

        /// <summary>
        /// 解绑第三方平台账号
        /// </summary>
        void UnbindThirdAccount();

        /// <summary>
        /// 获取访问配置
        /// </summary>
        /// <param name="id">CompanyAppId</param>
        Task GetAccessConfigAsync(long id);

        /// <summary>
        /// 获取会员信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Member> GetAsync(long id);
    }
}
