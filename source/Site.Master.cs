using System;
using System.Web.UI;

namespace webproject
{
    public partial class SiteMaster : MasterPage
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Setting appsetting = (Setting)Application["appsetting"];
                footer.Text = appsetting.dFooter;
                header.Text = appsetting.Header;
            }
            catch (Exception)
            {

            }
            if (Session["userid"] == null)
            {

                control.Visible = false;
                login.Visible = true;
                logout.Visible = false;

            }
            else
            {
                login.Visible = false;
                control.Visible = true;
                logout.Visible = true;

            }

            visitor.Text = "you are visitor:" + Application["counter"];

        }

        protected void log_out(object sender, EventArgs e)
        {

            Session.Clear();
            Response.Redirect("Login.aspx");

        }
    }
}