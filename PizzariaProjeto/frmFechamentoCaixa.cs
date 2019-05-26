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
    public partial class frmFechamentoCaixa : Form
    {
        public frmFechamentoCaixa()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFechamentoCaixa_Load(object sender, EventArgs e)
        {
            /*try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM pizza.fechamentoCAIXA";
                DataTable dt = new DataTable();
                //permite realizar um comando no sql 
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                dgvRelatorio.DataSource = dt;
                //dataGridView1.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
             */
        }
    }
}
