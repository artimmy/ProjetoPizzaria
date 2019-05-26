using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PizzariaProjeto
{
    public static class Funcionario
    {
        public static string codigo = "";
        public static string nome;
        public static string endereco;
        public static string telefone;
        public static string cpf;
        public static string usuario;
        public static string senha;
        public static string tipo;

        public static void cadastrarFuncionario(string nome, string endereco, string telefone, string cpf, string usuario, string senha, string tipo)
        {
            string sql = @"INSERT INTO pizza.cadastroF VALUES (@nome, @endereco, @telefone, @cpf, @usuario, @senha, @tipo)";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("endereco", endereco);
            cmd.Parameters.AddWithValue("telefone", telefone);
            cmd.Parameters.AddWithValue("cpf", cpf);
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("senha", senha);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("codigo", Funcionario.codigo);

            cmd.ExecuteNonQuery();

        }

        public static void alterarFuncionario(string nome, string endereco, string telefone, string cpf, string usuario, string senha, string tipo)
        {
            string sql = @"UPDATE pizza.cadastroC SET NOME = @nome, endereco = @endereco, telefone = @telefone, cpf = @cpf, usuario = @usuario, senha = @senha, tipo = @tipo WHERE codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("nome", nome);
            cmd.Parameters.AddWithValue("endereco", endereco);
            cmd.Parameters.AddWithValue("telefone", telefone);
            cmd.Parameters.AddWithValue("cpf", cpf);
            cmd.Parameters.AddWithValue("usuario", usuario);
            cmd.Parameters.AddWithValue("senha", senha);
            cmd.Parameters.AddWithValue("tipo", tipo);
            cmd.Parameters.AddWithValue("codigo", Funcionario.codigo);

            cmd.ExecuteNonQuery();

        }

        public static void excluirFuncionario(string nome, string endereco, string telefone, string cpf, string usuario, string senha, string tipo)
        {
            string sql =  @"DELETE FROM pizza.cadastroC WHERE codigo = @codigo";

            SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

            cmd.Parameters.AddWithValue("codigo", Cliente.codigo);

            cmd.ExecuteNonQuery();
        }



    }
}
