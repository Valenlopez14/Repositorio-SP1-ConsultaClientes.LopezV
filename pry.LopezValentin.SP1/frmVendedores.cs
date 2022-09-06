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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            StreamWriter vendedor = new StreamWriter("./Vendedor.txt", true);
            vendedor.WriteLine(mskNroVendedor.Text + " " + txtVendedor);
            MessageBox.Show("Vendedor cargado con éxito.");
            vendedor.Close();
            txtVendedor.Text = "";
            mskNroVendedor.Text = "";
            txtVendedor.Focus();
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Vendedor.txt");
            MessageBox.Show("El archivo fue borrado.");
        }
    }
}
