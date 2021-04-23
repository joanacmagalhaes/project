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
            Application["IdEven"] = Convert.ToInt32(Request.QueryString["idEvento"]);

            switch (Session["user"])
            {
                case 1:
                    ButtonEditar.Visible = true;
                    ButAsistencia.Visible = true;
                    break;
            }
            DALEvento dalEven = new DALEvento();
            Evento even = new Evento();
            even = dalEven.SelectEventoById((int)Application["IdEven"]);
            LabelNombreEvento.Text = even.Nombre;
            LabelDescripcion.Text = even.Descripcion;
            LabelDirecionEvento.Text = even.Direccion;
            LabelFechaFinal.Text = even.FechaFinal;
            LabelFechaInicio.Text = even.FechaInicio;

        }

        protected void ButtonEditar_Click(object sender, EventArgs e)
        {
            Evento even = new Evento();
            DALEvento dalEven = new DALEvento();
            if (LabelNombreEvento.Visible)
            {
                LabelNombreEvento.Visible = false;
                LabelDescripcion.Visible = false;
                LabelDirecionEvento.Visible = false;
                LabelFechaInicio.Visible = false;
                LabelFechaFinal.Visible = false;

                ButtonEditar.Text = "Guardar";

                TextBoxNombreEvento.Text = LabelNombreEvento.Text;
                TextBoxNombreEvento.Visible = true;

                TextDescripcion.Text = LabelDirecionEvento.Text;
                TextDescripcion.Visible = true;

                TextDirecionEvento.Text = LabelDirecionEvento.Text;
                TextDirecionEvento.Visible = true;

                TextFechaFinal.Text = LabelFechaFinal.Text;
                TextFechaFinal.Visible = true;

                TextFechaInicio.Text = LabelFechaInicio.Text;
                TextFechaInicio.Visible = true;
            }
            else
            {

                TextBoxNombreEvento.Visible = false;
                TextDescripcion.Visible = false;
                TextDirecionEvento.Visible = false;
                TextFechaFinal.Visible = false;
                TextFechaInicio.Visible = false;
                ButtonEditar.Text = "Editar";

                LabelNombreEvento.Text = TextBoxNombreEvento.Text;
                LabelNombreEvento.Visible = true;

                LabelDescripcion.Text = TextDescripcion.Text;
                LabelDescripcion.Visible = true;

                LabelDirecionEvento.Text = TextDirecionEvento.Text;
                LabelDirecionEvento.Visible = true;

                LabelFechaInicio.Text = TextFechaInicio.Text;
                LabelFechaInicio.Visible = true;

                LabelFechaFinal.Text = TextFechaFinal.Text;
                LabelFechaFinal.Visible = true;

                even.IdEvento = Convert.ToInt32(Application["idEven"]);
                even.Nombre = LabelNombreEvento.Text;
                even.Descripcion = LabelDescripcion.Text;
                even.Direccion = LabelDirecionEvento.Text;
                even.FechaFinal = LabelFechaFinal.Text;
                even.FechaInicio = LabelFechaInicio.Text;

                dalEven.UpdateEventobyId(even);
            }
        }
    }
}