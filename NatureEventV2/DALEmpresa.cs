
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NatureEventV2
{
    public class DALEmpresa
    {

        DbConnect db;

        public DALEmpresa() {
            db = new DbConnect();
        }

        public Empresa SelectEmpresaById(int id)
        {
            Empresa emp = new Empresa();

            try
            {
                string sql = @"SELECT * FROM Empresa WHERE IdEmpresa=@id";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pId = new SqlParameter("id", SqlDbType.Int);
                pId.Value = id;
                cmd.Parameters.Add(pId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp.IdEmpresa = (int)dr["IdEmpresa"];
                    emp.Nombre = (string)dr["Nombre"];
                    emp.Direccion = (string)dr["Direccion"];
                    emp.Cif = (string)dr["Cif"];
                    emp.Pwd = (string)dr["Pwd"];
                    emp.Email = (string)dr["Email"];
                    emp.Telefono = (int)dr["Telephone"];

                }

                dr.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error SelectEmpresaById: " + ex);
            }
            return emp;
        }

        public List<Empresa> SelectListEmpresa()
        {
            List<Empresa> empresas = new List<Empresa>();

            Empresa emp;
            try
            {   
                string sql = @"SELECT * FROM Empresa";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp = new Empresa();
                    emp.IdEmpresa = (int)dr["IdEmpresa"];
                    emp.Nombre = (string)dr["Nombre"];
                    emp.Direccion = (string)dr["Nombre"];
                    emp.Cif = (string)dr["Cif"];
                    emp.Pwd = (string)dr["Pwd"];
                    emp.Email = (string)dr["Email"];

                    empresas.Add(emp);
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error SelectNombreEmpresaById: " + ex);
            }
            return empresas;
        }

        /*public List<Empresa> SelectListEmpWithActiveEvents()
        {
            List<Empresa> empresas = new List<Empresa>();

            Empresa emp;
            try
            {
                DateTime today = DateTime.Now;
                string sql = @"SELECT * FROM Empresa WHERE ";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pDate = new SqlParameter("today", SqlDbType.DateTime);
                pDate.Value = today;
                cmd.Parameters.Add(pDate);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    emp = new Empresa();
                    emp.IdEmpresa = (int)dr["IdEmpresa"];
                    emp.Nombre = (string)dr["Nombre"];
                    emp.Direccion = (string)dr["Nombre"];
                    emp.Cif = (string)dr["Cif"];
                    emp.Pwd = (string)dr["Pwd"];
                    emp.Email = (string)dr["Email"];

                    empresas.Add(emp);
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error SelectNombreEmpresaById: " + ex);
            }
            return empresas;
        }

        */

        public string SelectNombreEmpresaById(int id)
        {
            string nombreEmpresa = null;
            try
            {
                string sql = @"SELECT Nombre FROM Empresa WHERE IdEmpresa=@id";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pId = new SqlParameter("id", SqlDbType.Int);
                pId.Value = id;
                cmd.Parameters.Add(pId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    nombreEmpresa = (string)dr["Nombre"];

                }

                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error SelectNombreEmpresaById: " + ex);
            }
            return nombreEmpresa;

        }
        public string ValidarExistenciaEmail(string email)
        {
            Empresa empresa = new Empresa();

            try
            {
                string sql = @"SELECT * FROM Empresa WHERE Email = @pEmail";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pEmail = new SqlParameter("@pEmail", email);
                cmd.Parameters.Add(pEmail);


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    empresa.Email = (string)dr["Email"];

                }
            }catch(Exception ex)
            {
                throw new Exception("Error ValidarExistenciaEmail: " + ex);

            }

            return empresa.Email;
        }
        
      public void InsertarEmpresa(Empresa empresa)
        {

            string sql = "insert into Empresa (Nombre, CIF, Email, PWD, Direccion, Telephone) values(@pNombre, @pCIF, @pEmail, @pPWD, @pDireccion, @pTelefono)";
            SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
            SqlParameter pNombre = new SqlParameter("@pNombre", empresa.Nombre);
            SqlParameter pCIF = new SqlParameter("@pCIF", empresa.Cif);
            SqlParameter pEmail = new SqlParameter("@pEmail", empresa.Email);
            SqlParameter pPWD = new SqlParameter("@pPWD", empresa.Pwd);
            SqlParameter pDireccion = new SqlParameter("@pDireccion", empresa.Direccion);
            SqlParameter pTelefono = new SqlParameter("@pTelefono", empresa.Telefono);
            cmd.Parameters.Add(pNombre);
            cmd.Parameters.Add(pCIF);
            cmd.Parameters.Add(pEmail);
            cmd.Parameters.Add(pPWD);
            cmd.Parameters.Add(pDireccion);
            cmd.Parameters.Add(pTelefono);

            cmd.ExecuteNonQuery();

        }

        public int? comprobarLoginEmpresa(string email, string password)
        {
            try
            {
                DbConnect db = new DbConnect();
                string sql = "SELECT IdEmpresa FROM EMPRESA WHERE EMAIL = @pEmail AND PWD = @pPassword";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pEmail = new SqlParameter("@pEmail", System.Data.SqlDbType.NVarChar, 50);
                SqlParameter pPassword = new SqlParameter("@pPassword", System.Data.SqlDbType.NVarChar, 200);
                pEmail.Value = email;
                pPassword.Value = password;
                cmd.Parameters.Add(pEmail);
                cmd.Parameters.Add(pPassword);

                int? returnValue = (int)cmd.ExecuteScalar();
                if (returnValue == null)
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
                throw new Exception("Error comprobarLoginEmpresa: " + ex);
            }
        }

        public void UpdateEmpresa(Empresa empresa)
        {
            try
            {
                string sql = @"UPDATE Empresa
                           SET Nombre = @pNombre,  Email = @pEmail, Direccion = @pDireccion, Telephone = @pTelephone
                           WHERE IdEmpresa = @pIdEmpresa";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);

                cmd.Parameters.Add(CreateParameter("@pNombre", System.Data.SqlDbType.NVarChar, 30, empresa.Nombre));
                cmd.Parameters.Add(CreateParameter("@pEmail", System.Data.SqlDbType.NVarChar, 50, empresa.Email));
                cmd.Parameters.Add(CreateParameter("@pDireccion", System.Data.SqlDbType.NVarChar, 100, empresa.Direccion));
                cmd.Parameters.Add(CreateParameter("@pIdEmpresa", System.Data.SqlDbType.Int, 0, empresa.IdEmpresa));
                cmd.Parameters.Add(CreateParameter("@pTelephone", System.Data.SqlDbType.Int, 0, empresa.Telefono));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception("Error UpdateEmpresa: " + ex);
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