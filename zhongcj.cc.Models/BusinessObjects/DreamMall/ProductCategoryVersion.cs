using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    /// <summary>
    /// 产品类型版本
    /// </summary>
    public class ProductCategoryVersion : XPObject
    {
        public ProductCategoryVersion() : base() { }
        public ProductCategoryVersion(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private ProductCategory _ProductCategory;
        /// <summary>
        /// 产品类型
        /// </summary>
        public ProductCategory ProductCategory
        {
            get { return _ProductCategory; }
            set { _ProductCategory = value; }
        }

        private string _Name;
        /// <summary>
        /// 版本名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
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
