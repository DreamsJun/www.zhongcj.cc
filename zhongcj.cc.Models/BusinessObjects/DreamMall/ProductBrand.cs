using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    public class ProductBrand : XPObject
    {
        public ProductBrand() : base() { }
        public ProductBrand(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}
