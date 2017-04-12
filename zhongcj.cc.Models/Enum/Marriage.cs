using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.Enum
{
    public enum Marriage
    {
        /// <summary>
        /// 未婚
        /// </summary>
        [DisplayName("未婚")]
        Unmarried =0,

        /// <summary>
        /// 已婚
        /// </summary>
        [DisplayName("已婚")]
        Married=1,

        /// <summary>
        /// 离婚
        /// </summary>
        [DisplayName("离婚")]
        Divorce=2,

        /// <summary>
        /// 丧偶
        /// </summary>
        [DisplayName("丧偶")]
        Widowed=3
    }
}
