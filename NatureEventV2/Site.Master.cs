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
            linkCrearEvento.Visible = false;

            if (Session["IdUser"]!= null)
            {
                logoutId.Visible = true;
                loginId.Visible = false;

                registroUsuario.Visible = false;
            }
            switch (Session["user"])
            {
                case 0:
                    perfilUsuario.Visible = true;
                    perfilEmpresa.Visible = false;
                    linkCrearEvento.Visible = false;
                    historialEventos.Visible = true;
                    break;
                case 1:
                    perfilUsuario.Visible = false;
                    perfilEmpresa.Visible = true;
                    linkCrearEvento.Visible = true;
                    historialEventos.Visible = true;
                    break;
                default:
                    perfilUsuario.Visible = false;
                    perfilEmpresa.Visible = false;
                    perfilEmpresa.Visible = false;
                    historialEventos.Visible = false;
                    break;


            }
            //if(Session["user"]== (object)0)
            //{
            //    perfilUsuario.Visible = true;
            //    perfilEmpresa.Visible = false;
            //}
            //else if (Session["user"] == (object)1)
            //{ 
            //    perfilUsuario.Visible = false;
            //    perfilEmpresa.Visible = true;
            //}
            //else
            //{
            //    perfilUsuario.Visible = false;
            //    perfilEmpresa.Visible = false;
            //}
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