
namespace iPeach.Pay.WeChatPay.Api.Response
{
    /// <summary>
    /// 统一下单应答
    /// </summary>
    public class OrderResponse : WeChatPayResponse
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
    }
}