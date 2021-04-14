
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
                    emp.Direccion = (string)dr["Nombre"];
                    emp.Cif = (string)dr["Cif"];
                    emp.Pwd = (string)dr["Pwd"];
                    emp.Email = (string)dr["Email"];

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
    }
}