using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    /// <summary>
    /// 产品图库
    /// </summary>
    public class ProductImage : XPObject
    {
        public ProductImage(): base(){}
        public ProductImage(Session session): base(session){}
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
