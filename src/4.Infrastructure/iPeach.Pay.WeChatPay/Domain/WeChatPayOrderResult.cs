

namespace iPeach.Pay.WeChatPay.Domain
{
    /// <summary>
    /// 支付下单结果
    /// </summary>
    public class WeChatPayOrderResult : WeChatPayResult
    {
        /// <summary>
        /// 交易类型(JSAPI--公众号支付、NATIVE--原生扫码支付、APP--app支付，统一下单接口trade_type的传参可参考这里 MICROPAY--刷卡支付，刷卡支付有单独的支付接口，不调用统一下单接口)
        /// </summary>
        public string TradeType { get; set; }
        /// <summary>
        /// 预支付交易会话标识(微信生成的预支付会话标识，用于后续接口调用中使用，该值有效期为2小时)
        /// </summary>
        public string PrepayId { get; set; }
        /// <summary>
        /// 二维码链接(trade_type为NATIVE时有返回，用于生成二维码，展示给用户进行扫码支付)
        /// </summary>
        public string CodeUrl { get; set; }
        /// <summary>
        /// 时间戳(时间戳从1970年1月1日00:00:00至今的秒数,即当前的时间)
        /// </summary>
        public string Timestamp { get; set; }
        /// <summary>
        /// 随机串(不长于32位)
        /// </summary>
        public string NonceStr { get; set; }
        /// <summary>
        /// 数据包(统一下单接口返回的 prepay_id 参数值，提交格式如：prepay_id=wx2017033010242291fcfe0db70013231072)
        /// </summary>
        public string Package { get; set; }
        /// <summary>
        /// 签名方式
        /// </summary>
        public string SignType { get; set; }
        /// <summary>
        /// 签名
        /// </summary>
        public string PaySign { get; set; }
    }
}
