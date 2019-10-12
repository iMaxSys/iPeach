//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: Member.cs
//摘要: 会员领域模型类
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2019-10-12
//----------------------------------------------------------------

using System;

namespace iPeach.Domain.Models
{
    /// <summary>
    /// 会员
    /// </summary>
    public class Member
    {
        /// <summary>
        /// 标识
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 扩展标识(OpenId等)
        /// </summary>
        public string ExtId { get; set; }

        /// <summary>
        /// 构造
        /// 不允许调用默认构造
        /// </summary>
        protected Member()
        {
        }

        /// <summary>
        /// 构造
        /// </summary>
        /// <param name="id">标识</param>
        /// <param name="name">名称</param>
        /// <param name="mobile">手机号码</param>
        /// <param name="extId">扩展标识(OpenId等)</param>
        public Member(long id, string name, string mobile, string extId)
        {
            Id = id;
            Name = name;
            Mobile = mobile;
            ExtId = extId;
        }
    }
}
