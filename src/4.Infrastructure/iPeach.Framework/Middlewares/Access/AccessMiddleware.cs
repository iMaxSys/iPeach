

//----------------------------------------------------------------
//Copyright (C) 2016-2022 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: AccessOptions.cs
//摘要: 访问控制中间件
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2019-11-16
//----------------------------------------------------------------

using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.DependencyInjection;

using iMaxSys.Max.Identity;
using iMaxSys.Max.Exceptions;
using iMaxSys.Max.Environment;
using iMaxSys.Max.Identity.Domain;

using iPeach.Common.Enums;

namespace iPeach.Framework.Middlewares.Access
{
    /// <summary>
    /// 访问选项
    /// </summary>
    public class AccessOptions
    {
        /// <summary>
        /// 公开的Action列表
        /// </summary>
        public string[] OpenActions { get; set; }

        /// <summary>
        /// 限制的Action列表
        /// </summary>
        public string[] LimitActions { get; set; }
    }

    /*
        在中间件中注入组件有三种不同的方式：
        1.构造函数 所有请求都需要的单例(Singleton)组件
        2.Invoke方法参数 在请求中总是必须的作用域(Scoped)和瞬时(Transient)组件
        3.HttpContext.RequestServices 基于运行时信息可能需要或可能不需要的组件
    */

    /// <summary>
    /// 访问控制中间件
    /// </summary>
    public class AccessMiddleware
    {
        const string FLAG_TOKEN = "Token";

        private readonly RequestDelegate _next;
        private readonly AccessOptions _accessOptions;

        public AccessMiddleware(RequestDelegate next, AccessOptions accessOptions = null)
        {
            _next = next;
            _accessOptions = accessOptions;
        }

        public async Task Invoke(HttpContext context)
        {
            await Access(context, _accessOptions);
            await _next(context);
        }

        /// <summary>
        /// 访问控制
        /// </summary>
        /// <param name="context"></param>
        /// <param name="_accessOptions"></param>
        /// <returns></returns>
        public async Task Access(HttpContext context, AccessOptions _accessOptions)
        {
            bool needCheck = true;

            IWorkContext workContext = context.RequestServices.GetService<IWorkContext>();

            //API Path/Action访问限制检查
            needCheck = _accessOptions.LimitActions.FirstOrDefault(s => context.Request.Path.Value.ToLower().Contains(s)) != null;

            if (needCheck && !context.Request.Headers.ContainsKey(FLAG_TOKEN))
            {
                //Headers中无token
                throw new MaxException(ResultCode.HasNotToken);
            }

            if (context.Request.Headers.TryGetValue(FLAG_TOKEN, out StringValues values))
            {
                IIdentityService identityService = context.RequestServices.GetService<IIdentityService>();
                AccessChain accessChain = await identityService.GetAsync(values[0].ToString());
                if (needCheck && (accessChain == null || (accessChain.AccessSession.ForceCheck && (accessChain.User == null || !accessChain.User.IsLogin || accessChain.AccessSession.Expires < DateTime.Now || accessChain.User.Expires < DateTime.Now || accessChain.User.Status == 0))))
                    throw new MaxException(ResultCode.UnLogin);

                workContext.AccessChain = accessChain;
                workContext.Session.Id = accessChain?.AccessSession?.Token;
            }
        }
    }
}