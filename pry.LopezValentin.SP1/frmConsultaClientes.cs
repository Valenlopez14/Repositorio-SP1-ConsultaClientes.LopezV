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
    public partial class frmConsultaClientes : Form
    {
        public frmConsultaClientes()
        {
            InitializeComponent();
        }

        private void GRLClientes_CellContentClick(object sender, DataGridViewCellEventArgs tabla, char caracter, string ruta)
        {
         
        }
        class leer
        {

            private void frmConsultaClientes_Load(DataGridView tabla, char caracteres, string ruta)
            {
               

              
            }

        }

        private void frmConsultaClientes_Load_1(object sender, EventArgs e)
        {
           
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click_1(object sender, EventArgs e)
        {
            StreamReader clientes = new StreamReader("./clientes.txt");
            while (!clientes.EndOfStream)
            {
                string ID = clientes.ReadLine();
                string[] Clientes = ID.Split((';'));
                GRLConsultaClientes.Rows.Add(Clientes[0], Clientes[1]);
            }
            clientes.Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            GRLConsultaClientes.Rows.Clear();
        }
    }
}
