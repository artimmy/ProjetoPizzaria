using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PizzariaProjeto
{
    public static class Pizza
    {
        public static string codigo = "";
        public static string sabor;
        public static string preco;


        public static void cadastrarPizza(string sabor, string preco)
        {
            string sql = @"INSERT INTO pizza.cadastroPIZZA values (@sabor,@preco)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("sabor", sabor);
            cmd.Parameters.AddWithValue("preco", double.Parse(preco));
            cmd.ExecuteNonQuery();
        }

        public static void alteraPizza(string sabor, string preco)
        {
            string sql = @"UPDATE pizza.cadastroPIZZA SET sabor = @sabor,
                                                          preco = @preco
                                                         WHERE codigo = @codigo";
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("sabor", sabor);
            cmd.Parameters.AddWithValue("preco", double.Parse(preco));
            cmd.Parameters.AddWithValue("codigo", Pizza.codigo);

            cmd.ExecuteNonQuery();

        }

        public static void excluirPizza()
        {
            string sql = @"DELETE FROM pizza.cadastroPIZZA WHERE codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("codigo", Pizza.codigo);

            cmd.ExecuteNonQuery();
        }

    }
}