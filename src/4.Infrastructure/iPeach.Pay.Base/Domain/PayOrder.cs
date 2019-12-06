
using System;

namespace iPeach.Pay.Base.Domain
{
    /// <summary>
    /// 支付订单
    /// </summary>
    public class PayOrder
    {
        /// <summary>
        /// 设备信息(自定义参数，可以为终端设备号(门店号或收银设备ID)，PC网页或公众号内支付可以传"WEB")
        /// </summary>
        public string TerminalId { get; set; }

        /// <summary>
        ///  商品简单描述，该字段请按照规范传递(标题)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品详细描述
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 附加数据，在查询API和支付通知中原样返回，可作为自定义参数使用
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 商户订单号(商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*且在同一个商户号下唯一)
        /// 重新发起一笔支付要使用原订单号，避免重复支付；已支付过或已调用关单、撤销（请见后文的API列表）的订单号不能重新发起支付
        /// </summary>
        public string XorderId { get; set; }

        /// <summary>
        /// 标价币种(	符合ISO 4217标准的三位字母代码，默认人民币：CNY)
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 标价金额
        /// </summary>
        public decimal Total { get; set; }

        /// <summary>
        /// 终端IP
        /// </summary>
        public string ClientIp { get; set; }

        /// <summary>
        /// 交易起始时间(yyyyMMddHHmmss)
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// 交易结束时间(yyyyMMddHHmmss)
        /// </summary>
        public DateTime End { get; set; }

        /// <summary>
        /// 订单优惠标记
        /// </summary>
        public string Promotion { get; set; }

        /// <summary>
        /// 交易类型(JSAPI--公众号支付、NATIVE--原生扫码支付、APP--app支付，统一下单接口trade_type的传参可参考这里MICROPAY--刷卡支付，刷卡支付有单独的支付接口，不调用统一下单接口)
        /// </summary>
        public PayMode PayMode { get; set; }

        /// <summary>
        /// trade_type=NATIVE时（即扫码支付），此参数必传。此参数为二维码中包含的商品ID，商户自行定义。
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 指定支付方式(上传此参数no_credit--可限制用户不能使用信用卡支付)
        /// </summary>
        public string LimitPay { get; set; }

        /// <summary>
        /// 用户标识(trade_type=JSAPI，此参数必传，用户在商户appid下的唯一标识。)
        /// </summary>
        public string OpenId { get; set; }
    }
}
