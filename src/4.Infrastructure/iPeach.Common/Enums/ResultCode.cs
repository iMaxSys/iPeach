//----------------------------------------------------------------
//Copyright (C) 2016-2022 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: ResultCode.cs
//摘要: 结果代码枚举集合
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2019-11-16
//----------------------------------------------------------------

using System.ComponentModel;

namespace iPeach.Common.Enums
{
    /// <summary>
    /// 结果代码
    /// </summary>
    public enum ResultCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        Success = 0,
        /// <summary>
        /// 失败
        /// </summary>
        [Description("失败")]
        Fail = 999999,
        /// <summary>
        /// 请求数据为空
        /// </summary>
        [Description("请求数据为空")]
        RequestDataIsEmpty = 100000,
        /// <summary>
        /// 请求Headers中无token
        /// </summary>
        [Description("请求Headers中无token")]
        HasNotToken = 100001,
        /// <summary>
        /// 用户未登录或登录已失效
        /// </summary>
        [Description("用户未登录或登录已失效")]
        UnLogin = 100002,
        /// <summary>
        /// 用户不存在或者密码错误
        /// </summary>
        [Description("用户不存在或者密码错误")]
        UserNotExsits = 100003,
        /// <summary>
        /// 用户被禁用
        /// </summary>
        [Description("用户被禁用")]
        UserIsDisable = 100004,
        /// <summary>
        /// 用户已经过期
        /// </summary>
        [Description("用户已经过期")]
        UserIsExpired = 100005,
    }
}