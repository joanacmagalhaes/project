using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class PerfilEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DALEmpresa dalEmpresa = new DALEmpresa();
            DALEvento dalEvento = new DALEvento();
            Empresa empresa = new Empresa();
            List<Evento> eventos = new List<Evento>();

            empresa = dalEmpresa.SelectEmpresaById((int)Session["idUser"]);
            eventos = dalEvento.SelectListEventosByIdEmpresa((int)Session["idUser"]);

            LabelNombreEmpresa.Text = empresa.Nombre;
            LabelEmail.Text = empresa.Email;
            LabelTelefono.Text = empresa.Telefono.ToString();
            LabelDireccion.Text = empresa.Direccion;
            LabelCif.Text = empresa.Cif;

            ////foreach (Evento evento in eventos) {
            ////    listBoxEventosEmpresa1.Items.Add(evento.ToString());
            //}
        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            DALEmpresa dalEmpresa = new DALEmpresa();
            Empresa empresa = new Empresa();


            if (LabelNombreEmpresa.Visible)
            {
                LabelNombreEmpresa.Visible = false;
                LabelEmail.Visible = false;
                LabelTelefono.Visible = false;
                LabelDireccion.Visible = false;
                LabelCif.Visible = false;

                ButtonEditar.Text = "Guardar";

                TextBoxNombreEmpresa.Text = LabelNombreEmpresa.Text;
                TextBoxNombreEmpresa.Visible = true;

                TextBoxEmail.Text = LabelEmail.Text;
                TextBoxEmail.Visible = true;

                TextBoxTelefono.Text = LabelTelefono.Text;
                TextBoxTelefono.Visible = true;

                TextBoxDireccion.Text = LabelDireccion.Text;
                TextBoxDireccion.Visible = true;

            }
            else
            {

                TextBoxNombreEmpresa.Visible = false;
                TextBoxEmail.Visible = false;
                TextBoxTelefono.Visible = false;
                TextBoxDireccion.Visible = false;

                ButtonEditar.Text = "Editar";

                LabelNombreEmpresa.Text = TextBoxNombreEmpresa.Text;
                LabelNombreEmpresa.Visible = true;

                LabelEmail.Text = TextBoxEmail.Text;
                LabelEmail.Visible = true;

                LabelTelefono.Text = TextBoxTelefono.Text;
                LabelTelefono.Visible = true;

                LabelDireccion.Text = TextBoxDireccion.Text;
                LabelDireccion.Visible = true;

                LabelCif.Visible = true;

                empresa.IdEmpresa = Convert.ToInt32(Session["idUser"]);
                empresa.Nombre = LabelNombreEmpresa.Text;
                empresa.Email = LabelEmail.Text;
                empresa.Direccion = LabelDireccion.Text;
                empresa.Telefono = Convert.ToInt32(LabelTelefono.Text);

                dalEmpresa.UpdateEmpresa(empresa);
            }
        }
    }
}