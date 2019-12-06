
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

using iMaxSys.Max.Domain;

using iPeach.Common.Enums;
using iPeach.Common.Options;
using iPeach.Framework.Web.Mvc;
using iPeach.Api.ViewModels.Member;

namespace iPeach.Api.Client.Controllers
{
    /// <summary>
    /// IndexController Class
    /// </summary>
    [Route("api/[controller]")]
    public class MemberController : XController
    {
        private readonly LifeTreeOption _lifeTreeOption;

        public MemberController(IOptions<LifeTreeOption> lifeTreeOption)
        {
            _lifeTreeOption = lifeTreeOption.Value;
        }

        [HttpGet]
        public Result Get()
        {
            //string x = $"it's time: {DateTime.Now}";
            //return _lifeTreeOption.Databases.Core.ConnectionString;
            return Result(ResultCode.UnLogin, "扩展信息");

        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="request">请求</param>
        /// <returns></returns>
        //[HttpPost]
        //public async Task<Result> Login([FromBody]WeChatLiteLoginRequest request)
        //{
        //    var a = await _memberService.LoginAsync(request.Id, request.Code);
        //    return Success(new WeChatLiteLoginResponse
        //    {
        //        Token = a.AccessSession.Token,
        //        Expires = a.AccessSession.Expires.ToLongTimestamp().ToString()
        //    });
        //}
    }
}

