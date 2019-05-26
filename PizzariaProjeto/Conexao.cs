using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PizzariaProjeto
{
    public static class Conexao
    {
        public static SqlConnection conn;
        public static string restore = @"C:\bkp\pizzaria_restaura.bak";

        public static void Conectar()
        {
            conn = new SqlConnection(@"Data Source = SJC0417300W8-1\SQLEXPRESS; Initial Catalog = pizzaria; User ID = sa; Password = senacsjc");
            conn.Open();

        }
        public static void Desconectar()
        {
            conn.Close();
        }

        public static void RestauraBkp()
        {
            conn = new SqlConnection(@"Data Source = SJC0417300W8-1\SQLEXPRESS; Initial Catalog = master; User ID = sa; Password = senacsjc");
            conn.Open();

            string sql = @"ALTER DATABASE pizzaria SET MULTI_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE pizzaria FROM DISK ='" + restore + "' WITH REPLACE;";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
            cmd.ExecuteNonQuery();
            Conexao.Desconectar();
        }

    }
}
