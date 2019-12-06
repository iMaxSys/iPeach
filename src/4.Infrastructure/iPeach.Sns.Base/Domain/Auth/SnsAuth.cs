using System;
using System.Collections.Generic;
using System.Text;

namespace iPeach.Sns.Base.Domain.Auth
{
    /// <summary>
    /// Sns授权
    /// </summary>
    public class SnsAuth
    {
        /// <summary>
        /// AppId
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// AppSecret
        /// </summary>
        public string AppSecret { get; set; }

        /// <summary>
        /// AppId
        /// </summary>
        public string Code { get; set; }
    }
}
