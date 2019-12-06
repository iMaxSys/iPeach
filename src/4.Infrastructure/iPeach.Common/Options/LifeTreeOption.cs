using System;
namespace iPeach.Common.Options
{
    /// <summary>
    /// 主配置
    /// </summary>
    public class LifeTreeOption
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 数据库配置集
        /// </summary>
        public DatabasesOption Databases { get; set; }

        /// <summary>
        /// 缓存配置
        /// </summary>
        public MemcacheOption Memcache { get; set; }
    }

    /// <summary>
    /// 数据库配置集
    /// </summary>
    public class DatabasesOption
    {
        /// <summary>
        /// 核心数据库
        /// </summary>
        public DatabaseOption Core { get; set; }
    }

    /// <summary>
    /// 数据库配置
    /// </summary>
    public class DatabaseOption
    {
        /// <summary>
        /// 连接串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 数据库类型
        /// 0:MariaDB,1:MySQL,2:SqlServer,3:Oracle,4:Sybase
        /// </summary>
        public int Type { get; set; }
    }

    /// <summary>
    /// 缓存配置
    /// </summary>
    public class MemcacheOption
    {
        /// <summary>
        /// 启用
        /// </summary>
        public bool Enable { get; set; }

        /// <summary>
        /// 连接串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 类型
        /// 0:Redis
        /// </summary>
        public int Type { get; set; }
    }

}
