using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            logoutId.Visible = false;
            if (Session["IdUser"]!= null)
            {
                logoutId.Visible = true;
                loginId.Visible = false;
            }
        }

        protected void logoutId_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Response.Cookies.Clear();
            Response.Redirect("Default.aspx");
            logoutId.Visible = false;
            loginId.Visible = true;
        }
    }
}