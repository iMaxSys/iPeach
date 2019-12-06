//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: Signature.cs
//摘要: 微信支付签名工具类
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2018-03-07
//----------------------------------------------------------------

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

using iMaxSys.Max.Exceptions;
using iMaxSys.Max.Security.Cryptography;

using iPeach.Pay.WeChatPay.Domain;

namespace iPeach.Pay.WeChatPay.Utilities
{
    /// <summary>
    /// 微信支付签名工具类
    /// </summary>
    public static class Signature
    {
        const string TAG_SIGN = "sign";
        const string TAG_SIGN_TYPE = "sign_type";

        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static string Sign(Dictionary<string, string> dict, string key, string signType)
        {
            string sign = string.Empty;

            //排除空值和sign
            StringBuilder source = new StringBuilder();
            source.AppendJoin("&", dict.Where(x => !string.IsNullOrWhiteSpace(x.Value) && x.Key != TAG_SIGN).OrderBy(x => x.Key).Select(x => $"{x.Key}={x.Value}"));
            source.Append($"&key={key}");

            switch (signType)
            {
                //case "HMAC-SHA256":
                //    break;
                case "MD5":
                default:
                    sign = Md5.Hash(source.ToString()).ToUpper();
                    break;
            }

            return sign;
        }

        /// <summary>
        /// 验签
        /// </summary>
        /// <param name="dict"></param>
        /// <param name="key"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static bool Verify(Dictionary<string, string> dict, string key, string signType)
        {
            //检查签名字段
            //string sign = dict[TAG_SIGN];
            //if (!dict.ContainsKey(TAG_SIGN) || string.IsNullOrWhiteSpace(dict[TAG_SIGN]))
            //{
            //    throw new MaxException(WeChatPayResultCode.NoSignOrEmpty);
            //}

            //未包含签名则为通过,返回字段数大于2才会有签名
            if (dict.Count < 3 && !dict.ContainsKey(TAG_SIGN))
                return true;

            //验签
            if (dict[TAG_SIGN] != Sign(dict, key, signType))
            {
                throw new MaxException(WeChatPayResultCode.CheckSignFail);
            }

            return true;
        }
    }
}
