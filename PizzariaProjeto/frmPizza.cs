using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaProjeto
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                Pizza.alteraPizza(txtSabor.Text, txtPreco.Text);
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
                
                txtSabor.Clear();
                txtPreco.Clear();
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;

            }

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSabor.Text.Trim().Length == 0 || txtPreco.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Entre com os dados da pizza");
                    txtSabor.Clear();
                    txtPreco.Clear();
                    txtSabor.Focus();
                }

                else
                {
                    try
                    {
                        Conexao.Conectar();
                        Pizza.cadastrarPizza(txtSabor.Text, txtPreco.Text);
                        MessageBox.Show("Pizza Cadastrada com sucesso!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }



                    finally
                    {
                        Conexao.Desconectar();
                        
                        txtSabor.Clear();
                        txtPreco.Clear();
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }



        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pizza.codigo = "";
            frmPesquisarPizza pesqP = new frmPesquisarPizza();
            pesqP.ShowDialog();

            if (Pizza.codigo != "")
            {

                txtCodigo.Text = Pizza.codigo;
                txtSabor.Text = Pizza.sabor;
                txtPreco.Text = Pizza.preco;
                
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
                    Pizza.excluirPizza();
                    MessageBox.Show("Pizza excluida com sucesso");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            
                finally
                {
                    Conexao.Desconectar();
                    txtPreco.Clear();
                    txtSabor.Clear();
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                }

            }
        
        }

        private void frmPizza_Load(object sender, EventArgs e)
        {

        }



    }
}
