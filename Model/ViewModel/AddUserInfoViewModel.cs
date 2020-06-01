using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Model.ViewModel
{
    public class AddUserInfoViewModel
    {
        /// <summary>
        /// 学生姓名
        /// </summary>
        [Description("学生姓名")]
        public string UserName { get; set; }

        /// <summary>
        /// 学生性别
        /// </summary>
        [Description("学生性别")]
        public string Sex { get; set; }

        /// <summary>
        /// 学生联系电话
        /// </summary>
        [Description("学生联系电话")]
        public string Phone { get; set; }

        /// <summary>
        /// 学生描述
        /// </summary>
        [Description("学生描述")]
        public string Description { get; set; }

        /// <summary>
        /// 学生爱好
        /// </summary>
        [Description("学生爱好")]
        public string Hobby { get; set; }
    }
}
