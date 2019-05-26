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
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        private void btnProcurarLocal_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {


                Conexao.Conectar();

                if (System.IO.File.Exists(@"C:\bkp\pizzaria.bak"))
                {
                    string caminho = "pizzaria" + DateTime.Now.ToString();
                    caminho = caminho.Replace("/", "_");
                    caminho = caminho.Replace(" ", "_");
                    caminho = caminho.Replace(":", "_");
                    System.IO.File.Move(@"C:\bkp\pizzaria.bak", @"C:\bkp\" + caminho + ".bak");



                }

                string sql = @"BACKUP DATABASE pizzaria TO DISK = '" + txtBackup.Text + "\\pizzaria.bak'";
                SqlCommand cmd = new SqlCommand(sql, Conexao.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup efetuado com sucesso!");
                btnBackup.Enabled = false;
                txtBackup.Clear();
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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\bkp\pizzaria.bak"))
            {
                try
                {
                    MessageBox.Show("Restauração efetuada com sucesso!\nNecessário reiniciar o sistema");
                    System.IO.File.Move(@"C:\bkp\pizzaria.bak", @"C:\bkp\pizzaria_restaura.bak");
                    Application.Restart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Não existem arquivos de backup para restauração. \nFavor realizar backup", "Realizar Backup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



        }
    }
}
