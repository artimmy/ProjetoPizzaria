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
    public partial class frmTroco : Form
    {
        double recebido = 0;
        double troco;
        public frmTroco()
        {
            InitializeComponent();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmNota nota = new frmNota();
            nota.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTroco_Load(object sender, EventArgs e)
        {
            txtTotal.Text = Finalizar.total.ToString();
        }

        private void txtRecebido_TextChanged(object sender, EventArgs e)
        {
            if (txtRecebido.Text != "")
            {
                recebido = double.Parse(txtRecebido.Text);
                troco = (recebido) - (Finalizar.total);
                txtTroco.Text = troco.ToString();
            }
        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
