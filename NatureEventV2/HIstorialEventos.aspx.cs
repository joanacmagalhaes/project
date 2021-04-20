using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
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

            eventos = dalEvento.SelectListEventosByIdEmpresa((int)Session["idUser"]);

            foreach (Evento evento in eventos)
            {
                listBoxEventosEmpresa1.Items.Add(evento.ToString());
            }

        }
    }
}