using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    public class Product : BaseObject
    {
        public Product() : base() { }
        public Product(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        //[Key]
        //public Guid Oid
        //{
        //    get;
        //    set;
        //}

        private ProductCategory _ProductCategory;
        /// <summary>
        /// 产品类型
        /// </summary>        
        public ProductCategory ProductCategory
        {
            get { return _ProductCategory; }
            set { _ProductCategory = value; }
        }

        private ProductBrand _ProductBrand;
        /// <summary>
        /// 产品品牌
        /// </summary>
        public ProductBrand ProductBrand
        {
            get { return _ProductBrand; }
            set { _ProductBrand = value; }
        }



        private string _Name;
        /// <summary>
        /// 产品名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Alias;
        /// <summary>
        /// 别名
        /// </summary>
        public string Alias
        {
            get { return _Alias; }
            set { _Alias = value; }
        }


        [Association, Aggregated]
        [DevExpress.ExpressApp.DC.XafDisplayName("产品图库")]
        [DevExpress.Persistent.Base.VisibleInDetailView(false), DevExpress.Persistent.Base.VisibleInListView(false), DevExpress.Persistent.Base.VisibleInLookupListView(false)]
        public XPCollection<ProductImage> ProductImage
        {
            get { return GetCollection<ProductImage>("ProductImage"); }
        }
    }
}
