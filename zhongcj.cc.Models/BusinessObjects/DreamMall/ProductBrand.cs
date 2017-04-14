using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
    /// <summary>
    /// 产品品牌
    /// </summary>
    public class ProductBrand : XPObject
    {
        public ProductBrand() : base() { }
        public ProductBrand(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
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
