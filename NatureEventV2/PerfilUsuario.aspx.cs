using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class PerfilUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            string nombre = LabelNombre.Text;
            string apellidos = LabelApellidos.Text;
            string email = LabelEmail.Text;
            string telefono = LabelTelefono.Text;
            string direccion = LabelDireccion.Text;
            string dni = LabelDni.Text;

            if (LabelNombre.Visible)
            {
                LabelNombre.Visible = false;
                LabelApellidos.Visible = false;
                LabelEmail.Visible = false;
                LabelTelefono.Visible = false;
                LabelDireccion.Visible = false;
                LabelDni.Visible = false;

                TextBoxNombre.Text = LabelNombre.Text;
                TextBoxNombre.Visible = true;

                TextBoxApellidos.Text = LabelApellidos.Text;
                TextBoxApellidos.Visible = true;

                TextBoxEmail.Text = LabelEmail.Text;
                TextBoxEmail.Visible = true;

                TextBoxTelefono.Text = LabelTelefono.Text;
                TextBoxTelefono.Visible = true;

                TextBoxDireccion.Text = LabelDireccion.Text;
                TextBoxDireccion.Visible = true;

                TextBoxDni.Text = LabelDni.Text;
                TextBoxDni.Visible = true;
            }
            else {

                TextBoxNombre.Visible = false;
                TextBoxApellidos.Visible = false;
                TextBoxEmail.Visible = false;
                TextBoxTelefono.Visible = false;
                TextBoxDireccion.Visible = false;
                TextBoxDni.Visible = false;

                LabelNombre.Text = TextBoxNombre.Text;
                LabelNombre.Visible = true;

                LabelApellidos.Text = TextBoxApellidos.Text;
                LabelApellidos.Visible = true;

                LabelEmail.Text = TextBoxEmail.Text;
                LabelEmail.Visible = true;

                LabelTelefono.Text = TextBoxTelefono.Text;
                LabelTelefono.Visible = true;

                LabelDireccion.Text = TextBoxDireccion.Text;
                LabelDireccion.Visible = true;

                LabelDni.Text = TextBoxDni.Text;
                LabelDni.Visible = true;
            }
        }
    }
}