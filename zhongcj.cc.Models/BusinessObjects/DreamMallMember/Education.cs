using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    public class Education : XPObject
    {
        public Education()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Education(Session session)
            : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        /// <summary>
        /// 学历名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 顺序
        /// </summary>
        public int Y;
    }
}
