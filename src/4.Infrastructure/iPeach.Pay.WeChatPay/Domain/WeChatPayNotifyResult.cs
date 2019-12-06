using System;
using System.Collections.Generic;
using System.Text;

namespace iPeach.Pay.WeChatPay.Domain
{
    public class WeChatPayNotifyResult : WeChatPayResult
    {
        /// <summary>
        /// 是否关注公众账号(用户是否关注公众账号，Y-关注，N-未关注，仅在公众账号类型支付有效)
        /// </summary>
        public string IsSubscribe { get; set; }

        /// <summary>
        /// 交易类型(JSAPI、NATIVE、APP)
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 付款银行
        /// </summary>
        public string BankType { get; set; }

        /// <summary>
        /// 订单总金额，单位为分
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 应结订单金额(应结订单金额=订单金额-非充值代金券金额，应结订单金额《=订单金额)
        /// </summary>
        public int SettlementTotalFee { get; set; }

        /// <summary>
        /// 货币种类(货币类型，符合ISO4217标准的三位字母代码，默认人民币：CNY)
        /// </summary>
        public string FeeType { get; set; }

        /// <summary>
        /// 现金支付金额(现金支付金额订单现金支付金额)
        /// </summary>
        public int CashFee { get; set; }

        /// <summary>
        /// 现金支付货币类型(货币类型，符合ISO4217标准的三位字母代码，默认人民币：CNY)
        /// </summary>
        public string CashFeeType { get; set; }

        /// <summary>
        /// 总代金券金额(代金券金额《=订单金额，订单金额-代金券金额=现金支付金额)
        /// </summary>
        public int CouponFee { get; set; }

        /// <summary>
        /// 代金券使用数量
        /// </summary>
        public int CouponCount { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商家数据包
        /// </summary>
        public string Attach { get; set; }

        /// <summary>
        /// 支付完成时间(	支付完成时间，格式为yyyyMMddHHmmss，如2009年12月25日9点10分10秒表示为20091225091010)
        /// </summary>
        public DateTime TimeEnd { get; set; }
    }
}
