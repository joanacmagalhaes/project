using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;


namespace NatureEventV2
{
    public partial class Asistencia : System.Web.UI.Page
    {
        private CheckBoxList Cbx;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            
            if (ContentArea.FindControl("asistenciachecklist") == null)
            {
                ContentArea.Controls.Clear();
                DALEvento dalEven = new DALEvento();
                List<Usuario> usuarios = new List<Usuario>();
                usuarios = dalEven.selectUsuariByIdEvento((int)Application["IdEven"]);
                
                CheckBoxList checkList = new CheckBoxList();
                checkList.ID = "asistenciachecklist";


                foreach (Usuario usu in usuarios)
                {
                    ListItem li = new ListItem();
                    li.Text = usu.Nombre + " " + usu.Apellido;
                    li.Value = (usu.IdUsuario).ToString();
                    checkList.Items.Add(li);
                    ContentArea.Controls.Add(checkList);
                 }
            }
        }

        public void ButtonAsistencia_Click (object sender, EventArgs e)
        {
            DALAsistencia dalasis = new DALAsistencia();
            this.Cbx = (CheckBoxList)ContentArea.FindControl("asistenciachecklist");
            foreach (ListItem usuario in Cbx.Items)
            {
                asistencia asis = new asistencia();
                asis.RIdUsuario = Convert.ToInt32(usuario.Value);
                asis.RIdEvento = (int)Application["IdEven"];
                if (usuario.Selected) { asis.Asistir = 1;}
                else { asis.Asistir = 0; }
                dalasis.UpdateAsistenciaByIdEvento(asis);
                
            }

        }
    }
}