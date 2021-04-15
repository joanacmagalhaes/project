using System;
using System.Data.SqlClient;

namespace NatureEventV2
{
    public class DALUsuario
    {

        DbConnect con;

        public DALUsuario() {
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
            
            string sql = @"SELECT * FROM Usuario WHERE Email = @pEmail";
            SqlCommand cmd = new SqlCommand(sql, con.MiCnx);
            SqlParameter pEmail = new SqlParameter("@pEmail", email);
            cmd.Parameters.Add(pEmail);


            SqlDataReader dr = cmd.ExecuteReader();
            Usuario usuario = new Usuario();
            while (dr.Read())
            {
                
                usuario.Email = (string)dr["Email"];
           
            }
            return usuario.Email;
        }
        public void InsertarUsuarios(Usuario usuario)
        {
            
            string sql = "insert into Usuario (Nombre, Apellido, Email, PWD, DNI, FechaNac, Direccion, Telephone) values(@pNombre, @pApellido, @pEmail, @pPWD, @pDNI, @pFecha, @pDireccion, @pTelefono)";
            SqlCommand cmd = new SqlCommand(sql, con.MiCnx);
            SqlParameter pNombre = new SqlParameter("@pNombre", usuario.Nombre);
            SqlParameter pApellido = new SqlParameter("@pApellido", usuario.Apellido);
            SqlParameter pEmail = new SqlParameter("@pemail", usuario.Email);
            SqlParameter pPWD = new SqlParameter("@pPWD", usuario.Pwd);
            SqlParameter pDNI = new SqlParameter("@pDNI", usuario.Dni);
            SqlParameter pFecha = new SqlParameter("@pFecha", usuario.FechaNac);
            SqlParameter pDireccion = new SqlParameter("@pDireccion", usuario.Direccion);
            SqlParameter pTelefono = new SqlParameter("@pTelefono", usuario.Telefono);
            cmd.Parameters.Add(pNombre);
            cmd.Parameters.Add(pApellido);
            cmd.Parameters.Add(pEmail);
            cmd.Parameters.Add(pPWD);
            cmd.Parameters.Add(pDNI);
            cmd.Parameters.Add(pFecha);
            cmd.Parameters.Add(pDireccion);
            cmd.Parameters.Add(pTelefono);

            cmd.ExecuteNonQuery();
            
        }


    }
}