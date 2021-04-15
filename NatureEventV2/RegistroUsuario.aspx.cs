using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class RegistroUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void validar_click(object sender, EventArgs e)
        {
            try
            {
                validarContrasenya();
                validarEmail();
                validarDNI();
                validartelefono();

                if ((validarContrasenya() == true) && (validarEmail() == true) && (validarDNI() == true) && (validartelefono() == true))
                {
                    DALUsuario dusuario = new DALUsuario();
                    Usuario usuario = new Usuario();
                    usuario.Nombre = TxtUsuario.Text;
                    usuario.Apellido = TxtApellido.Text;
                    usuario.Email = TxtEmail.Text;
                    usuario.Pwd = TxtContrasenya.Text;
                    usuario.Dni = TxtDNI.Text;
                    usuario.FechaNac = this.Fecha.SelectedDate;
                    usuario.Direccion = TxtDireccion.Text;
                    usuario.Telefono = (Int32.Parse(TxtTelefono.Text));

                    dusuario.InsertarUsuarios(usuario);
                    Server.Transfer("About.aspx");
                }
            }
            catch (Exception ex)
            {

            }
                
        }
        public bool validarContrasenya()
        {
            try
            {
                int numero = 0;
                int minuscula = 0;
                int mayuscula = 0;
                int especial = 0;
                if (TxtContrasenya.Text.Length > 8 && TxtContrasenya.Text.Length < 16)
                {
                    for (int i = 0; i < TxtContrasenya.Text.Length; i++)
                    {
                        char letra = TxtContrasenya.Text[i];

                        if (char.IsUpper(letra))
                            mayuscula++;
                        if (char.IsLower(letra))
                            minuscula++;
                        if (char.IsNumber(letra))
                            numero++;
                        if (char.IsSeparator(letra) || char.IsSymbol(letra) || char.IsPunctuation(letra))
                            especial++;
                    }
                    if (((minuscula > 0) && (mayuscula > 0) && (numero > 0) && (especial > 0)) && (TxtContrasenya.Text == TxtContrasenya2.Text))
                    {
                        LblMensaje.Text = "valido";
                        return true;
                    }
                    else
                    {
                        LblMensaje.Text = "invalido";
                        return false;
                    }
                }
                else
                {
                    LblMensaje.Text = "invalido";
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool validarEmail ()
        {
            try
            {
                String expresion;
                DALUsuario usuario = new DALUsuario();
                expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
                if (Regex.IsMatch(TxtEmail.Text, expresion))
                {
                    if (Regex.Replace(TxtEmail.Text, expresion, String.Empty).Length == 0)
                    {
                        LblEmail.Text = "valido";
                        if (usuario.ValidarExistenciaEmail(TxtEmail.Text) == null)
                        {
                            LblEmail.Text = "valido";
                            return true;
                        }
                        else
                        {
                            LblEmail.Text = "invalido";
                            return false;
                        }
                    }
                    else
                    {
                        LblEmail.Text = "invalido";
                        return false;
                    }

                }
                else
                {
                    LblEmail.Text = "invalido";
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool validarDNI()
        {
            try
            {
                var dni = Convert.ToString(TxtDNI.Text);

                if (String.IsNullOrEmpty(dni))
                {
                    LblDNI.Text = "invalido";
                    return false;
                }

                if (!Regex.IsMatch(dni, "/^[0-9]{8}[A-Z]$/i"))
                {
                    LblDNI.Text = "valido";
                    return true;
                }
                else
                {
                    LblDNI.Text = "invalido";
                    return false;
                }
            }
            catch (Exception ex)
            {
                return   false;
            }
        }
        public bool validartelefono()
        {
            try {
                if (TxtTelefono.Text.All(char.IsDigit))
                {
                    if (TxtTelefono.Text.Length == 9)
                    {
                        LblTelefono.Text = "valido";
                        return true;

                    }
                    else
                    {
                        LblTelefono.Text = "invalido";
                        return false;
                    }
                }
                else
                {
                    LblTelefono.Text = "invalido";
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
       
    
}