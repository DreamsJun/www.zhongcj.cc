using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    /// <summary>
    /// 用户评论其他用户评论
    /// </summary>
    public class MemberReViewOhter : XPObject
    {
        public MemberReViewOhter() : base() { }
        public MemberReViewOhter(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private MemberReView _MemberReView;
        /// <summary>
        /// 原品论
        /// </summary>
        public MemberReView MemberReView
        {
            get { return _MemberReView; }
            set { _MemberReView = value; }
        }

        private Member _Member;
        /// <summary>
        /// 会员
        /// </summary>
        public Member Member
        {
            get { return _Member; }
            set { _Member = value; }
        }

        private string _Content;
        /// <summary>
        /// 评论内容
        /// </summary>
        [Size(300)]
        public string Content
        {
            get { return _Content; }
            set { _Content = value; }
        }

        private DateTime _ReViewDateTime;
        /// <summary>
        /// 评论时间
        /// </summary>
        public DateTime ReViewDateTime
        {
            get { return _ReViewDateTime; }
            set { _ReViewDateTime = value; }
        }
        
    }
}
