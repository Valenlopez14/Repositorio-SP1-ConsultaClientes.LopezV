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
                

                GRLConsultaVentas.Rows.Add(FacturaTipo[0], FacturaTipo[1] , FacturaTipo[2], FacturaTipo[3], FacturaTipo[4], FacturaTipo[5]);

            }
            SrVentas.Close();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            GRLConsultaVentas.Rows.Clear();
        }
    }
}
