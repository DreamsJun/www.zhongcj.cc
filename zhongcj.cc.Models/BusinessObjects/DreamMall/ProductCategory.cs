using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Collections;
using DevExpress.Data.Filtering;
using DevExpress.Xpo.DB;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    /// <summary>
    /// 产品类型
    /// </summary>
    public class ProductCategory : XPObject
    {
        public ProductCategory() : base() { }
        public ProductCategory(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value;  }
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

        private string _MetaKeywords;
        [Size(300)]
        public string MetaKeywords
        {
            get { return _MetaKeywords; }
            set
            {
                _MetaKeywords = value;
            }
        }

        private string _MetaDescription;
        [Size(300)]
        public string MetaDescription
        {
            get { return _MetaDescription; }
            set
            {
                _MetaDescription = value;
            }
        }

        private string _PageTitle;
        [Size(200)]
        public string PageTitle
        {
            get { return _PageTitle; }
            set
            {
                _PageTitle = value;
            }
        }


        /// <summary>
        /// 返回父亲产品类型
        /// </summary>
        [Association("FK_Children_ProductCategory")]
        public ProductCategory Parent
        {
            get
            {
                return GetPropertyValue<ProductCategory>("Parent");
            }
            set
            {
                SetPropertyValue<ProductCategory>("Parent", value);
            }
        }

        /// <summary>
        /// 顶级类型
        /// </summary>
        public ProductCategory RootCategory
        {
            get
            {
                ProductCategory c = this;
                while (c.Parent != null)
                {
                    c = c.Parent;
                }
                return c;
            }
        }

        /// <summary>
        /// 根据关系返回子孙
        /// </summary>
        [Association("FK_Children_ProductCategory")]
        public XPCollection<ProductCategory> Children
        {
            get
            {
                return GetCollection<ProductCategory>("Children");
            }
        }

        /// <summary>
        /// 获取所有父亲类型的Id
        /// </summary>
        public string GetThisTotalCategoryIds()
        {
            ProductCategory c = this;
            string ids = string.Format(",{0},", c.Oid);
            while (c.Parent != null)
            {
                ids += c.Parent.Oid + ",";
                c = c.Parent;
            }
            return ids;
        }

        /// <summary>
        /// 获取所有父亲类型名称
        /// </summary>
        /// <returns></returns>
        public string GetThisTotalCategoryNames()
        {
            ProductCategory c = this;
            string names = string.Format(",{0},", c.Name);
            while (c.Parent != null)
            {
                names += c.Parent.Name + ",";
                c = c.Parent;
            }
            return names;
        }

        /// <summary>
        /// 返回包括自己的祖先路径
        /// </summary>
        /// <returns></returns>
        public ProductCategory[] GetAncestors()
        {
            ArrayList ancestorsList = new ArrayList();

            ProductCategory c = this;
            ancestorsList.Add(c);
            while (c.Parent != null)
            {
                c = c.Parent;
                ancestorsList.Add(c);
            }

            int count = ancestorsList.Count;
            ProductCategory[] ancestors = new ProductCategory[count];
            for (int i = 0; i < count; i++)
            {
                ancestors[i] = (ProductCategory)ancestorsList[count - 1 - i];
            }

            return ancestors;
        }

        
        public XPCollection<ProductCategoryVersion> ProductCategoryVersionItems
        {
            get 
            {

                CriteriaOperator criter = CriteriaOperator.Parse("ProductCategory = ?", this);

                XPCollection<ProductCategoryVersion> list = new XPCollection<ProductCategoryVersion>(Session
                    , criter
                    , new SortProperty("Y", SortingDirection.Ascending)
                    );

                return list;
            }
        }
    }
}
