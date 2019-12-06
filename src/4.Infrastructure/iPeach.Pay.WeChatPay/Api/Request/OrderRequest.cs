
using System.Collections.Generic;

namespace iPeach.Pay.WeChatPay.Api.Request
{
    /// <summary>
    /// 统一下单请求
    /// </summary>
    public class OrderRequest : WeChatPayRequest
    {
        /// <summary>
        /// 设备号(自定义参数，可以为终端设备号(门店号或收银设备ID)，PC网页或公众号内支付可以传"WEB")
        /// </summary>
        public string DeviceInfo { get; set; }

        /// <summary>
        /// 商品描述(标题)
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 商品详情
        /// </summary>
        public string Detail { get; set; }

        /// <summary>
        /// 附加数据(在查询API和支付通知中原样返回，可作为自定义参数使用)
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 商户订单号(商户系统内部订单号，要求32个字符内，只能是数字、大小写字母_-|*且在同一个商户号下唯一)
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 标价币种(符合ISO 4217标准的三位字母代码，默认人民币：CNY)
        /// </summary>
        public string FeeType { get; set; } = "CNY";

        /// <summary>
        /// 订单总金额，单位为分
        /// </summary>
        public string TotalFee { get; set; }

        /// <summary>
        /// 终端IP(APP和网页支付提交用户端ip，Native支付填调用微信支付API的机器IP)
        /// </summary>
        public string SpbillCreateIp { get; set; }

        /// <summary>
        /// 交易起始时间(订单生成时间，格式为yyyyMMddHHmmss，如2009年12月25日9点10分10秒表示为20091225091010)
        /// </summary>
        public string TimeStart { get; set; }

        /// <summary>
        /// 交易结束时间(订单失效时间，格式为yyyyMMddHHmmss，如2009年12月27日9点10分10秒表示为20091227091010。订单失效时间是针对订单号而言的，由于在请求支付的时候有一个必传参数prepay_id只有两小时的有效期，所以在重入时间超过2小时的时候需要重新请求下单接口获取新的prepay_id)
        /// </summary>
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单优惠标记(订单优惠标记，使用代金券或立减优惠功能时需要的参数)
        /// </summary>
        public string GoodsTag { get; set; }

        /// <summary>
        /// 通知地址(异步接收微信支付结果通知的回调地址，通知url必须为外网可访问的url，不能携带参数)
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 交易类型(JSAPI--公众号支付、NATIVE--原生扫码支付、APP--app支付，统一下单接口trade_type的传参可参考这里MICROPAY--刷卡支付，刷卡支付有单独的支付接口，不调用统一下单接口)
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 商品ID(trade_type=NATIVE时（即扫码支付），此参数必传。此参数为二维码中包含的商品ID，商户自行定义)
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// 指定支付方式(上传此参数no_credit--可限制用户不能使用信用卡支付)
        /// </summary>
        public string LimitPay { get; set; }

        /// <summary>
        /// 用户标识(trade_type=JSAPI，此参数必传，用户在商户appid下的唯一标识)
        /// </summary>
        public string OpenId { get; set; }
        /// <summary>
        /// Action
        /// </summary>
        public override string Action => "https://api.mch.weixin.qq.com/pay/unifiedorder";

        /// <summary>
        /// Build
        /// </summary>
        /// <param name="dict"></param>
        public override void Build()
        {
            base.Build();
            Params.Add("device_info", DeviceInfo);
            Params.Add("body", Body);
            Params.Add("detail", Detail);
            Params.Add("attach", Attach);
            Params.Add("out_trade_no", OutTradeNo);
            Params.Add("fee_type", FeeType);
            Params.Add("total_fee", TotalFee);
            Params.Add("spbill_create_ip", SpbillCreateIp);
            Params.Add("time_start", TimeStart);
            Params.Add("time_expire", TimeExpire);
            Params.Add("goods_tag", GoodsTag);
            Params.Add("notify_url", NotifyUrl);
            Params.Add("trade_type", TradeType);
            Params.Add("product_id", ProductId);
            Params.Add("limit_pay", LimitPay);
            Params.Add("openid", OpenId);
        }
    }
}