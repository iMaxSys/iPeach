using System;
using System.Collections.Generic;
using System.Text;

namespace iMaxSys.SDK.SNS.Base.API
{
    /// <summary>
    /// App
    /// </summary>
    public class AccessConfig
    {
        /// <summary>
        /// 租户Id
        /// </summary>
        public long TenantId { get; set; }

        /// <summary>
        /// 账号来源
        /// </summary>
        public int AccountSource { get; set; }

        /// <summary>
        /// AccountId（第三方平台主体Id,例如微信公众号原始Id）
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// AppSecret
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// SessionKey
        /// </summary>
        public string SessionKey { get; set; }

        /// <summary>
        /// ExtId
        /// </summary>
        public string ExtId { get; set; }

        /// <summary>
        /// Avatar
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// UnionId
        /// </summary>
        public string UnionId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public int Status { get; set; }
    }
}
