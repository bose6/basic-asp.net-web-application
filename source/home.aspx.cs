using System;

namespace webproject
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                try
                {
                    Setting appsetting = (Setting)Application["appsetting"];
                    text2.Text = appsetting.text2;

                }
                catch (Exception)
                {

                }
            }
            else
            {
                try
                {
                    Setting appsetting = (Setting)Application["appsetting"];
                    text2.Text = appsetting.text1;

                }
                catch (Exception)
                {

                }
            }

        }
    }
}