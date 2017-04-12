using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using zhongcj.cc.Models.Enum;

namespace zhongcj.cc.Models.BusinessObjects.DreamMallMember
{
    public class Member : XPObject
    {
        public Member() : base() { }
        public Member(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        private string _UserName;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        /// <summary>
        /// 地区
        /// </summary>
        public Region Region { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Size(50)]
        public string Address
        {
            get;
            set;
        }

        /// <summary>
        /// 手机
        /// </summary>
        [Size(50)]
        public string Mobile
        {
            get;
            set;
        }

        /// <summary>
        /// 固话
        /// </summary>
        [Size(50)]
        public string Phone
        {
            get;
            set;
        }

        /// <summary>
        /// 邮编
        /// </summary>
        [Size(50)]
        public string Postcode
        {
            get;
            set;
        }

        /// <summary>
        /// 出生年月日
        /// </summary>
        public DateTime? BirthDate
        {
            get;
            set;
        }

        /// <summary>
        /// 婚姻状况
        /// </summary>
        public Marriage Marriage
        {
            get;
            set;
        }
        /// <summary>
        /// 输出婚姻状况文本，默认未婚
        /// </summary>
        public string MarriageText
        {
            get 
            {
                string txt = "未婚";
                switch (Marriage)
                {
                    case Marriage.Unmarried:
                        txt = "未婚";
                        break;
                    case Marriage.Married:
                        txt = "已婚";
                        break;
                    case Marriage.Divorce:
                        txt = "离婚";
                        break;
                    case Marriage.Widowed:
                        txt = "丧偶";
                        break;
                }

                return txt;
            }
        }

        /// <summary>
        /// 性别
        /// </summary>
        public bool Gender
        {
            get;
            set;
        }

        public string GenderText
        {
            get
            {
                if (this.Gender)
                {
                    return "男";
                }
                else
                {
                    return "女";
                }
            }
        }

        /// <summary>
        /// 身高
        /// </summary>
        public decimal? Height
        {
            get;
            set;
        }

        /// <summary>
        /// 体重
        /// </summary>
        public decimal? Weight
        {
            get;
            set;
        }

        /// <summary>
        /// 教育程度
        /// </summary>
        public Education Education { get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        [Size(50)]
        public string Vocation
        {
            get;
            set;
        }

        /// <summary>
        /// 爱好兴趣
        /// </summary>
        [Size(50)]
        public string Interest
        {
            get;
            set;
        }

        /// <summary>
        /// 备注
        /// </summary>
        [Size(200)]
        public string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 电邮地址
        /// </summary>
        public string EMail { get; set; }

        /// <summary>
        /// 真实名称
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 会员级别
        /// </summary>
        public MemberLevel MemberLevel { get; set; }

        public string MemberLevelText
        {
            get
            {
                string txt = "铜牌会员";
                switch (MemberLevel)
                {
                    case MemberLevel.BronzeMedal:
                        txt = "铜牌会员";
                        break;
                    case MemberLevel.SilverMedal:
                        txt = "银牌会员";
                        break;
                    case MemberLevel.GoldMedal:
                        txt = "金牌会员";
                        break;
                    case MemberLevel.Diamonds:
                        txt = "钻石会员";
                        break;
                }
                return txt;
            }
        }
    }
}
