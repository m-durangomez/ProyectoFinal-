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
    public partial class PRODUCTOSTODOS : Form
    {
        conexion c = new conexion();
        public PRODUCTOSTODOS()
        {
            InitializeComponent();
        }

        private void PRODUCTOSTODOS_Load(object sender, EventArgs e)
        {
            c.buscar(dataGridView1, textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c.buscar1(dataGridView1, textBox1.Text);
        }
    }
}
