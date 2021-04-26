using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class HIstorialEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] == null)
            {
                Server.Transfer("Default.aspx");
            }
            else
            {
                DALEmpresa dalEmpresa = new DALEmpresa();
                DALEvento dalEvento = new DALEvento();
                Empresa empresa = new Empresa();
                List<Evento> eventos = new List<Evento>();
                ContentArea.FindControl("BodyContent");

                if ((int)Session["user"] == 1)
                {
                    eventos = dalEvento.SelectListEventosByIdEmpresa((int)Session["idUser"]);
                    foreach (Evento evento in eventos)
                    {
                        ContentArea.Controls.Add(new LiteralControl("<div style='margin:auto; width:50%; background-color:#D4EDE6; overflow: auto;' class='col-md-6 col-lg-6 position-static p-4 mb-3'>"));
                        ContentArea.Controls.Add(new LiteralControl("<img src='https://picsum.photos/100' class='img-radius' style='float:left; margin-right:10%;'><h5>" + evento.Nombre + "</h5><p>" + evento.Descripcion.ToString()));

                        ContentArea.Controls.Add(new LiteralControl("</p><a href='PaginaEvento.aspx?idEvento=" + evento.IdEvento + "' runat='server'>Click par la pagina principal</a></div>"));
                    }
                }

                if ((int)Session["user"] == 0)
                {
                    eventos = dalEvento.SelectListEventosByIdUsuario((int)Session["idUser"]);
                    foreach (Evento evento in eventos)
                    {
                        ContentArea.Controls.Add(new LiteralControl("<div style='border-style:solid; border-width:thin; border-radius: 25px; margin:auto; width:50%; background-color:white;' class='col-md-6 col-lg-6 position-static p-4 mb-3'><h5>" + evento.Nombre + "</h5><p>" + evento.Descripcion.ToString() + "</p>"));

                        ContentArea.Controls.Add(new LiteralControl("<a href='PaginaEvento.aspx?idEvento=" + evento.IdEvento + "' runat='server'>Click par la pagina principal</a></div>"));
                    }
                }
            }
           
        }
    }
}