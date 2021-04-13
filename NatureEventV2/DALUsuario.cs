using System;
using System.Data.SqlClient;

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

        public void comprobarLoginUsuario(string email, string password)
        {
            try
            {
                DbConnect db = new DbConnect();
                string sql = "SELECT * FROM USUARIO WHERE EMAIL = @pEmail AND PASSWORD = @pPassword";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pEmail = new SqlParameter("@pEmail", email);
                SqlParameter pPassword = new SqlParameter("@pPassword", password);
                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pPassword);
                string returnValue = (string)cmd.ExecuteScalar();
                if (String.IsNullOrEmpty(returnValue))
                {
                    //errorLogin.Visible = true;
                    return;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}