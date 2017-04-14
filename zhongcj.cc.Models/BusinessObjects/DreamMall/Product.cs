using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;
using zhongcj.cc.Models.BusinessObjects.DreamMallMember;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    /// <summary>
    /// 产品
    /// </summary>
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

        private decimal _Price;
        /// <summary>
        /// 价格
        /// </summary>
        public decimal Price
        {
            get { return _Price; }
            set { _Price = value; }
        }



        /// <summary>
        /// 产品图库
        /// </summary>
        public XPCollection<ProductImage> ProductImageItems
        {
            get 
            {

                CriteriaOperator criter = CriteriaOperator.Parse("Product = ?", this);

                XPCollection<ProductImage> list = new XPCollection<ProductImage>(Session
                    ,criter
                    ,new SortProperty("Y",SortingDirection.Ascending)
                    );

                return list; 
            }
        }

        /// <summary>
        /// 用户评论
        /// </summary>        
        public XPCollection<MemberReView> MemberReViewItems
        {
            get
            {
                CriteriaOperator criter = CriteriaOperator.Parse("Product = ?", this);

                XPCollection<MemberReView> list = new XPCollection<MemberReView>(Session
                    , criter
                    , new SortProperty("Y", SortingDirection.Ascending)
                    );

                return list;
            }
        }
    }
}
