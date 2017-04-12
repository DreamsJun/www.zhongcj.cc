using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using System.Collections;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    /// <summary>
    /// 地区表
    /// </summary>
    public class Region : XPObject
    {
        public Region()
            : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Region(Session session)
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
        /// 地区名称
        /// </summary>
        public string RegionName;

        /// <summary>
        /// 顺序
        /// </summary>
        public int Y;

        /// <summary>
        /// 上级地区
        /// </summary>
        public Region Parent { get; set; }

        /// <summary>
        /// 返回当前地区的完整名称
        /// </summary>
        public string FullRegionName
        {
            get
            {
                Region R = this;
                string fullName = R.RegionName;

                while (R.Parent != null)
                {
                    R = R.Parent;
                    fullName = R.RegionName + "-" + fullName;
                }

                //删除开头的-符号
                if (fullName.Substring(0, 1) == "-")
                {
                    fullName = fullName.Remove(0, 1);
                }

                return fullName;
            }
        }


        /// <summary>
        /// 返回包括自己的祖先路径
        /// </summary>
        /// <returns></returns>
        public Region[] GetAncestors()
        {
            ArrayList ancestorsList = new ArrayList();

            Region c = this;
            ancestorsList.Add(c);
            while (c.Parent != null)
            {
                c = c.Parent;
                ancestorsList.Add(c);
            }

            int count = ancestorsList.Count;
            Region[] ancestors = new Region[count];
            for (int i = 0; i < count; i++)
            {
                ancestors[i] = (Region)ancestorsList[count - 1 - i];
            }

            return ancestors;
        }

        /// <summary>
        /// 获取所有父亲类型的Id
        /// </summary>
        public string GetThisTotalRegionIds()
        {
            Region c = this;
            string ids = string.Format(",{0},", c.Oid);
            while (c.Parent != null)
            {
                ids += c.Parent.Oid + ",";
                c = c.Parent;
            }
            return ids;
        }
    }
}
