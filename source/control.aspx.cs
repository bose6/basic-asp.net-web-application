using System;

namespace webproject
{
    public partial class control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userid"] == null)
            {
                Response.Redirect("web.aspx");
                Setting appsetting = (Setting)Application["appsetting"];
                txt1.Text = appsetting.text1;
                txt2.Text = appsetting.text2;
                dfooter.Text = appsetting.dFooter;
                dheader.Text = appsetting.Header;

            }

        }

        protected void Unnamed9_Click(object sender, EventArgs e)
        {

            Setting appsetting = (Setting)Application["appsetting"];
            appsetting.text1 = txt1.Text;
            appsetting.text2 = txt2.Text;
            appsetting.Header = dheader.Text;
            appsetting.dFooter = dfooter.Text;
            txt1.Text = appsetting.text1;
            txt2.Text = appsetting.text2;
            dfooter.Text = appsetting.dFooter;
            dheader.Text = appsetting.Header;
            manager.Savesettings(Server.MapPath("~/appdata/setting.xml"), appsetting);
            Application["appsetting"] = appsetting;
        }
    }
}