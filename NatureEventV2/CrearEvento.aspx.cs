using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class CrearEvento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCrearEvento_Click(object sender, EventArgs e)
        {
            DALEvento dalEvento = new DALEvento();
            Evento evento = new Evento();

            //(int)Session["idUser"]
            evento.RIdEmpresa = 1;
            evento.Nombre = TextBoxNombreActividad.Text;
            evento.Puntos = Convert.ToInt32(TextBoxPuntos.Text);
            evento.Descripcion = TextBoxDescripcion.Text;
            evento.FechaInicio = Convert.ToString(CalendarFechaInicio.Text) + " " + HoraInicio.Text;
            evento.FechaFinal = Convert.ToString(CalendarFechaFinal.Text) + " " + HoraFinal.Text; 
            evento.Direccion = TextBoxDireccion.Text;
            evento.PosX = Convert.ToDouble(TextBoxPosX.Value.Replace('.',','));
            evento.PosY = Convert.ToDouble(TextBoxPosY.Value.Replace('.', ','));

            dalEvento.InsertarEvento(evento);
        }
    }
}