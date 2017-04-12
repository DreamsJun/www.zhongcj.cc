using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;
using zhongcj.cc.Models.BusinessObjects.DreamMall;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    /// <summary>
    /// 用户评论
    /// </summary>
    public class MemberReView : BaseObject
    {
        public MemberReView() : base() { }
        public MemberReView(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private Product _Product;
        /// <summary>
        /// 评论的产品
        /// </summary>
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        private Member _Member;
        /// <summary>
        /// 用户
        /// </summary>
        public Member Member
        {
            get { return _Member;  }
            set { _Member = value; }
           
        }

        private string _Content;
        /// <summary>
        /// 品论内容
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

        /// <summary>
        /// 返回父亲评论
        /// </summary>
        [Association("FK_Children_MemberReView")]
        public MemberReView Parent
        {
            get
            {
                return GetPropertyValue<MemberReView>("Parent");
            }
            set
            {
                SetPropertyValue<MemberReView>("Parent", value);
            }
        }

        /// <summary>
        /// 根据关系返回子孙
        /// </summary>
        [Association("FK_Children_MemberReView")]
        public XPCollection<MemberReView> Children
        {
            get
            {
                return GetCollection<MemberReView>("Children");
            }
        }

        

        /// <summary>
        /// 评论图库
        /// </summary>
        [Association, Aggregated]
        [DevExpress.ExpressApp.DC.XafDisplayName("评论图库")]
        [DevExpress.Persistent.Base.VisibleInDetailView(false), DevExpress.Persistent.Base.VisibleInListView(false), DevExpress.Persistent.Base.VisibleInLookupListView(false)]
        public XPCollection<MemberReViewImage> MemberReViewImage
        {
            get { return GetCollection<MemberReViewImage>("MemberReViewImage"); }
        }



    }
}
