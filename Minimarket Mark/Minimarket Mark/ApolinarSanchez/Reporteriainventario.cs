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
    public partial class Reporteriainventario : Form
    {
        public Reporteriainventario()
        {
            InitializeComponent();
        }

        private void Reporteriainventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DatosInventario.Inventario' Puede moverla o quitarla según sea necesario.
            this.InventarioTableAdapter.traerinventario(this.DatosInventario.Inventario,txtfecha88.Text,txtfecha89.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
