using System;
using System.Web.Configuration;

namespace webproject
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            string userName = WebConfigurationManager.AppSettings["PFUserName"];
            string passWord = WebConfigurationManager.AppSettings["PFPassWord"];
            if (username.Text == userName & password.Text == passWord)
            {
                Session.Add("userid", userName);
                Response.Redirect("control.aspx");
            }
            else
            {
                wroung.Text = "enter valide username and password";
            }
        }
    }
}