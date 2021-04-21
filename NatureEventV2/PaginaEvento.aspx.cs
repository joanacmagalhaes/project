using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class PaginaEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Application["IdEven"] = Request.QueryString["idEvento"];
            int prueba =Convert.ToInt32(Request.QueryString["idEvento"]);
            Application["IdEven"] = prueba;
            DALEvento dalEven = new DALEvento();
            Evento even = new Evento();
            even = dalEven.SelectEventoById(prueba);
            LabelNombreEvento.Text = even.Nombre;

        }
    }
}