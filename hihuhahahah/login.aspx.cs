using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace hihuhahahah
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Lable4.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FormsAuthentication.Authenticate(username.Text, password.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(username.Text, true);
                Response.Redirect("home.aspx");
            }
            else
            {
                Lable4.Visible = true;
            }
        }
    }
}