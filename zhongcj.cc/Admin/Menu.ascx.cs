using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxNavBar;

namespace zhongcj.cc.Admin
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ASPxNavBar1.DataBind();

            //if (Request.Url.AbsoluteUri.ToLower().Contains("adsedit.aspx"))
            //{
            //    ASPxNavBar1.Groups[4].Items.Insert(0, new NavBarItem("广告编辑", "", "", "AdsEdit.aspx", ""));
            //    ASPxNavBar1.Groups[4].Expanded = true;
            //}
        }


        protected void nbMenu_ItemDataBound(object source, DevExpress.Web.ASPxNavBar.NavBarItemEventArgs e)
        {
            if (e.Item.NavigateUrl.ToLower().Contains(Request.Url.PathAndQuery.ToLower()))
            {
                e.Item.Selected = true;
                e.Item.Group.Expanded = true;
                
            }
        }
    }
}