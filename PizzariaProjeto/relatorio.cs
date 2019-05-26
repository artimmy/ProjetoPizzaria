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
    public partial class relatorio : Form
    {
        public relatorio()
        {
            InitializeComponent();
        }

        private void relatorio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzariaDataSet.fechamentoCAIXA' table. You can move, or remove it, as needed.
            this.fechamentoCAIXATableAdapter.Fill(this.pizzariaDataSet.fechamentoCAIXA);

            this.reportViewer1.RefreshReport();
        }
    }
}
