using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class _Default : Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["idUser"] != null) HiddenFieldSessionID.Value = Session["idUser"].ToString();


            List<Empresa> empresas = GetEmpresas();
            this.FilterListOrg.Items.Clear(); 
            this.FilterListOrg.Items.Add(new ListItem("Selecciona Organización", "0"));
            foreach (Empresa emp in empresas)
            {
                FilterListOrg.Items.Add(new ListItem(emp.Nombre,emp.IdEmpresa.ToString()));
            }


        }

        private List<Empresa> GetEmpresas()
        {
            DALEmpresa dALEmpresa = new DALEmpresa();
            List<Empresa> empresas = dALEmpresa.SelectListEmpresa();
            return empresas;
        }

        [WebMethod]
        public static List<Evento> GetEventos()
        {
           
            DALEvento dALEvento = new DALEvento();
            List<Evento> eventos = dALEvento.SelectListEvento();
            return eventos;
        }

        [WebMethod]
        public static List<Evento> GetEventosFilter(int idC, string dStart)
        {
            DALEvento dALEvento = new DALEvento();
            List<Evento> eventos = dALEvento.SelectListEventoByCompanyAndStartDate(idC,dStart);
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