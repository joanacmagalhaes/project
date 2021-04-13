using System.Data.SqlClient;

namespace NatureEventV2
{
    class DbConnect
    {
        SqlConnection miCnx = null;

        public SqlConnection MiCnx { get => miCnx; set => miCnx = value; }

        public DbConnect()
        {
            this.MiCnx = new SqlConnection("Data Source=161.22.42.238,54321;Initial Catalog=FEsplai_SaveWorld;User ID=sa;Password=123456789FEsplai;");
            this.MiCnx.Open();
        }

        public static object NullFromDb(object valOriginal)
        {
            object valor = valOriginal;
            if (valor == System.DBNull.Value)
            {
                return null;
            }
            else
            {
                return valOriginal;
            }
        }

        public static object NullToDB(object valOriginal)
        {
            if (valOriginal == null)
            {
                return System.DBNull.Value;
            }
            else
            {
                return valOriginal;
            }
        }


    }
}
