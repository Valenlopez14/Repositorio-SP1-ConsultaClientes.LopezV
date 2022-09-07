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
            string varActivo = "ACTIVO NO";
            string varComision = "COMISION NO";

            if (chkActivo.Checked == true)
            {
                varActivo = "ACTIVO SI";
            }

            if (chkComision.Checked == true)
            {
                varComision = "COMISION SI";
            }

           



            bool bandera = false;
            StreamReader srNumeroDeVendedor = new StreamReader("./Vendedor.txt");

            while (!srNumeroDeVendedor.EndOfStream)
            {
                string auxID = srNumeroDeVendedor.ReadLine();
                if (mskIDVendedor.Text == auxID.Substring(0, 3))
                {
                    MessageBox.Show("Codigo ya cargado, utilice otro");
                    bandera = true;
                }

            }
            srNumeroDeVendedor.Close();

            if (bandera == false)
            {
                //true es para que no sobreescriba el archivo 
                StreamWriter vendedor = new StreamWriter("./Vendedor.txt", true);
                vendedor.WriteLine(mskIDVendedor.Text + ";" + txtVendedor.Text + ";" + varActivo + ";" + varComision );
                MessageBox.Show("Vendedor cargado con éxito.");
                vendedor.Close();
                txtVendedor.Text = "";
                mskIDVendedor.Text = "";
                txtVendedor.Focus();
                chkActivo.Checked = false;
                chkComision.Checked = false;


            }
            

        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./Vendedor.txt");
            MessageBox.Show("El archivo fue borrado.");
        }
    }
}
