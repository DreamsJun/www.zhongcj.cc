using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.Enum
{
    public enum MemberLevel
    {
        /// <summary>
        /// 铜牌会员
        /// </summary>
        [DisplayName("铜牌会员")]
        BronzeMedal = 0,
        /// <summary>
        /// 银牌会员
        /// </summary>
        [DisplayName("银牌会员")]
        SilverMedal = 1,
        /// <summary>
        /// 金牌会员
        /// </summary>
        [DisplayName("金牌会员")]
        GoldMedal = 2,
        /// <summary>
        /// 钻石会员
        /// </summary>
        [DisplayName("钻石会员")]
        Diamonds = 3

    }
}
