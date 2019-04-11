using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace WebApplicationControls
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Label1.Text = "Clicked";
        }
    }
}