using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Model.PageModel
{
    /// <summary>
    /// 分页
    /// </summary>
    public class PageSearchModel
    {
        public int TotalCount { get; set; }

        public List<UserInfo> DataList { get; set; }

        /// <summary>
        /// 成功状态（200表示成功）
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        public string ResultMsg { get; set; }
    }
}
