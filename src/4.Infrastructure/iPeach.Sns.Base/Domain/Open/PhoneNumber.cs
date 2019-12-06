//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: PhoneNumber.cs
//摘要: 电话号码基类
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2019-05-26
//----------------------------------------------------------------

using System;
using System.Text;
using System.Collections.Generic;

namespace iPeach.Sns.Base.Domain.Open
{
    public class SnsPhoneNumber
    {
        public string PhoneNumber { get; set; }

        public string PurePhoneNumber { get; set; }

        public string CountryCode { get; set; }
    }
}
