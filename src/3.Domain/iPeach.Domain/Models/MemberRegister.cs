
using System;

namespace iPeach.Domain.Models
{
    /// <summary>
    /// 会员注册
    /// </summary>
    public class MemberRegister
    {
        /// <summary>
        /// ExtId
        /// </summary>
        public string ExtId { get; set; }

        /// <summary>
        /// 验证码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 社交平台加密数据（微信绑定电话）
        /// </summary>
        public string EncryptedData { get; set; }

        /// <summary>
        /// IV
        /// </summary>
        public string IV { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// PhoneNumber
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        public string Province { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 头像
        /// </summary>
        public string Avatar { get; set; }

        /// <summary>
        /// 性别(0未知,1男,2女)
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// IP
        /// </summary>
        public string IP { get; set; }
    }
}
