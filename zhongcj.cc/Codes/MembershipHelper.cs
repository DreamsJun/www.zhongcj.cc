using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Xpo;
using System.Web.Security;
using System.Web.Configuration;
using System.Data.SqlClient;
using zhongcj.cc.Models.BusinessObjects.DreamMallMember;
using DevExpress.Data.Filtering;

namespace zhongcj.cc
{
    public class MembershipHelper
    {
        public static string GetUserPassword(string userName)
        {
            var user = Membership.GetUser(userName);
            var userId = user.ProviderUserKey;

            MembershipPasswordFormat passwordFormat;
            string passwordSalt;
            string password;

            var cstring = WebConfigurationManager.ConnectionStrings["OMAConnectString"];
            using (var conn = new SqlConnection(cstring.ConnectionString))
            {
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select PasswordFormat,PasswordSalt,Password from aspnet_Membership where UserId=@UserId";
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    conn.Open();
                    using (var rdr = cmd.ExecuteReader())
                    {
                        if (rdr != null && rdr.Read())
                        {
                            passwordFormat = (MembershipPasswordFormat)rdr.GetInt32(0);
                            passwordSalt = rdr.GetString(1);
                            password = rdr.GetString(2);
                        }
                        else
                        {
                            throw new Exception("An unhandled exception of type 'DoesntWorkException' has occured");
                        }
                    }
                }
            }

            return password;
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        public static bool ResetPassword(Session _Session,
            string userName, string sessionId, string password, out string status)
        {
            var retrieval = GetMemberRetrievalPasswordByUser(_Session, userName);

            if (retrieval == null || retrieval.Oid <= 0)
            {
                status = "您的请求不存在！请忽略此次操作。";
                return false;
            }

            if (retrieval.SessionID.ToLower() == sessionId.ToLower()
                && (int)(DateTime.Now - retrieval.RetrievalDate).TotalDays <= 3)//三天后失效
            {
                if (ResetPassword(userName, password))
                {
                    status = "密码重设成功！";
                    //修改重设请求表状态
                    retrieval.ResetDate = DateTime.Now;
                    retrieval.IsNewRetrieval = false;
                    retrieval.Log = "<div>用户：" + userName + " 于："
                        + retrieval.RetrievalDate.ToString("yyyy-MM-dd HH:mm:ss")
                        + "请求找回密码，并于："
                        + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + status
                        + "</div>"
                        + retrieval.Log;
                    retrieval.Status = status;
                    retrieval.Save();

                    return true;
                }
                else
                {
                    status = "密码重设过程发生错误，请联系网站管理员！";
                    return false;
                }
            }

            if (retrieval.SessionID.ToLower() == sessionId.ToLower()
                && (retrieval.RetrievalDate - DateTime.Now).TotalDays > 3)//超时，无效，结束此次请求
            {
                status = "本次找回密码已过期！";
                //修改重设请求表状态
                retrieval.ResetDate = DateTime.Now;
                retrieval.IsNewRetrieval = false;
                retrieval.Log = "<div>用户：" + userName + " 于："
                    + retrieval.RetrievalDate.ToString("yyyy-MM-dd HH:mm:ss")
                    + "请求找回密码，已过期！"
                    + "</div>"
                    + retrieval.Log;
                retrieval.Status = status;
                retrieval.Save();

                return false;
            }

            status = "";
            return ResetPassword(userName, password);
        }

        /// <summary>
        /// 重设密码
        /// </summary>
        /// <returns></returns>
        public static bool ResetPassword(Session _session, string userName,
            string password, out string status)
        {
            status = "";
            return ResetPassword(userName, password);
        }

        private static MemberRetrievalPassword GetMemberRetrievalPasswordByUser(Session _Session,
            string userName)
        {
            return _Session.FindObject<MemberRetrievalPassword>(
                CriteriaOperator.Parse("[UserName]= ?", userName)
                );
        }

        private static bool ResetPassword(string userName, string password)
        {
            //修改新密码，并返回状态
            var user = Membership.GetUser(userName);
            var userId = user.ProviderUserKey;
            return user.ChangePassword(user.ResetPassword(), password);
        }
    }
}