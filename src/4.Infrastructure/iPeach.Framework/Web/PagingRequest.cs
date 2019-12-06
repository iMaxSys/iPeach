
using System;

namespace iPeach.Framework.Web
{
    /// <summary>
    /// 分页请求
    /// </summary>
    public class PagingRequest : Request
    {
        const int SIZE = 10;

        int _index;
        int _size = SIZE;

        /// <summary>
        /// 索引(0+)
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                _index = value < 0 ? 0 : value;
            }
        }

        /// <summary>
        /// 大小(1-100)
        /// </summary>
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = value < 1 ? 1 : (value > 100 ? 100 : value);
            }
        }
    }
}