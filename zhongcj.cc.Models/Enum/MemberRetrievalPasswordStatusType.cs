using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.Enum
{
    public enum MemberRetrievalPasswordStatusType
    {
        [DisplayName("新申请找回密码")]
        New = 0,
        [DisplayName("发送邮件待点击")]
        SendEmail = 1,
        [DisplayName("等待管理员修改")]
        WaitUpdated = 2,
        [DisplayName("成功修改")]
        Success = 3

    }
}
