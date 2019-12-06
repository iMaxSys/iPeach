//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: UnitOfWork.cs
//摘要: UnitOfWork 
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2018-03-07
//----------------------------------------------------------------

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace iPeach.Framework.UnitOfWork
{
    public static class UnitOfWorkExtensions
    {
        /// <summary>
        /// AddUnitOfWork
        /// </summary>
        /// <typeparam name="T">DbContext</typeparam>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddUnitOfWork<T>(this IServiceCollection services) where T : DbContext
        {
            services.AddScoped<IUnitOfWork, UnitOfWork<T>>();
            return services;
        }
    }
}
