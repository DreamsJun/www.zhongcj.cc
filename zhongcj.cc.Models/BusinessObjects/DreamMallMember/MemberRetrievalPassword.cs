using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    /// <summary>
    /// 用户找回密码
    /// </summary>
    public class MemberRetrievalPassword : XPObject
    {

        public MemberRetrievalPassword()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public MemberRetrievalPassword(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        /// <summary>
        /// 用户ID
        /// </summary>
        [Indexed(Unique = true)]
        public string UserName;

        /// <summary>
        /// 日志
        /// </summary>
        [Size(2147483647)]
        public string Log;

        /// <summary>
        /// 申请找回日期
        /// </summary>
        public DateTime RetrievalDate;

        /// <summary>
        /// 重设密码日期
        /// </summary>
        public DateTime ResetDate;

        /// <summary>
        /// 会话键
        /// </summary>
        [Size(50)]
        public string SessionID;

        /// <summary>
        /// 状态
        /// </summary>
        [Size(50)]
        public string Status;

        /// <summary>
        /// 是否新的请求
        /// </summary>
        public bool IsNewRetrieval;

    }
}
