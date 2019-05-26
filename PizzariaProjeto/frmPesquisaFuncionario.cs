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
    public partial class frmPesquisaFuncionario : Form
    {
        public frmPesquisaFuncionario()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntSelecionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = dataGridView1.CurrentRow;

            Funcionario.codigo = linha.Cells["codigo"].Value.ToString();
            Funcionario.nome = linha.Cells["nome"].Value.ToString();
            Funcionario.cpf = linha.Cells["cpf"].Value.ToString();
            Funcionario.telefone = linha.Cells["telefone"].Value.ToString();
            Funcionario.endereco = linha.Cells["endereco"].Value.ToString();
            Funcionario.usuario = linha.Cells["usuario"].Value.ToString();
            Funcionario.senha = linha.Cells["senha"].Value.ToString();
            Funcionario.tipo = linha.Cells["tipo"].Value.ToString();
            
            this.Close();
        }

        private void frmPesquisaFuncionario_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM pizza.cadastroF";
                DataTable dt = new DataTable();
                //permite realizar um comando no sql 
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
                //dataGridView1.ForeColor = Color.Black;
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

        private void txtNomeF_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = "SELECT * FROM pizza.cadastroF WHERE nome LIKE '" + txtNomeF.Text + "%'";

                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);

                dt.Load(cmd.ExecuteReader());

                dataGridView1.DataSource = dt;

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
