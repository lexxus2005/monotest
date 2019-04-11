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

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Control ctrl = LoadControl("/App_Resource/WebApplicationControls.dll/WebApplicationControls.WebUserControl1.ascx");
            PlaceHolder1.Controls.Add(ctrl);
        }
    }
}
