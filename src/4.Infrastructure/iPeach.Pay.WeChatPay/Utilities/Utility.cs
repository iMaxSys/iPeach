using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Text.Json;

using iMaxSys.Max.Exceptions;

using iPeach.Pay.Base;
using iPeach.Pay.Base.Domain;
using iPeach.Pay.WeChatPay.Domain;
using iPeach.Pay.WeChatPay.Api.Request;

namespace iPeach.Pay.WeChatPay.Utilities
{
    /// <summary>
    /// 微信支付工具类
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// 交易类型转义字典
        /// </summary>
        static readonly Dictionary<PayMode, string> _tradeType;

        static Utility()
        {
            _tradeType = new Dictionary<PayMode, string>
            {
                {PayMode.Direct, "MICROPAY"},
                {PayMode.Scan, "NATIVE"},
                {PayMode.App, "APP"},
                {PayMode.Mp, "JSAPI"},
                {PayMode.H5, "MWEB"},
                {PayMode.Lite, "JSAPI"}
            };
        }

        /// <summary>
        /// 获取交易类型字符串
        /// </summary>
        /// <param name="mode">支付模式</param>
        /// <returns></returns>
        public static string GetTradeType(PayMode mode)
        {
            return _tradeType[mode];
        }

        /// <summary>
        /// 生成Xml请求
        /// </summary>
        /// <param name="app"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string Build(App app, WeChatPayRequest request)
        {
            //构建请求参数
            request.Build();

            //构建公共参数
            request.Params.Add("appid", app.AppId);
            request.Params.Add("mch_id", app.MchId);
            request.Params.Add("nonce_str", Guid.NewGuid().ToString().Replace("-", ""));
            request.Params.Add("sign_type", app.SignType);
            request.Params.Add("sign", Signature.Sign(request.Params, app.Key, app.SignType));

            //ToXml
            StringBuilder xml = new StringBuilder();
            xml.Append("<xml>");
            xml.AppendJoin("", request.Params.Select(x => $"<{x.Key}>{x.Value}</{x.Key}>"));
            xml.Append("</xml>");

            return xml.ToString();
        }

        /// <summary>
        /// 根据Xml字符串获取对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <param name="key"></param>
        /// <param name="signType"></param>
        /// <returns></returns>
        public static T Get<T>(string xml, string key, string signType = null)
        {
            string sign_type = signType;

            //非正常返回
            if (!xml.StartsWith("<xml>", StringComparison.CurrentCulture))
            {
                throw new MaxException(WeChatPayResultCode.ReturnError, xml);
            }

            var xe = XElement.Parse(xml).Elements();
            Dictionary<string, string> dict = xe.ToDictionary(x => x.Name.ToString(), x => x.Value);

            if (string.IsNullOrWhiteSpace(sign_type))
            {
                if (!dict.ContainsKey("sign_type"))
                {
                    throw new MaxException(WeChatPayResultCode.SignTypeNotExists, xml);
                }
                else
                {
                    sign_type = dict["sign_type"];
                }
            }

            Signature.Verify(dict, key, sign_type);

            return JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(dict));
        }
    }
}
