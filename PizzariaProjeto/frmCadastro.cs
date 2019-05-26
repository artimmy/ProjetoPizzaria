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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Funcionario.codigo = "";
            frmPesquisaFuncionario pesquisa = new frmPesquisaFuncionario();
            pesquisa.ShowDialog();

            if (Funcionario.codigo != "")
            {
                txtCodigo.Text = Funcionario.codigo;
                txtNome.Text = Funcionario.nome;
                txtCPF.Text = Funcionario.cpf;
                txtTelefone.Text = Funcionario.telefone;
                txtEndereco.Text = Funcionario.endereco;
                txtUsuario.Text = Funcionario.usuario;
                txtSenha.Text = Funcionario.senha;
                cbxTipo.SelectedItem = Funcionario.tipo;

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text.Trim().Length == 0 || txtCPF.Text.Trim().Length == 0 || txtTelefone.Text.Trim().Length == 0 || txtEndereco.Text.Trim().Length == 0 || txtUsuario.Text.Trim().Length == 0 || txtSenha.Text.Trim().Length == 0 || cbxTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Entre com todos os dados do funcionario");
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Clear();
                    txtCPF.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    cbxTipo.SelectedIndex = -1;
                }
                else
                {
                    Conexao.Conectar();
                    Funcionario.cadastrarFuncionario(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtCPF.Text, txtUsuario.Text, txtSenha.Text, cbxTipo.SelectedIndex.ToString());
                    MessageBox.Show("Funcionario cadastrado com sucesso!");
                }

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
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtCPF.Clear();
                txtUsuario.Clear();
                txtSenha.Clear();
                cbxTipo.SelectedIndex = -1;
            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCPF.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            cbxTipo.SelectedIndex = -1;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Conectar();
                Funcionario.alterarFuncionario(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtCPF.Text, txtUsuario.Text, txtSenha.Text, cbxTipo.SelectedIndex.ToString());
                MessageBox.Show("Funcionario alterado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.Desconectar();
                txtNome.Clear();
                txtEndereco.Clear();
                txtTelefone.Clear();
                txtCPF.Clear();
                txtUsuario.Clear();
                txtSenha.Clear();
                cbxTipo.SelectedIndex = -1;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult op;

            op = MessageBox.Show("Deseja relamente excluir esse funcionario? CUIDADO!", "Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3);

            if (op == DialogResult.Yes)
            {
                try
                {
                    Conexao.Conectar();
                    Funcionario.excluirFuncionario(txtNome.Text, txtEndereco.Text, txtTelefone.Text, txtCPF.Text, txtUsuario.Text, txtSenha.Text, cbxTipo.SelectedIndex.ToString());
                    MessageBox.Show("Funcionario excluido com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    Conexao.Desconectar();
                    txtNome.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Clear();
                    txtCPF.Clear();
                    txtUsuario.Clear();
                    txtSenha.Clear();
                    cbxTipo.SelectedIndex = -1;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                }

            }

        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
