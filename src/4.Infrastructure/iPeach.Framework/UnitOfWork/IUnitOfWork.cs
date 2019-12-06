//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: IUnitOfWork.cs
//摘要: IUnitOfWork 
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2018-03-07
//----------------------------------------------------------------

using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace iPeach.Framework.UnitOfWork
{
    /// <summary>
    /// IUnitOfWork
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// 提交
        /// </summary>
        /// <returns></returns>
        Task<int> SaveChangesAsync();

        /// <summary>
        /// 新增
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="entity"></param>
        Task AddAsync<TEntity>(TEntity entity) where TEntity : class;

        /// <summary>
        /// 获取仓储
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        DbSet<TEntity> GetRepository<TEntity>() where TEntity : class;
    }
}
