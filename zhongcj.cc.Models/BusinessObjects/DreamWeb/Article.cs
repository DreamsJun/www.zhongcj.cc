using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamWeb
{
    public class Article : XPObject
    {
        public Article() : base() { }
        public Article(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
