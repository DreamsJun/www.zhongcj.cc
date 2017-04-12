using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Persistent.BaseImpl;

namespace zhongcj.cc.Models.BusinessObjects.DreamMall
{
     public class ProductColor: BaseObject
    {
         public ProductColor() : base() { }
         public ProductColor(Session session) : base(session) { }
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

         private int _ProductColorGroup;
         /// <summary>
         /// 产品颜色组
         /// </summary>
         public int ProductColorGroup
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
