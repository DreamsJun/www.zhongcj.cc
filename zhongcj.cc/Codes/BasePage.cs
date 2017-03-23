using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevExpress.Xpo;
using System.Web.UI;

namespace zhongcj.cc
{
    public class BasePage : System.Web.UI.Page
    {
        protected Session _Session;
  
        protected void Page_Init(object sender , EventArgs e)
        {
            _Session = new Session();
        }

        protected override void Render(HtmlTextWriter writer)
        {
            base.Render(writer);
            _Session.Dispose();
        }
    }
}