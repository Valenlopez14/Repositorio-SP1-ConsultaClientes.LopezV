using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.LopezValentin.SP1
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmClientes frmClientes = new frmClientes();
            frmClientes.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TSMSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vendedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVendedor frmVendedor = new frmVendedor();
            frmVendedor.ShowDialog();   
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaClientes frmConsultasClientes = new frmConsultaClientes();
            frmConsultasClientes.ShowDialog();
        }
    }
}
