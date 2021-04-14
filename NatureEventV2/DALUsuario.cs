using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NatureEventV2
{
    public class DALUsuario
    {

        DbConnect con;

        public DALUsuario()
        {
            con = new DbConnect();
        }

        public Usuario SelectUsuarioById(int? id)
        {
            Usuario usuario = new Usuario();

            try
            {
                string sql = "SELECT * FROM Usuario WHERE IdUsuario = @pId";
                SqlCommand cmd = new SqlCommand(sql, con.MiCnx);
                SqlParameter pId = new SqlParameter("@pId", id);
                cmd.Parameters.Add(pId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario.IdUsuario = (int)dr["IdUsuario"];
                    usuario.Nombre = (string)DbConnect.NullFromDb(dr["Nombre"]);
                    usuario.Apellido = (string)DbConnect.NullFromDb(dr["Apellido"]);
                    usuario.Email = (string)DbConnect.NullFromDb(dr["Email"]);
                    usuario.Pwd = (string)DbConnect.NullFromDb(dr["PWD"]);
                    usuario.Dni = (string)DbConnect.NullFromDb(dr["DNI"]);
                    usuario.FechaNac = (DateTime?)DbConnect.NullFromDb(dr["FechaNac"]);
                    usuario.Direccion = (string)DbConnect.NullFromDb(dr["Direccion"]);
                    usuario.Telefono = (int?)DbConnect.NullFromDb(dr["Telephone"]);
                    usuario.Puntos = (int?)DbConnect.NullFromDb(dr["Puntos"]);

                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error en Insert: " + ex.Message);
            }

            return usuario;
        }
        public string ValidarExistenciaEmail(string email)
        {
            Usuario usuario = new Usuario();
            string sql = "SELECT * FROM Usuario WHERE IdUsuario = @pEmail";
            SqlCommand cmd = new SqlCommand(sql, con.MiCnx);
            SqlParameter pId = new SqlParameter("@pEmail", email);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuario.Email = (string)DbConnect.NullFromDb(dr["Email"]);
            }
            return usuario.Email;
        }
        public void InsertarUsuarios()
        {



        }

        public int? comprobarLoginUsuario(string email, string password)
        {
            try
            {
                DbConnect db = new DbConnect();
                string sql = "SELECT IdUsuario FROM USUARIO WHERE EMAIL = @pEmail AND PWD = @pPassword";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pPassword = new SqlParameter("@pPassword", System.Data.SqlDbType.NVarChar, 200);
                pEmail.Value = email;
                pPassword.Value = password;
                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pPassword);

                int? returnValue = (int)cmd.ExecuteScalar();
                if (returnValue==null)
                {
                    //errorLogin.Visible = true;
                    return null;
                }
                else
                {
                    
                    return returnValue;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void UpdateUsuario(Usuario user)
        {
            try
            {
                string sql = @"UPDATE Usuario 
                           SET Nombre = @pNombre, Apellido = @pApellidos, Email = @pEmail, Direccion = @pDireccion, Telephone = @pTelefono
                           WHERE IdUsuario = @pIdUsuario";
                SqlCommand cmd = new SqlCommand(sql, con.MiCnx);

                cmd.Parameters.Add(CreateParameter("@pIdUsuario", System.Data.SqlDbType.Int, 0, user.IdUsuario));
                cmd.Parameters.Add(CreateParameter("@pNombre", System.Data.SqlDbType.NVarChar, 30, user.Nombre));
                cmd.Parameters.Add(CreateParameter("@pApellidos", System.Data.SqlDbType.NVarChar, 75, user.Apellido));
                cmd.Parameters.Add(CreateParameter("@pEmail", System.Data.SqlDbType.NVarChar, 50, user.Email));
                cmd.Parameters.Add(CreateParameter("@pDireccion", System.Data.SqlDbType.NVarChar, 100, user.Direccion));
                cmd.Parameters.Add(CreateParameter("@pTelefono", System.Data.SqlDbType.Int, 0, user.Telefono));
                

                cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Ha habido un error a la hora de hacer el UPDATE:\n" + ex.Message );
                //MessageBox.Show("Ha habido un error con el UPDATE:\n" + ex.Message);
            }

        }

        public SqlParameter CreateParameter(string pNombre, System.Data.SqlDbType tipo, int longitud, object valor)
        {

            SqlParameter param = new SqlParameter(pNombre, tipo, longitud);
            param.Value = DbConnect.NullToDB(valor);

            return param;
        }
    }
}