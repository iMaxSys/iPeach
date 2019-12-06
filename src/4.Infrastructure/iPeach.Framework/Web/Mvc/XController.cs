//----------------------------------------------------------------
//Copyright (C) 2016-2022 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: ControllerBase.cs
//摘要: 控制器基类
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2017-11-16
//----------------------------------------------------------------

using System.IO;
using System.Net;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;

using iMaxSys.Max.Domain;
using iMaxSys.Max.Web.Mvc;
using iMaxSys.Max.Extentions;
using iMaxSys.Max.Exceptions;

using iPeach.Common.Enums;

namespace iPeach.Framework.Web.Mvc
{
    /// <summary>
    /// 控制器基类
    /// </summary>
    public class XController : MaxController
    {
        protected Result Result(ResultCode resultCode, object data)
        {

            if (resultCode == ResultCode.Success)
            {
                return Success(data);
            }
            else
            {
                return Fail(data);
            }
        }
    }
}