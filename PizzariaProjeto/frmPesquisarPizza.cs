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
    
    public partial class frmPesquisarPizza : Form
    {
        

        public frmPesquisarPizza()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha;
            linha = dataGridView1.CurrentRow;

            Pizza.codigo = linha.Cells["codigo"].Value.ToString();
            Pizza.sabor = linha.Cells["sabor"].Value.ToString();
            Pizza.preco = linha.Cells["preco"].Value.ToString();
            
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisarPizza_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM pizza.cadastroPIZZA";
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

        private void txtPizza_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();

                string sql = "SELECT * FROM pizza.cadastroPIZZA WHERE sabor LIKE '" + txtPizza.Text + "%'";

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
