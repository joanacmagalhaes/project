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
            InputPassword.BorderColor = System.Drawing.Color.Black;
            InputEmail.BorderColor = System.Drawing.Color.Black;


            if (InputEmail == null || InputEmail.Text == "")
            {
                errorEmail.Visible = true;
                insertEmail.Visible = false;
                InputEmail.BorderColor = System.Drawing.Color.Red;

            }
            else if (InputPassword.Text == null || InputPassword.Text == "")
            {
                errorPassword.Visible = true;
                insertPass.Visible = false;
                InputPassword.BorderColor = System.Drawing.Color.Red;
            }
            else
            {
                DALUsuario user = new DALUsuario();
                //Console.WriteLine(EncriptarPassword(InputPassword.Text));
                Session["idUser"] = user.comprobarLoginUsuario(InputEmail.Text, EncriptarPassword(InputPassword.Text), LoginEmpresaUsuario.SelectedIndex);
                if (Session["idUser"] == null)
                {
                    
                    errorLogin.Visible = true;
                    errorLogin.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                  Session["user"] = LoginEmpresaUsuario.SelectedIndex;
                  Server.Transfer("Default.aspx");
                }
                
            }

        }

        public string EncriptarPassword(string password)
        {
            string result = string.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encrypted);
            return result;
        }

        public string DesencriptarPassword(string password)
        {
            string result = string.Empty;
            byte[] decrypted = Convert.FromBase64String(password);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decrypted);
            return result;
        }
    }
}