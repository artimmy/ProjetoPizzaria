using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PizzariaProjeto
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abre a conexão
                Conexao.Conectar();
                // Cria variável com o código SQL
                string sql = @"SELECT * FROM pizza.cadastroF
                                WHERE usuario = @usuario AND
                                senha = @senha AND
                                tipo = @tipo";
               
                
                // Criando um comando SQL
                // Mas não executando
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.Parameters.AddWithValue("usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);
                cmd.Parameters.AddWithValue("tipo", cbTipo.SelectedItem);
                // Executa o comando SQL
                // e armazena o resultado na variável
                // dr que é um DataReader
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    this.Visible = false;
                    frmPrincipal menu = new frmPrincipal();
                    menu.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                }
                // Fecha a variável dr que contém os dados
                // retornados do banco
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
            
            

        }
    }
}
