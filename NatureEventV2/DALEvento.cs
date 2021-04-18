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
                throw new Exception("Error SelectEventoById:" + ex.Message);
            }
            return evento;
        }
      
        public List<Evento> SelectListEventosByIdEmpresa(int idEmpresa)
        {
            List<Evento> eventos = new List<Evento>();
            DALEmpresa dALEmpresa = new DALEmpresa();
            Evento evento;
            try
            {
                string sql = @"SELECT * FROM Evento WHERE RIdEmpresa = @pRIdEmpresa";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pRIdEmpresa = new SqlParameter("pRIdEmpresa", SqlDbType.Int);
                pRIdEmpresa.Value = idEmpresa;
                cmd.Parameters.Add(pRIdEmpresa);

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
                    evento.FechaInicio = dr["FechaInicio"].ToString().Replace('{', ' ');
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
                throw new Exception("Error SelectListEvento:" + ex.Message);
            }
            return eventos;
        }

        public List<Evento> SelectListEventoByCompanyAndStartDate(int idEmpresa, string fechaStart)
        {
            List<Evento> eventos = new List<Evento>();
            DALEmpresa dALEmpresa = new DALEmpresa();
            Evento evento;
            try
            {
                string sql = @"SELECT * FROM Evento WHERE FechaInicio>@pFecha";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pDate = new SqlParameter("pFecha", SqlDbType.DateTime);
                if (fechaStart == "") fechaStart = DateTime.Now.ToString();
                pDate.Value = fechaStart;
                cmd.Parameters.Add(pDate);
                if (idEmpresa != 0)
                {
                    sql += " AND RIdEmpresa=@pIdempresa";
                    cmd.CommandText = sql;
                    SqlParameter pId = new SqlParameter("pIdempresa", SqlDbType.Int);
                    pId.Value = idEmpresa;
                    cmd.Parameters.Add(pId);

                }

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
                    evento.FechaInicio = dr["FechaInicio"].ToString().Replace('{', ' ');
                    evento.FechaFinal = dr["FechaFinal"].ToString().Replace('{', ' ');
                    evento.NombreEmpresa = dALEmpresa.SelectNombreEmpresaById(evento.IdEvento);
                    eventos.Add(evento);
                }

                dr.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Error SelectListEventoByCompanyAndStartDate:" + ex.Message);
            }
            return eventos;
        }


        public bool exitsEventoUsuario(int eid, int uid)
        {
            bool res = false;
            try
            {
                string sql = @"SELECT * FROM Asistencia WHERE RIdUsuario=@uid AND RIdEvento=@eid";

                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);

                SqlParameter pUid = new SqlParameter("uid", SqlDbType.Int);
                pUid.Value = uid;
                cmd.Parameters.Add(pUid);
                SqlParameter pEid = new SqlParameter("eid", SqlDbType.Int);
                pEid.Value = eid;
                cmd.Parameters.Add(pEid);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows) res = true;
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error exitsEventoUsuario:" + ex.Message);
            }

            return res;
        }

        public int addUserEvento(int eid, int uid)
        {
            try
            {
                if (this.exitsEventoUsuario(eid, uid)) return 2;

                string sql = @"INSERT INTO Asistencia VALUES(@uid,@eid,@bAs)";
                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);
                SqlParameter pUid = new SqlParameter("uid", SqlDbType.Int);
                pUid.Value = uid;
                SqlParameter pEid = new SqlParameter("eid", SqlDbType.Int);
                pEid.Value = eid;
                SqlParameter bAs = new SqlParameter("bAs", SqlDbType.Bit);
                bAs.Value = true;
                
                cmd.Parameters.Add(bAs);
                cmd.Parameters.Add(pUid);
                cmd.Parameters.Add(pEid);

                cmd.ExecuteReader();

            }
            catch (Exception)
            {
                return 0;
            }
            return 1;
        }
    }
}