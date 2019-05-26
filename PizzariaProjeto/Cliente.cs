using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PizzariaProjeto
{
    public static class Cliente
    {
        public static string codigo = "";
        public static string nome;
        public static string telefone;
        public static string endereco;
        public static string numero;
        public static string bairro;



        //metodo para cadastrar um cliente

        public static void cadastrarCliente(string nome, string telefone, string endereco, string numero, string bairro)
        {
            string sql = @"INSERT INTO pizza.cadastroC VALUES (@nome, @telefone, @endereco, @numero, @bairro)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("endereco", endereco);
            cmd.Parameters.AddWithValue("bairro", bairro);
            cmd.Parameters.AddWithValue("numero", numero);
            cmd.Parameters.AddWithValue("telefone", telefone);
            cmd.Parameters.AddWithValue("codigo", Cliente.codigo);

            cmd.ExecuteNonQuery();

        }

        //metodo para alterar dados do cliente
        public static void alteraCliente(string nome, string telefone, string endereco, string numero, string bairro)
        {
            string sql = @"UPDATE pizza.cadastroC SET NOME = @nome, TELEFONE = @telefone, ENDERECO = @endereco, NUMERO = @numero, BAIRRO = @bairro WHERE CODIGO = @codigo";

           
            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("telefone", telefone);
            cmd.Parameters.AddWithValue("endereco", endereco);
            cmd.Parameters.AddWithValue("numero", numero);
            cmd.Parameters.AddWithValue("bairro", bairro);
            cmd.Parameters.AddWithValue("codigo", Cliente.codigo);

            cmd.ExecuteNonQuery();
        }


        //metodo para excluir o cliente
        public static void excluirCliente()
        {
            string sql = @"DELETE FROM pizza.cadastroC WHERE codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("codigo", Cliente.codigo);

            cmd.ExecuteNonQuery();
        }
    }
}
