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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult op;
            
            op = MessageBox.Show("Deseja Realmente Sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            
            if (op == DialogResult.Yes)
            {
                this.Close();
            }

            
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPedidos pedido = new frmPedidos();
            pedido.MdiParent = this;
            pedido.Show();
        }

        private void relatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio relatorio = new relatorio();
            relatorio.MdiParent = this;
            relatorio.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.MdiParent = this;
            cadastro.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBackup bkp = new frmBackup();
            bkp.MdiParent = this;
            bkp.Show();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda();
            ajuda.MdiParent = this;
            ajuda.Show();
        }

        private void pizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPizza pizza = new frmPizza();
            pizza.MdiParent = this;
            pizza.Show();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.MdiParent = this;
            sobre.Show();
        }

        private void ajudaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAjuda ajuda = new frmAjuda();
            ajuda.MdiParent = this;
            ajuda.Show();
        }
    }
}
