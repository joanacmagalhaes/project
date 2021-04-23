using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
            bool validarNombre = validarcampos(TextBoxNombreActividad);
            bool validarDescripcion = validarcampos(TextBoxDescripcion);
            bool validarPuntos = validarcampos(TextBoxPuntos);
            bool validarDireccion = validarcampos(TextBoxDireccion);
            bool validarCalendarioInicio = validarcampos(CalendarFechaInicio);
            bool validarCalendarioFinal = validarcampos(CalendarFechaFinal);
            bool validarHoraInicio = validarcampos(HoraInicio);
            bool validarHoraFinal = validarcampos(HoraFinal);
            bool validarPosicionX = validarPosiciones(TextBoxPosX.Value);
            bool validarPosicionY = validarPosiciones(TextBoxPosX.Value);
            if ((validarNombre) && (validarDescripcion) && (validarPuntos) && (validarDireccion) && (validarCalendarioInicio) && (validarCalendarioFinal) && (validarHoraFinal) && (validarHoraInicio) && (validarPosicionX) && (validarPosicionY))
            {
                evento.RIdEmpresa = (int)Session["idUser"];
                evento.Nombre = TextBoxNombreActividad.Text;
                evento.Puntos = Convert.ToInt32(TextBoxPuntos.Text);
                evento.Descripcion = TextBoxDescripcion.Text;
                evento.FechaInicio = Convert.ToString(CalendarFechaInicio.Text) + " " + HoraInicio.Text;
                evento.FechaFinal = Convert.ToString(CalendarFechaFinal.Text) + " " + HoraFinal.Text;
                evento.Direccion = TextBoxDireccion.Text;
                evento.PosX = Convert.ToDouble(TextBoxPosX.Value.Replace('.', ','));
                evento.PosY = Convert.ToDouble(TextBoxPosY.Value.Replace('.', ','));


                try
                {
                    this.TextMensaje.Visible = true;
                    dalEvento.InsertarEvento(evento);
                    this.TextMensaje.Text = "<div class='alert alert-success alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Exito!</strong> Se ha enviado el mensaje a NatureEvent.</div>";
                }
                catch (Exception)
                {
                    this.TextMensaje.Text = "<div class='alert alert-warning alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Fallo!</strong> Ha ocurrido un error en la conexión del servidor, prueba más tarde.</div>";

                }
            }

        }

        public bool validarcampos(TextBox campo)
        {
            if ((campo.Text == "") || (campo.Text == null))
            {
                campo.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                return true;
            }

        }
        public bool validarPosiciones(string posicion)
        {
            if ((posicion == "") || (posicion == null))
            {
                this.TextMensaje.Visible = true;
                this.TextMensaje.Text = "<div class='alert alert-danger  alert-dismissible'><a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a> <strong>Fallo!</strong> Tienes que hacer clic en el mapa para indicar donde se llevará a cabo el evento.</div>";
                return false;
            }
            else
            {
                return true;
            }



        }

    }
} 

