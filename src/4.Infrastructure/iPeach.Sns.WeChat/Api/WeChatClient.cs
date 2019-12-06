
using System;
using System.Text.Json;
using System.Threading.Tasks;

using iMaxSys.Max.Domain;
using iMaxSys.Max.Net.Http;
using iMaxSys.Max.Exceptions;

using iPeach.Sns.Base.Api;
using iPeach.Sns.WeChat.Domain;
using iPeach.Sns.WeChat.Api.Request;
using iPeach.Sns.WeChat.Api.Response;

namespace iPeach.Sns.WeChat.Api
{
    public static class WeChatClient
    {
        /// <summary>
        /// JsonSerializerSettings
        /// </summary>
        //private static JsonSerializerSettings JsonSerializerSettings { get; set; }


        //static WeChatClient()
        //{
        //    JsonSerializerSettings = new JsonSerializerSettings
        //    {
        //        Converters =
        //        {
        //            new StringEnumConverter
        //            {
        //                //支持:[EnumMember(Value = "value")] 
        //                CamelCaseText = true
        //            },
        //        },
        //        ContractResolver = new CamelCasePropertyNamesContractResolver()
        //    };
        //}

        //static JsonSerializerSettings _settings;

        static WeChatClient()
        {
            //DefaultContractResolver contractResolver = new DefaultContractResolver
            //{
            //    NamingStrategy = new SnakeCaseNamingStrategy()
            //};

            //_settings = new JsonSerializerSettings
            //{
            //    Converters =
            //            {
            //                new StringEnumConverter
            //                {
            //                    //支持:[EnumMember(Value = "value")] 
            //                    CamelCaseText = true
            //                },
            //            },
            //    ContractResolver = contractResolver
            //};
        }

        /// <summary>
        /// ExecuteAsync
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="request"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public static async Task<T> ExecuteAsync<T>(WeChatRequest request, WeChatResultCode code)
        {
            Result result;
            string response;

            try
            {
                if (request.Method == "POST")
                {

                    response = await HttpClient.Post(request.Url, null);
                }
                else
                {
                    response = await HttpClient.Get(request.Url, null);
                }
            }
            catch (Exception ex)
            {
                throw new MaxException(ex, code);
            }


            //包含errcode表示失败/异常
            if (response.Contains("errcode"))
            {
                ErrorResponse errorResponse = JsonSerializer.Deserialize<ErrorResponse>(response);

                result = new Result
                {
                    Success = false,
                    Code = errorResponse.ErrCode,
                    Message = errorResponse.ErrMsg
                };

                throw new MaxException(code, response);
            }
            else
            {
                return JsonSerializer.Deserialize<T>(response);
            }
        }
    }
}
