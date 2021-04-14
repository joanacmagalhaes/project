using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;

namespace NatureEventV2
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<Evento> GetEventos()
        {
           
            DALEvento dALEvento = new DALEvento();
            List<Evento> eventos = dALEvento.SelectListEvento();
            return eventos;
        }
    }
}