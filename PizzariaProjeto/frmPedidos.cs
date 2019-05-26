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
    public partial class frmPedidos : Form
    {
        public frmPedidos()
        {
            InitializeComponent();
        }

        int op = 0;
        double precoPizza = 0;
        double total = 0;
        

        private void btnProcurarCliente_Click(object sender, EventArgs e)
        {
            Cliente.codigo = "";
            frmPesquisarCliente cliente = new frmPesquisarCliente();
            cliente.ShowDialog();

            if (Cliente.codigo != "")
            {
                txtNome.Text = Cliente.nome;
                txtFone.Text = Cliente.telefone;
                txtEndereco.Text = Cliente.endereco;
                txtNum.Text = Cliente.numero;
                txtBairro.Text = Cliente.bairro;

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            DialogResult op;

            op = MessageBox.Show("Deseja relamente Excluir esse Cliente? CUIDADO!", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

            if (op == DialogResult.Yes)
            {
                try
                {
                    Conexao.Conectar();

                    Cliente.excluirCliente();

                    MessageBox.Show("Cliente excluido com sucesso! >:)");

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);
                }

                finally
                {
                    Conexao.Desconectar();
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    txtNome.Clear();
                    txtFone.Clear();
                    txtEndereco.Clear();
                    txtNum.Clear();
                    txtBairro.Clear();

                }
            }
        }
   
        private void btnCadsatrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                Cliente.cadastrarCliente(txtNome.Text, txtFone.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text);
                MessageBox.Show("Cliente cadastrado com sucesso");

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                Conexao.Desconectar();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                txtNome.Clear();
                txtFone.Clear();
                txtEndereco.Clear();
                txtNum.Clear();
                txtBairro.Clear();

            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                    Conexao.Conectar();
                    Cliente.alteraCliente(txtNome.Text, txtFone.Text, txtEndereco.Text, txtNum.Text, txtBairro.Text);
                    MessageBox.Show("Cliente alterado com sucesso"); 
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                Conexao.Desconectar();
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                txtNome.Clear();
                txtFone.Clear();
                txtEndereco.Clear();
                txtNum.Clear();
                txtBairro.Clear();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtFone.Clear();
            txtEndereco.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            txtCodigo.Clear();

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            
            txtTotal.Text = total.ToString();
            
            try
            {
                Finalizar.total = total;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                frmTroco troco = new frmTroco();
                troco.Show();
            }

           
        }

        private void frmPedidos_Load(object sender, EventArgs e)
        {
            
            try
            {
                Conexao.Conectar();
                string sql = "SELECT * FROM pizza.cadastroPIZZA";
                DataTable dt = new DataTable();
                //permite realizar um comando no sql 
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                dt.Load(cmd.ExecuteReader());
                cbxSabor.DataSource = dt;
                cbxSabor.DisplayMember = "sabor";
                op = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
            }
        }

        private void cbxSabor_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
        }

        private void cbxSabor_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxSabor_SelectedValueChanged(object sender, EventArgs e)
        {
            
           
        }

        private void cbxSabor_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (op == 1)
            {


                try
                {
                    Conexao.Conectar();
                    string sql = "SELECT preco FROM pizza.cadastroPIZZA where sabor=@sabor";

                    //permite realizar um comando no sql 
                    SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                    cmd.Parameters.AddWithValue("sabor", cbxSabor.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    txtTotal.Text = dr["preco"].ToString();
                    dr.Close();
                    total = double.Parse(txtTotal.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro" + ex.Message);
                }
                finally
                {
                    Conexao.Desconectar();
                }

            }
        }

        private void ckbQueijo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbQueijo.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
                Nota.queijo = "Queijo extra";
            }
            else
            {
                total = total - 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void rdbPequena_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPequena.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
            }
            else
            {
                total = total - 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEntrega.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
                Nota.entrega = "Entregar";
            }
            else
            {
                total = total - 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbBorda_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBorda.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void rdbGrande_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGrande.Checked)
            {
                total = total + 5.00;
                txtTotal.Text = total.ToString();
                Nota.tamanho = "";
            }
            else
            {
                total = total - 5.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void rdbMedia_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMedia.Checked)
            {
                total = total + 0;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbAnchovas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbAnchovas.Checked)
            {
                total = total + 3.50;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbAzeitonas_CheckedChanged(object sender, EventArgs e)
        {
                if (ckbAzeitonas.Checked)
                {
                    total = total + 1.00;
                    txtTotal.Text = total.ToString();
                }
        }

        private void ckbAzeitonasP_CheckedChanged(object sender, EventArgs e)
        {
                if (ckbAzeitonasP.Checked)
                {
                    total = total + 1.50;
                }
        }

        private void ckbCalabresa_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCalabresa.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbCamarao_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCamarao.Checked)
            {
                total = total + 3.50;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbCebola_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCebola.Checked)
            {
                total = total + 1.50;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbCogumelo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbCogumelo.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbOvo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbOvo.Checked)
            {
                total = total + 1.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPepperoni.Checked)
            {
                total = total + 3.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbPimentaoV_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPimentaoV.Checked)
            {
                total = total + 1.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void ckbPresunto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPresunto.Checked)
            {
                total = total + 2.00;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }
        
    }

}
