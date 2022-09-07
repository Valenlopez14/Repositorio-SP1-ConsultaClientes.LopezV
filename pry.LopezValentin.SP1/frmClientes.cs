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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
         

            //Verificar que no se repitan los numeros id cargados
            bool bandera = false;
            StreamReader srNumeroDeCliente = new StreamReader("./clientes.txt");

            while (!srNumeroDeCliente.EndOfStream)
            {
                string auxID = srNumeroDeCliente.ReadLine();
                if (mskIDClientes.Text == auxID.Substring(0,4))
                {
                    MessageBox.Show("Codigo ya cargado, utilice otro");
                    bandera = true;
                }

            }
            srNumeroDeCliente.Close();

            if (bandera == false)
            {
                StreamWriter clientes = new StreamWriter("./clientes.txt", true);
                clientes.WriteLine(mskIDClientes.Text + ";" + txtClientes.Text);
                MessageBox.Show("Cliente cargado con éxito.");
                clientes.Close();
                txtClientes.Text = "";
                mskIDClientes.Text = "";
                txtClientes.Focus();

            }




        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            File.Delete("./clientes.txt");
            MessageBox.Show("Archivo borrado con éxito.");
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
