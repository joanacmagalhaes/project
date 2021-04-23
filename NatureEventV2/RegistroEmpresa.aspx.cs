﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public partial class RegistroEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void validar_empresa_click(object sender, EventArgs e)
        {
            try
            {
                bool contrasenyaValida = validarContrasenya();
                bool dniValido = validarDNI();
                bool emailValido = validarEmail();
                bool telefonoValido = validartelefono();
                bool validarNombre = validarCampos(TxtUsuario);
                bool validarDireccion = validarCampos(TxtDireccion);

                if ((contrasenyaValida) && (emailValido) && (dniValido) && (telefonoValido)&&(validarNombre)&&(validarDireccion))
                {
                    
                    DALEmpresa dempresa = new DALEmpresa();
                    Empresa empresa = new Empresa();
                    empresa.Nombre = TxtUsuario.Text;
                    empresa.Email = TxtEmail.Text;
                    empresa.Pwd = EncriptarPassword(TxtContrasenya.Text);
                    empresa.Cif = TxtCIF.Text;
                    empresa.Direccion = TxtDireccion.Text;
                    empresa.Telefono = (Int32.Parse(TxtTelefono.Text));

                    dempresa.InsertarEmpresa(empresa);
                    Server.Transfer("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error validar_empresa_click:" + ex.Message);

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
                return false;
            }
        }

        public bool validarEmail()
        {
            try
            {
                String expresion;
                DALEmpresa usuario = new DALEmpresa();
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
        public bool validarDNI()
        {
            try
            {
                var dni = Convert.ToString(TxtCIF.Text);

                if (String.IsNullOrEmpty(dni))
                {
                    TxtCIF.BorderColor = System.Drawing.Color.Red;
                    return false;
                }

                if (!Regex.IsMatch(dni, "/^[0-9]{8}[A-Z]$/i"))
                {
                    return true;
                }
                else
                {
                    TxtCIF.BorderColor = System.Drawing.Color.Red;
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
                if (TxtTelefono.Text.All(char.IsDigit))
                {
                    if (TxtTelefono.Text.Length == 9)
                    {
                        return true;

                    }
                    else
                    {
                        TxtTelefono.BorderColor = System.Drawing.Color.Red;
                        return false;
                    }
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
        public bool validarCampos(TextBox TxtUsuario)
        {
            if ((TxtUsuario.Text == ""))
            {
                TxtUsuario.BorderColor = System.Drawing.Color.Red;
                return false;
            }

            else return true;
        }

        public string EncriptarPassword(string password)
        {
            string result = string.Empty;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(password);
            result = Convert.ToBase64String(encrypted);
            return result;
        }

        public string DesencriptarPassword(string password)
        {
            string result = string.Empty;
            byte[] decrypted = Convert.FromBase64String(password);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decrypted);
            return result;
        }
    }
}