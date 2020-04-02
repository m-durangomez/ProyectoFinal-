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
    public partial class Reporteria : Form
    {
        conexion c = new conexion();
        public Reporteria()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Ganancia rporte = new Ganancia();
            rporte.txtfecha1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            textBox1.Text = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            rporte.txtfecha2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            textBox2.Text = dateTimePicker2.Value.ToString("yyyy/MM/dd");
            c.reportefecha1(textBox1.Text, textBox2.Text);
            rporte.Show();
        
        }

        private void Reporteria_Load(object sender, EventArgs e)
        {

        }
    }
}
