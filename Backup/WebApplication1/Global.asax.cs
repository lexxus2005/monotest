using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication1
{
    public class Global : System.Web.HttpApplication
    {
        public static void AppInitialize()
        {
            
        }
        protected void Application_Start(object sender, EventArgs e)
        {
            System.Web.Hosting.HostingEnvironment.RegisterVirtualPathProvider(new AssemblyResourceProvider());
        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}