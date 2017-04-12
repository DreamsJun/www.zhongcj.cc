using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    /// <summary>
    /// 评论晒图
    /// </summary>
    public class MemberReViewImage : XPObject
    {
        public MemberReViewImage() : base() { }
        public MemberReViewImage(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        private MemberReView _MemberReView;
        /// <summary>
        /// 评论
        /// </summary>
        public MemberReView MemberReView
        {
            get { return _MemberReView; }
            set { _MemberReView = value; }
        }

        private string _Image;
        /// <summary>
        /// 图片
        /// </summary>
        public string Image
        {
            get { return _Image; }
            set { _Image = value; }
        }

        private int _Y;
        /// <summary>
        /// 顺序
        /// </summary>
        public int Y
        {
            get { return _Y; }
            set { _Y = value; }
        }
    }
}
