using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pry.LopezValentin.SP1
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {

            StreamWriter Ventas = new StreamWriter("./Ventas.txt", true);
            Ventas.WriteLine(lstTipoFactura.Text + ";" + mskNroFac.Text + ";" + DTPFecha.Text + ";" + mskIDCliente.Text + ";" + mskIdVendedor.Text + ";" + txtMonto.Text);
            MessageBox.Show("Venta cargada con éxito.");
            Ventas.Close();
            lstTipoFactura.Items.Clear();
            mskNroFac.Text = "";
            DTPFecha.Text = "";
            mskIDCliente.Text = "";
            mskIdVendedor.Text = "";
            txtMonto.Text = "";
            lstTipoFactura.Focus();

        }

    }
}
