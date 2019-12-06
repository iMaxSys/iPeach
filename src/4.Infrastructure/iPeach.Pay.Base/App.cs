
namespace iPeach.Pay.Base
{
    /// <summary>
    /// Pay App
    /// </summary>
    public class App
    {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        public string MchId { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        public string MchName { get; set; }

        /// <summary>
        /// AppKey
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 公钥
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// 私钥
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        public string SignType { get; set; }

        /// <summary>
        /// 证书（仅退款、撤销订单时需要）
        /// </summary>
        public byte[] Cert { get; set; }

        /// <summary>
        /// 证书密码
        /// </summary>
        public string CertPassword { get; set; }

        /// <summary>
        /// Server
        /// </summary>
        public string Server { get; set; }

        /// <summary>
        /// 通知回调路径
        /// </summary>
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 返回路径
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 代理
        /// 默认IP和端口号分别为0.0.0.0和0，此时不开启代理（如有需要才设置）
        /// </summary>
        public string Proxy { get; set; }

        /// <summary>
        /// 报告等级
        /// </summary>
        public int ReportLevel { get; set; }
    }
}
