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
                bool contrasenyaValida = validarContrasenya();
                bool dniValido = validarNIF(TxtDNI.Text);
                bool emailValido = validarEmail();
                bool telefonoValido = validartelefono();
                bool validarNombre = validarCampos(TxtUsuario);
                bool validarApellido = validarCampos(TxtApellido);
                bool validarDireccion = validarCampos(TxtDireccion);

                if (dniValido == false)
                    TxtDNI.BorderColor = System.Drawing.Color.Red;

                if ((contrasenyaValida) && (emailValido) && (dniValido) && (telefonoValido)&&(validarNombre)&&(validarApellido)&&(this.TxtFecha.Text!=""))
                {
                    DALUsuario dusuario = new DALUsuario();
                    Usuario usuario = new Usuario();
                    usuario.Nombre = TxtUsuario.Text;
                    usuario.Apellido = TxtApellido.Text;
                    usuario.Email = TxtEmail.Text;
                    usuario.Pwd = TxtContrasenya.Text;
                    usuario.Dni = TxtDNI.Text;
                    usuario.FechaNac = Convert.ToDateTime(TxtFecha.Text);
                    usuario.Direccion = TxtDireccion.Text;
                    usuario.Telefono = (Int32.Parse(TxtTelefono.Text));

                    dusuario.InsertarUsuarios(usuario);
                    Server.Transfer("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error validar_click:" + ex.Message);
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
                        return true;
                    }
                    else
                    {
                        TxtContrasenya.BorderColor = System.Drawing.Color.Red;
                        return false;
                    }
                }
                else
                {
                    TxtContrasenya.BorderColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            catch (Exception)
            {
                TxtContrasenya.BorderColor = System.Drawing.Color.Red;
                return false;
            }
        }

        public bool validarEmail()
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
                        if (usuario.ValidarExistenciaEmail(TxtEmail.Text) == null)
                        {
                            return true;
                        }
                        else
                        {

                            TxtEmail.BorderColor = System.Drawing.Color.Red;
                            return false;
                        }
                    }
                    else
                    {
                        TxtEmail.BorderColor = System.Drawing.Color.Red;
                        return false;
                    }

                }
                else
                {
                    TxtEmail.BorderColor = System.Drawing.Color.Red;
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
       
        public bool validartelefono()
        {
            try
            {
                if (TxtTelefono.Text.All(char.IsDigit)&& (TxtTelefono.Text.Length == 9))
                {
                        return true;
                }
                else
                {
                    TxtTelefono.BorderColor = System.Drawing.Color.Red;
                    return false;
                }


            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool validarCampos (TextBox TxtUsuario)
        {
            if ((TxtUsuario.Text==""))
            {
                TxtUsuario.BorderColor = System.Drawing.Color.Red;
                return false;
            }

            else return true;
        }
        public static Boolean valida_NIFCIFNIE(string data)
        {
            if (String.IsNullOrEmpty(data) || data.Length < 8)
                return false;

            var initialLetter = data.Substring(0, 1).ToUpper();
            if (Char.IsLetter(data, 0))
            {
                switch (initialLetter)
                {
                    case "X":
                        data = "0" + data.Substring(1, data.Length - 1);
                        return validarNIF(data);
                    case "Y":
                        data = "1" + data.Substring(1, data.Length - 1);
                        return validarNIF(data);
                    case "Z":
                        data = "2" + data.Substring(1, data.Length - 1);
                        return validarNIF(data);
                    default:
                        if (new Regex("[A-Za-z][0-9]{7}[A-Za-z0-9]{1}$").Match(data).Success)
                            return validadCIF(data);
                        break;
                }
            }
            else if (Char.IsLetter(data, data.Length - 1))
            {
                if (new Regex("[0-9]{8}[A-Za-z]").Match(data).Success || new Regex("[0-9]{7}[A-Za-z]").Match(data).Success)
                    return validarNIF(data);
            }
            return false;
        }
        private static bool validarNIF(string data)
        {
            if (data == String.Empty)
                return false;
            try
            {
                String letra;
                letra = data.Substring(data.Length - 1, 1);
                data = data.Substring(0, data.Length - 1);
                int nifNum = int.Parse(data);
                int resto = nifNum % 23;
                string tmp = getLetra(resto);
                if (tmp.ToLower() != letra.ToLower())
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }
        private static string getLetra(int id)
        {
            Dictionary<int, String> letras = new Dictionary<int, string>()
            {
                { 0, "T"}, {1, "R" }, {2, "W" }, {3, "A" }, {4, "G"}, {5, "M" }, {6, "Y" }, {7, "F" }, {8, "P" }, {9, "D" }, {10, "X" }, {11, "B" }, {12, "N" }, {13, "J" }, {14, "Z" }, {15, "S" }, {16, "Q" }, {17, "V" }, {18, "H" }, {19, "L" }, {20, "C" }, {21, "K" }, {22, "E" } };


            return letras[id];
        }
        private static bool validadCIF(string data)
        {
            try
            {
                int pares = 0;
                int impares = 0;
                int suma;
                string ultima;
                int unumero;
                string[] uletra = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "0" };
                string[] fletra = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                int[] fletra1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                string xxx;

                data = data.ToUpper();

                ultima = data.Substring(8, 1);

                int cont = 1;
                for (cont = 1; cont < 7; cont++)
                {
                    xxx = (2 * int.Parse(data.Substring(cont++, 1))) + "0";
                    impares += int.Parse(xxx.ToString().Substring(0, 1)) + int.Parse(xxx.ToString().Substring(1, 1));
                    pares += int.Parse(data.Substring(cont, 1));
                }

                xxx = (2 * int.Parse(data.Substring(cont, 1))) + "0";
                impares += int.Parse(xxx.Substring(0, 1)) + int.Parse(xxx.Substring(1, 1));

                suma = pares + impares;
                unumero = int.Parse(suma.ToString().Substring(suma.ToString().Length - 1, 1));
                unumero = 10 - unumero;
                if (unumero == 10) unumero = 0;

                if ((ultima == unumero.ToString()) || (ultima == uletra[unumero - 1]))
                    return true;
                else
                    return false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }


}