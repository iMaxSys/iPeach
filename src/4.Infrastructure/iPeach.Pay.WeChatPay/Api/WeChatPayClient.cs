
using System;
using System.Linq;
using System.Text.Json;
using System.Xml.Linq;
using System.Threading.Tasks;

using iMaxSys.Max.Net.Http;

using iPeach.Pay.Base;
using iPeach.Pay.WeChatPay.Utilities;
using iPeach.Pay.WeChatPay.Api.Request;
using iPeach.Pay.WeChatPay.Api.Response;

namespace iPeach.Pay.WeChatPay.Api
{
    public class WeChatPayClient
    {
        const string TAG_SUCCESS = "SUCCESS";

        /// <summary>
        /// JsonSerializerSettings
        /// </summary>
        /// private static JsonSerializerSettings JsonSerializerSettings { get; set; }


        static WeChatPayClient()
        {
            //JsonSerializerSettings = new JsonSerializerSettings
            //{
            //    Converters =
            //    {
            //        new StringEnumConverter
            //        {
            //            //支持:[EnumMember(Value = "value")] 
            //            CamelCaseText = true
            //        },
            //    },
            //    ContractResolver = new CamelCasePropertyNamesContractResolver()
            //};
        }

        /// <summary>
        /// ExecuteAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="app"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public static async Task<T> ExecuteAsync<T>(App app, WeChatPayRequest request)
        {
            //生成Xml
            string xml = Utility.Build(app, request);

            //提交
            string result = await HttpClient.PostXml(request.Action, xml);

            //解析对象
            T data = Utility.Get<T>(result, app.Key, app.SignType);
            WeChatPayResponse response = data as WeChatPayResponse;
            response.Success = response.ReturnCode == TAG_SUCCESS && response.ResultCode == TAG_SUCCESS;
            response.Message = string.IsNullOrWhiteSpace(response.ErrCodeDes) ? response.ReturnMsg : response.ErrCodeDes;
            response.Detail = $"{response.ReturnCode}:{response.ReturnMsg}/{response.ResultCode}:{response.ErrCode}:{response.ErrCodeDes}";

            return data;
        }
    }
}
