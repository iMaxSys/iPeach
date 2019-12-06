
using System.Collections.Generic;

namespace iPeach.Pay.WeChatPay.Api.Request
{
    /// <summary>
    /// 微信支付请求
    /// </summary>
    public abstract class WeChatPayRequest : iPeach.Pay.Base.Api.Request
    {
        /// <summary>
        /// 是否使用证书
        /// </summary>
        public bool UseCert { get; set; } = false;

        /// <summary>
        /// 请求方法(GET or POST)
        /// </summary>
        public virtual string Method => "POST";

        /// <summary>
        /// API接口名称
        /// </summary>
        public abstract string Action { get; }

        /// <summary>
        /// 数据格式
        /// </summary>
        public string Format { get; set; } = "XML";

        /// <summary>
        /// 编码格式
        /// </summary>
        public string Charset { get; set; } = "utf-8";

        /// <summary>
        /// 设备号(自定义参数，可以为终端设备号(门店号或收银设备ID)，PC网页或公众号内支付可以传"WEB")
        /// </summary>
        //public string DeviceInfo { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        //public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        //public string MchId { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        //public string Key { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        //public string NonceStr { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        //public string Sign { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        //public string SignType { get; set; } = "MD5";

        /// <summary>
        /// API访问需要携带的参数，具体参见每个API的详细文档
        /// </summary>
        public Dictionary<string, string> Params;

        /// <summary>
        /// 构建参数字典
        /// </summary>
        /// <returns></returns>
        public virtual void Build()
        {
            Params = new Dictionary<string, string>();
        }
    }
}
