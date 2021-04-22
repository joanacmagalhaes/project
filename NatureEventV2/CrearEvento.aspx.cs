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

            evento.RIdEmpresa = int.Parse(Session["idUser"].ToString());
            evento.Nombre = TextBoxNombreActividad.Text;
            evento.Puntos = Convert.ToInt32(TextBoxPuntos.Text);
            evento.Descripcion = TextBoxDescripcion.Text;
            evento.FechaInicio = Convert.ToString(CalendarFechaInicio.Text) + " " + HoraInicio.Text;
            evento.FechaFinal = Convert.ToString(CalendarFechaFinal.Text) + " " + HoraFinal.Text; 
            evento.Direccion = TextBoxDireccion.Text;
            evento.PosX = Convert.ToDouble(TextBoxPosX.Value.Replace('.',','));
            evento.PosY = Convert.ToDouble(TextBoxPosY.Value.Replace('.', ','));
            
            try
            {
                this.TextMensaje.Visible = true;
                dalEvento.InsertarEvento(evento);
                this.TextMensaje.Text = "<div class='alert alert-success alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Exito!</strong> Se ha enviado el mensaje a NatureEvent.</div>";
            }
            catch (Exception)
            {
                this.TextMensaje.Text =  "<div class='alert alert-warning alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Fallo!</strong> Ha ocurrido un error en la conexión del servidor, prueba más tarde.</div>";

            }
        }
    }
}