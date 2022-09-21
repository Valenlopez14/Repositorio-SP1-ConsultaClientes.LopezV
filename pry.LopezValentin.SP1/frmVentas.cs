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
            bool Bandera = false;

            StreamReader Ventas = new StreamReader("./Ventas.txt");

            while (!Ventas.EndOfStream)
            {
                string auxVentas = Ventas.ReadLine();

                if (mskNroFac.Text == auxVentas.Substring(2, 7))
                {
                    MessageBox.Show("Este codigo ya se encuentra cargado, intente de nuevo");
                    lstTipoFactura.SelectedIndex = 0;
                    mskNroFac.Text = "";
                    DTPFecha.Text = "";
                    mskIDCliente.Text = "";
                    mskIdVendedor.Text = "";
                    txtMonto.Text = "";
                    lstTipoFactura.Focus();
                    Bandera = true;

                }

            }
            Ventas.Close();

            if (Bandera == false)
            {
                StreamWriter srVentas = new StreamWriter("./Ventas.txt", true);
                srVentas.WriteLine(lstTipoFactura.Text + ";" + mskNroFac.Text + ";" + DTPFecha.Text + ";" + mskIDCliente.Text + ";" + mskIdVendedor.Text + ";" + txtMonto.Text);
                MessageBox.Show("Ventas cargada con exito");
                srVentas.Close();
                lstTipoFactura.SelectedIndex = 0;
                mskNroFac.Text = "";
                DTPFecha.Text = "";
                mskIDCliente.Text = "";
                mskIdVendedor.Text = "";
                txtMonto.Text = "";
                lstTipoFactura.Focus();
            }
        }

    }
}
