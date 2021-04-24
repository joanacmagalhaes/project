using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NatureEventV2
{
    public class DALAsistencia
    {
        DbConnect db;

        public DALAsistencia()
        {
            db = new DbConnect();
        }

        public void UpdateAsistenciaByIdEvento(asistencia asist)
        {
            try
            {
                string sql = @"UPDATE Asistencia 
                           SET Asistir = @pAsistir
                           WHERE RIdEvento = @pRIdEvento 
                           AND RIdUsuario= @pRIdUsuario";

                SqlCommand cmd = new SqlCommand(sql, db.MiCnx);

                cmd.Parameters.Add(CreateParameter("@pAsistir", System.Data.SqlDbType.Bit, 0, asist.Asistir));
                cmd.Parameters.Add(CreateParameter("@pRIdEvento", System.Data.SqlDbType.Int, 0, asist.RIdEvento));
                cmd.Parameters.Add(CreateParameter("@pRIdUsuario", System.Data.SqlDbType.Int, 0, asist.RIdUsuario));

                cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
            }
        }
        public static SqlParameter CreateParameter(string pNombre, System.Data.SqlDbType tipo, int longitud, object valor)
        {

            SqlParameter param = new SqlParameter(pNombre, tipo, longitud);
            param.Value = DbConnect.NullToDB(valor);

            return param;
        }
    }
}