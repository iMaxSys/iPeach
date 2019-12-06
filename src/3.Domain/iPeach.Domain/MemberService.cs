
using System;
using System.Threading.Tasks;

using AutoMapper;

using iMaxSys.Max.Identity;
using iMaxSys.Max.Identity.Domain;

using iPeach.Domain.Core;
using iPeach.Domain.Models;
using iPeach.Common.Options;
using iPeach.Framework.UnitOfWork;

namespace iPeach.Domain
{
    public class MemberService : XService, IMemberService
    {
        //第三方账号登录过期时间间隔(分钟)-10天
        const int EXPIRS = 14400;

        private readonly IMapper _mapper;
        private readonly LifeTreeOption _maxOption;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IIdentityService _identityService;
        private readonly ISnsService _snsService;


        public MemberService()
        {
        }

        public void BindThirdAccount()
        {
            throw new NotImplementedException();
        }

        public void ChangePassword()
        {
            throw new NotImplementedException();
        }

        public Task GetAccessConfigAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<Member> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<AccessChain> LoginAsync(long sid, string code)
        {
            throw new NotImplementedException();
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public Task RegisterAsync(MemberRegister memberRegister)
        {
            throw new NotImplementedException();
        }

        public void UnbindThirdAccount()
        {
            throw new NotImplementedException();
        }
    }
}
