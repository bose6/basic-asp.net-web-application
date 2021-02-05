using System;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace webproject
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application.Add("key", "1234");
            string key = (string)Application["key"];
            Setting appsetting = manager.Loadsetting(Server.MapPath("~/appdata/setting.xml"));
            Application.Add("appsetting", appsetting);
        }


        void Session_Start(object sender, EventArgs e)
        {
            Setting appsetting = (Setting)Application["appsetting"];

            int icounter = appsetting.visitor;
            icounter++;
            appsetting.visitor = icounter;
            Application["counter"] = icounter.ToString();
            manager.Savesettings(Server.MapPath("~/appdata/setting.xml"), appsetting);
            Application["appsetting"] = appsetting;


        }
    }
}