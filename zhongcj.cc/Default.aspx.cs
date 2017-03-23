using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;

namespace zhongcj.cc
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            aaHandler hander = new aaHandler(aa);
            int a;
            System.IAsyncResult result = hander.BeginInvoke(out a,null, null);
           ((aaHandler)((AsyncResult)result).AsyncDelegate ).EndInvoke(out a,result);
            
        }
        delegate int aaHandler(out int a);
        int aa(out int a)
        {
            System.Threading.Thread.Sleep(100);
            a = 20;
            return 10;
        }
    }
}