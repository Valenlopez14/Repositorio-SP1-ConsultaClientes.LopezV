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
    public partial class frmConsultaVentas : Form
    {
        public frmConsultaVentas()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader SrVentas = new StreamReader("./Ventas.txt");
            while (!SrVentas.EndOfStream)
            {
                string Ventas = SrVentas.ReadLine();
                string[] FacturaTipo = Ventas.Split(';');
                string[] id = Ventas.Split(';');
                string[] fecha = Ventas.Split(';');
                string[] ClienteId = Ventas.Split(';');
                string[] VendedorId = Ventas.Split(';');
                string[] Monto = Ventas.Split(';');

                GRLConsultaVentas.Rows.Add(Ventas[0], Ventas[1] , Ventas[2], Ventas[3], Ventas[4], Ventas[5], Ventas[6]);

            }
            SrVentas.Close();
        }
    }
}
