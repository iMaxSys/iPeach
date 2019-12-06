
//----------------------------------------------------------------
//Copyright (C) 2016-2025 iMaxSys Co.,Ltd.
//All rights reserved.
//
//文件: WeChatPayResponse.cs
//摘要: 微信支付应答
//说明:
//
//当前：1.0
//作者：陶剑扬
//日期：2018-03-07
//----------------------------------------------------------------


namespace iPeach.Pay.WeChatPay.Api.Response
{
    /// <summary>
    /// 微信支付应答
    /// </summary>
    public class WeChatPayResponse : iPeach.Pay.Base.Api.Response
    {
        /// <summary>
        /// 成功
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// 信息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 信息详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 返回代码(SUCCESS/FAIL,此字段是通信标识，非交易标识，交易是否成功需要查看result_code来判断)
        /// </summary>
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        public string ReturnMsg { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string Appid { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 设备号
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        public string Sign { get; set; }

        /// <summary>
        /// 签名类型(目前支持HMAC-SHA256和MD5，默认为MD5)
        /// </summary>
        public string SignType { get; set; }

        /// <summary>
        /// 业务结果(SUCCESS/FAIL)
        /// </summary>
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string ErrCodeDes { get; set; }
    }
}
