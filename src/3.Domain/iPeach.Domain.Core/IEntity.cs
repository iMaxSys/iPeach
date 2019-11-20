//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: IEntity.cs
//摘要: 实体接口
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2019-10-12
//----------------------------------------------------------------

using System;

namespace iPeach.Domain.Core
{
    public interface IEntity
    {
        /// <summary>
        /// 标识
        /// </summary>
        long Id { get; set; }
    }
}
