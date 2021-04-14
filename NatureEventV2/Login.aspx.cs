using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            errorEmail.Visible = false;
            errorPassword.Visible = false;
            errorLogin.Visible = false;
           

            if (InputEmail == null || InputEmail.Text == "")
            {
                errorEmail.Visible = true;
            }
            else if (InputPassword.Text == null || InputPassword.Text == "")
            {
                errorPassword.Visible = true;
            }
            else if (LoginEmpresaUsuario.SelectedIndex == 0)
            {
                DALUsuario user = new DALUsuario();
                Session["idUser"] = user.comprobarLoginUsuario(InputEmail.Text, InputPassword.Text);
                if (Session["idUser"] == null)
                {
                    errorLogin.Visible = true;
                }
                else
                {
                    Server.Transfer("Default.aspx");
                }
                
            }

        }
    }
}