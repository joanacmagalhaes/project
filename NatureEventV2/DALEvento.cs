using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace NatureEventV2
{
    public class DALEvento
    {
        DbConnect db;

        public DALEvento()
        {
           db = new DbConnect();
        }

        public Evento SelectEventoById(int id)
        {
            Evento evento = new Evento();

            try
            {
                string sql = @"SELECT * FROM Evento WHERE IdEvento=@id" ;
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pId = new SqlParameter("id", SqlDbType.Int);
                pId.Value = id;
                cmd.Parameters.Add(pId);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    evento.IdEvento = (int)dr["IdEvento"];
                    evento.Nombre = (string)dr["Nombre"];
                    evento.Direccion = (string)dr["Direccion"];
                    evento.Descripcion = (string)dr["Descripcion"];
                    evento.RIdEmpresa = (int)dr["RIdEmpresa"];
                    evento.Puntos = (int)dr["Puntos"];
                    evento.PosX = (double)dr["PosX"];
                    evento.PosY = (double)dr["PosY"];
                    evento.FechaInicio = dr["FechaInicio"].ToString().Replace('{', ' ');
                    evento.FechaFinal = dr["FechaFinal"].ToString().Replace('{', ' ');

                }

                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("SelectEventoById(int id): " + ex.Message);
            }
            return evento;
        }

        public List<Evento> SelectListEvento()
        {
            List<Evento> eventos = new List<Evento>();
            DALEmpresa dALEmpresa = new DALEmpresa();
            Evento evento;
            try
            {
                DateTime today = DateTime.Now;
                string sql = @"SELECT * FROM Evento WHERE FechaInicio>@today";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pDate = new SqlParameter("today", SqlDbType.DateTime);
                pDate.Value = today;
                cmd.Parameters.Add(pDate);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    evento = new Evento();
                    evento.IdEvento = (int)dr["IdEvento"];
                    evento.Nombre = (string)dr["Nombre"];
                    evento.Direccion = (string)dr["Direccion"];
                    evento.Descripcion = (string)dr["Descripcion"];
                    evento.RIdEmpresa = (int)dr["RIdEmpresa"];
                    evento.Puntos = (int)dr["Puntos"];
                    evento.PosX = Double.Parse(dr["PosX"].ToString());
                    evento.PosY = Double.Parse(dr["PosY"].ToString());
                    evento.FechaInicio = dr["FechaInicio"].ToString().Replace('{',' ');
                    evento.FechaFinal = dr["FechaFinal"].ToString().Replace('{', ' ');
                    evento.NombreEmpresa = dALEmpresa.SelectNombreEmpresaById(evento.IdEvento);
                    eventos.Add(evento);
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("SelectListEvento(): " + ex.Message);
            }
            return eventos;
        }
    }
}