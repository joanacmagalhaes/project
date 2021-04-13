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
            validarContrasenya();
            validarEmail();
            validarDNI();

            if((validarContrasenya()==true)&&(validarEmail()==true)&&(validarDNI()==true))
                {
                    
                }

                
        }
        public bool validarContrasenya()
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

        public bool validarEmail ()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(TxtEmail.Text, expresion))
            {
                if (Regex.Replace(TxtEmail.Text, expresion, String.Empty).Length == 0)
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
        public bool validarDNI()
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
    }
       
    
}