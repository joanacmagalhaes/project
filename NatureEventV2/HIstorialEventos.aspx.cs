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

            if ((int)Session["user"] == 1)
            {
                eventos = dalEvento.SelectListEventosByIdEmpresa((int)Session["idUser"]);
                foreach (Evento evento in eventos)
                {
                    listBoxEventosEmpresa1.Items.Add(evento.ToString());
                }
            }

            if ((int)Session["user"] == 0)
            {
                eventos = dalEvento.SelectListEventosByIdUsuario((int)Session["idUser"]);
                foreach (Evento evento in eventos)
                {
                    
                 //   var p = new HtmlGenericControl("p") { InnerText = evento.Nombre.ToString() + " " + evento.FechaInicio };
                 //   ContentArea.Controls.Add(p);
                      Application[evento.Nombre] = evento.IdEvento;
                      ContentArea.Controls.Add(new LiteralControl("<div>"));
                     
                       var p = new HtmlGenericControl("p") { InnerText = evento.Nombre.ToString() + " " + evento.FechaInicio };
                       ContentArea.Controls.Add(p);
                       ContentArea.Controls.Add(new LiteralControl("<a href='evento.aspx?idEvento="+evento.IdEvento+" runat='server' id='"+evento.IdEvento+"'>Click par la pagina principal</a></div>"));
                    

                    // listBoxEventosEmpresa1.Items.Add(evento.ToString());
                }
            }
        }
        public void saberId(int id)
        {
            


        }
    }
}