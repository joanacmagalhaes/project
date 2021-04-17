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
            if (Session["idUser"] != null) HiddenFieldSessionID.Value = Session["idUser"].ToString();

        }

        [WebMethod]
        public static List<Evento> GetEventos()
        {
           
            DALEvento dALEvento = new DALEvento();
            List<Evento> eventos = dALEvento.SelectListEvento();
            return eventos;
        }

        [WebMethod]
        public static int UnirseEvento(int eid, int uid)
        {
            DALEvento dALEvento = new DALEvento();
            return dALEvento.addUserEvento(eid, uid);

        }
        
    }
}