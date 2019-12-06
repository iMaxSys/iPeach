
using System.Threading.Tasks;

using iPeach.Pay.Base.Api;
using iPeach.Pay.Base.Domain;

namespace iPeach.Pay.Base
{
    /// <summary>
    /// 支付
    /// </summary>
    public interface IPay
    {
        /// <summary>
        /// 下单
        /// </summary>
        /// <param name="app">App</param>
        /// <param name="order">Order</param>
        /// <returns></returns>
        Task<PaySysResult> OrderAsync(App app, PayOrder order);

        /// <summary>
        /// 退款
        /// </summary>
        /// <returns></returns>
        Task Refund();

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        Task Query();

        /// <summary>
        /// 生成支付码
        /// </summary>
        /// <returns></returns>
        Task QrCode();

        /// <summary>
        /// 直接支付
        /// </summary>
        /// <returns></returns>
        Task Pay();

        /// <summary>
        /// 回调处理
        /// </summary>
        /// <param name="app"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        PaySysResult CallBack(App app, object data);

        /// <summary>
        /// 发红包
        /// </summary>
        /// <returns></returns>
        Task SendLucky();

        /// <summary>
        /// 发钱(企业支付到个人账户)
        /// </summary>
        /// <returns></returns>
        Task Send();
    }
}
