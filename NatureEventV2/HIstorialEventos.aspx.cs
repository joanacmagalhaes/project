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
                    ContentArea.Controls.Add(new LiteralControl("<div>"));

                    //var p = new HtmlGenericControl("p") { InnerText = evento.Nombre.ToString() + " " + evento.FechaInicio };
                    //ContentArea.Controls.Add(p);
                    ContentArea.Controls.Add(new LiteralControl("<div style='border-style:solid; border-width:thin; border-radius: 25px; margin:auto; width:50%; background-color:white;' class='col-md-6 col-lg-6 position-static p-4 mb-3'><h5>" + evento.Nombre + "</h5><p>" + evento.Descripcion.ToString() + "</p>"));

                    ContentArea.Controls.Add(new LiteralControl("<a href='PaginaEvento.aspx?idEvento=" + evento.IdEvento + "' runat='server'>Click par la pagina principal</a></div>"));
                }
            }

            if ((int)Session["user"] == 0)
            {
                eventos = dalEvento.SelectListEventosByIdUsuario((int)Session["idUser"]);
                foreach (Evento evento in eventos)
                {
                    
                 //   var p = new HtmlGenericControl("p") { InnerText = evento.Nombre.ToString() + " " + evento.FechaInicio };
                 //   ContentArea.Controls.Add(p);
                      ContentArea.Controls.Add(new LiteralControl("<div style='border-style:solid; border-width:thin; border-radius: 25px; margin:auto; width:50%; background-color:white;' class='col-md-6 col-lg-6 position-static p-4 mb-3'><h5>" + evento.Nombre + "</h5><p>" + evento.Descripcion.ToString() +"</p>"));
  
                      ContentArea.Controls.Add(new LiteralControl("<a href='PaginaEvento.aspx?idEvento="+evento.IdEvento+ "' runat='server'>Click par la pagina principal</a></div>"));


                    // listBoxEventosEmpresa1.Items.Add(evento.ToString());
    }
            }
        }
        public void saberId(int id)
        {
            


        }
    }
}