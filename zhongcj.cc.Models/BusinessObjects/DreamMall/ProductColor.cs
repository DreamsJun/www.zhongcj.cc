using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    /// <summary>
    /// 产品颜色
    /// </summary>
    public class ProductColor : BaseObject
    {
        public ProductColor() : base() { }
        public ProductColor(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private Product _Product;
        /// <summary>
        /// 产品
        /// </summary>
        public Product Product
        {
            get { return _Product; }
            set { _Product = value; }
        }

        private string _Name;
        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private decimal _ProductColorGroup;
        /// <summary>
        /// 产品颜色组
        /// </summary>
        public decimal ProductColorGroup
        {
            get { return _ProductColorGroup; }
            set { _ProductColorGroup = value; }
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
