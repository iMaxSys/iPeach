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

using System;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace iPeach.Framework.UnitOfWork
{
    /// <summary>
    /// UnitOfWork
    /// </summary>
    /// <typeparam name="T">DbContext</typeparam>
    public class UnitOfWork<T> : IUnitOfWork where T : DbContext
    {
        private readonly T _context;

        public UnitOfWork(T context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddAsync<TEntity>(TEntity entity) where TEntity : class
        {
            await _context.AddAsync<TEntity>(entity);
        }

        public DbSet<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return _context.Set<TEntity>();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
