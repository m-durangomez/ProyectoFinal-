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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'Facturacion.Ventas' Puede moverla o quitarla según sea necesario.
            this.VentasTableAdapter.traerclientes(this.Facturacion.Ventas,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
