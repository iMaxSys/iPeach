
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using iMaxSys.Max.Exceptions;
using iMaxSys.Max.Extentions;

using iPeach.Pay.Base;
using iPeach.Pay.WeChatPay.Api;
using iPeach.Pay.WeChatPay.Api.Request;
using iPeach.Pay.WeChatPay.Domain;
using iPeach.Pay.WeChatPay.Api.Response;
using iPeach.Pay.Base.Domain;
using iPeach.Pay.WeChatPay.Utilities;

namespace iPeach.Pay.WeChatPay.Services
{
    public class WeChatPay : IWeChatPay
    {
        const string FORMAT_DATETIME = "yyyyMMddHHmmss";

        #region SubmitAsync(API提交)

        /// <summary>
        /// API提交
        /// </summary>
        /// <typeparam name="T">结果类型</typeparam>
        /// <param name="app">App</param>
        /// <param name="request">请求</param>
        /// <param name="code">异常结果</param>
        /// <returns></returns>
        private async Task<T> SubmitAsync<T>(App app, WeChatPayRequest request, WeChatPayResultCode code) where T : WeChatPayResponse
        {
            T response = await WeChatPayClient.ExecuteAsync<T>(app, request);

            if (!response.Success)
                throw new MaxException(code, response.Detail);

            return response;
        }

        #endregion

        #region OrderAsync(下单)

        /// <summary>
        /// 下单
        /// </summary>
        /// <param name="app">App</param>
        /// <param name="order">Order</param>
        /// <returns></returns>
        public async Task<PaySysResult> OrderAsync(App app, PayOrder order)
        {
            OrderRequest request = new OrderRequest
            {
                DeviceInfo = order.TerminalId,
                Body = order.Name,
                Detail = order.Detail,
                Attach = order.Attach,
                OutTradeNo = order.XorderId,
                FeeType = order.FeeType,
                TotalFee = (order.Total * 100).ToString("#"),
                SpbillCreateIp = order.ClientIp,
                TimeStart = order.Start.ToString(FORMAT_DATETIME),
                TimeExpire = order.End.ToString(FORMAT_DATETIME),
                GoodsTag = order.Promotion,
                NotifyUrl = app.NotifyUrl,
                TradeType = Utility.GetTradeType(order.PayMode),
                ProductId = order.ProductId,
                LimitPay = order.LimitPay,
                OpenId = order.OpenId
            };

            OrderResponse response = await SubmitAsync<OrderResponse>(app, request, WeChatPayResultCode.OrderFail);

            //生成结果
            string nonceStr = Guid.NewGuid().ToString().Replace("-", "");
            string package = $"prepay_id={response.PrepayId}";
            string timestamp = DateTime.Now.ToTimestamp().ToString();

            Dictionary<string, string> dict = new Dictionary<string, string>
            {
                {"appId", app.AppId},
                {"nonceStr", nonceStr},
                {"package", package},
                {"signType", app.SignType},
                {"timeStamp",timestamp}
            };

            return new WeChatPayOrderResult
            {
                TradeType = response.TradeType,
                PrepayId = response.PrepayId,
                CodeUrl = response.CodeUrl,
                NonceStr = nonceStr,
                Package = package,
                Timestamp = timestamp,
                SignType = app.SignType,
                PaySign = Signature.Sign(dict, app.Key, app.SignType)
            };
        }

        #endregion

        /// <summary>
        /// 回调处理
        /// </summary>
        /// <param name="app"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public PaySysResult CallBack(App app, object data)
        {
            string xml = data as string;
            PayNotifyResponse response = Utility.Get<PayNotifyResponse>(xml, app.Key, app.SignType);

            return new WeChatPayNotifyResult
            {
                Attach = response.Attach,
                BankType = response.BankType,
                CashFee = response.CashFee,
                CashFeeType = response.CashFeeType,
                CouponCount = response.CouponCount,
                CouponFee = response.CouponFee,
                FeeType = response.FeeType,
                IsSubscribe = response.IsSubscribe,
                OutTradeNo = response.OutTradeNo,
                SettlementTotalFee = response.SettlementTotalFee,
                TimeEnd = DateTime.ParseExact(response.TimeEnd, "yyyyMMddHHmmss", System.Globalization.CultureInfo.CurrentCulture),
                TotalFee = response.TotalFee,
                TradeType = response.TradeType,
                TransactionId = response.TransactionId
            };
        }



        public Task Pay()
        {
            throw new NotImplementedException();
        }

        public Task QrCode()
        {
            throw new NotImplementedException();
        }

        public Task Query()
        {
            throw new NotImplementedException();
        }

        public Task Refund()
        {
            throw new NotImplementedException();
        }

        public Task Send()
        {
            throw new NotImplementedException();
        }

        public Task SendLucky()
        {
            throw new NotImplementedException();
        }
    }
}
