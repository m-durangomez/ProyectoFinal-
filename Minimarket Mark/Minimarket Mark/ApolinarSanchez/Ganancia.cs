using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApolinarSanchez
{
    public partial class Ganancia : Form
    {
        public Ganancia()
        {
            InitializeComponent();
        }

        private void Ganancia_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Ganan.Ventas' Puede moverla o quitarla según sea necesario.
            this.VentasTableAdapter.traerganancias(this.Ganan.Ventas,txtfecha1.Text,txtfecha2.Text);
            // TODO: esta línea de código carga datos en la tabla 'DatosInventario.Inventario' Puede moverla o quitarla según sea necesario.
          
            // TODO: esta línea de código carga datos en la tabla 'Ganan.Ventas' Puede moverla o quitarla según sea necesario.
         
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtfecha1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
