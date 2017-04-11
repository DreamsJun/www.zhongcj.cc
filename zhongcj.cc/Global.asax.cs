using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Configuration;
using zhongcj.cc;

namespace zhongcj.cc
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            //string conn = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(@".\SqlExpress", "sa", "123", "DBSymaiMall");
            var configConStr = ConfigurationManager.ConnectionStrings["DreamMallConnectString"].ConnectionString;
            var userId = Utils.GetItemValueFromConnectionString(configConStr, "User ID");
            var password = Utils.GetItemValueFromConnectionString(configConStr, "Password");
            var server = Utils.GetItemValueFromConnectionString(configConStr, "Data Source");
            var catalog = Utils.GetItemValueFromConnectionString(configConStr, "Initial Catalog");
            string conn = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(
                server,
                userId,
                password,
                catalog
                );
            DevExpress.Xpo.Metadata.XPDictionary dict = new DevExpress.Xpo.Metadata.ReflectionDictionary();
            // Initialize the XPO dictionary.

            dict.GetDataStoreSchema(new Type[] { typeof(zhongcj.cc.Models.BusinessObjects.DreamWeb.Article) });
            dict.GetDataStoreSchema(typeof(zhongcj.cc.Models.BusinessObjects.DreamMall.Product).Assembly);

            DevExpress.Xpo.XpoDefault.Session = null;
            DevExpress.Xpo.DB.IDataStore store = DevExpress.Xpo.XpoDefault.GetConnectionProvider(conn, DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
            DevExpress.Xpo.XpoDefault.DataLayer = new DevExpress.Xpo.ThreadSafeDataLayer(dict, store);
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            #region 防xss攻击

            if (Request.Cookies != null)
            {
                if (SecurityHelper.CheckCookieData())
                {
                    Response.Write("您提交的Cookie数据有恶意字符！");
                    Response.End();

                }
            }

            if (Request.UrlReferrer != null)
            {
                if (SecurityHelper.CheckReferer())
                {
                    Response.Write("您提交的Referrer数据有恶意字符！");
                    Response.End();
                }
            }

            if (Request.RequestType.ToUpper() == "POST")
            {
                if (SecurityHelper.CheckPostData())
                {
                    Response.Write("您提交的Post数据有恶意字符！");
                    Response.End();
                }
            }
            if (Request.RequestType.ToUpper() == "GET")
            {
                if (SecurityHelper.CheckGetData())
                {
                    Response.Write("您提交的Get数据有恶意字符！");
                    Response.End();
                }
            }
            #endregion
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}