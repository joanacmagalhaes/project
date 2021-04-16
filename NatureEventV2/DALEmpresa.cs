
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
                Console.WriteLine("SelectEventoById(int id): " + ex.Message);
            }
            return emp;
        }

        public List<Empresa> SelectListEmpresa()
        {
            List<Empresa> empresas = new List<Empresa>();

            Empresa emp;
            try
            {
                DateTime today = DateTime.Now;
                string sql = @"SELECT * FROM Empresa";
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
                Console.WriteLine("SelectListEvento(): " + ex.Message);
            }
            return empresas;
        }

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
                Console.WriteLine("SelectEventoById(int id): " + ex.Message);
            }
            return nombreEmpresa;

        }

        public void UpdateEmpresa(Empresa empresa)
        {
            try
            {
                string sql = @"UPDATE Empresa 
                           SET Nombre = @pNombre, Email = @pEmail, Direccion = @pDireccion, Telephone = @pTelefono
                           WHERE IdEmpresa = @pIdEmpresa";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);

                cmd.Parameters.Add(CreateParameter("@pIdEmpresa", System.Data.SqlDbType.Int, 0, empresa.IdEmpresa));
                cmd.Parameters.Add(CreateParameter("@pNombre", System.Data.SqlDbType.NVarChar, 30, empresa.Nombre));
                cmd.Parameters.Add(CreateParameter("@pEmail", System.Data.SqlDbType.NVarChar, 50, empresa.Email));
                cmd.Parameters.Add(CreateParameter("@pDireccion", System.Data.SqlDbType.NVarChar, 100, empresa.Direccion));
                cmd.Parameters.Add(CreateParameter("@pTelefono", System.Data.SqlDbType.Int, 0, empresa.Telefono));


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
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