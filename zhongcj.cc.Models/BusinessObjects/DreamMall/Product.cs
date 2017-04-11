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


        private ProductImage _ProductImage;
        /// <summary>
        /// 产品图库
        /// </summary>
        internal ProductImage ProductImage
        {
            get { return _ProductImage; }
            set { _ProductImage = value; }
        }


    }
}
