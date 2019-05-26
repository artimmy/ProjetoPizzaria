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
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;

            linha = dataGridView1.CurrentRow;

            Cliente.codigo = linha.Cells["codigo"].Value.ToString();
            Cliente.nome = linha.Cells["nome"].Value.ToString();
            Cliente.telefone = linha.Cells["telefone"].Value.ToString();
            Cliente.endereco = linha.Cells["endereco"].Value.ToString();
            Cliente.numero = linha.Cells["numero"].Value.ToString();
            Cliente.bairro = linha.Cells["bairro"].Value.ToString();

            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = "SELECT * FROM pizza.cadastroC WHERE nome LIKE '" + txtNome.Text + "%'";
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void frmPesquisarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM pizza.cadastroC";
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
    }
}
