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
    public partial class Form1 : Form
    {
        conexion c = new conexion();
        Validacion v = new Validacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
           
          
        {
           // c.buscar(dataGridView1, textBox1.Text);
            
            textBox10.Text = DateTime.Now.ToString("yyyy/MM/dd");
            if (textBox9.Text == "ADMINISTRADOR" | textBox9.Text == "INVENTRARISTA")
            {

                vENTASToolStripMenuItem.Enabled = true;

            }
            else
            {
                vENTASToolStripMenuItem.Enabled = false;
            }

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
           
        }

     
      



        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

       
        private void CrearProductos_FormClosed(object sender, FormClosedEventArgs e)
        {

            DialogResult r = MessageBox.Show("Quiere salir de sistema?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;

            textBox4.Enabled = true;
            textBox1.Enabled = true;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            button3.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;

            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            comboBox1.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
            c.duplicidad(textBox1.Text, textBox2, textBox3, comboBox1, textBox5, textBox6, textBox7);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            c.eliminarProducto(textBox1.Text, textBox2.Text);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox1.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" )
            {
                MessageBox.Show("NO DEBES DE DEJAR CAMPOS VACIOS.", "ADVERTENCIA!");

            }
            else
            {
                c.updateexistencia(textBox8.Text, textBox1.Text, textBox2.Text,textBox10.Text);
                MessageBox.Show("MANTENIMIENTO REALIZADO CON EXITOS.", "MENSAJE!");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            v.soloNumeros(e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox1.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" | textBox7.Text == "" )
            {
                MessageBox.Show("NO DEBES DE DEJAR CAMPOS VACIOS.", "ADVERTENCIA!");

            }
            else
            {
                double cantidad = Convert.ToDouble(this.textBox4.Text);
                double compra = Convert.ToDouble(this.textBox7.Text);
                double resultadocompra;
                resultadocompra = cantidad + compra;
                textBox8.Text = resultadocompra.ToString();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox1.Text == ""  | textBox5.Text == "" | textBox6.Text == "" | textBox7.Text == "")
            {
                MessageBox.Show("NO DEBES DE DEJAR CAMPOS VACIOS.", "ADVERTENCIA!");

            }
            else
            {
                c.updateproducto(textBox2.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox1.Text);
                MessageBox.Show("Se ha modificado el producto.", "Mensaje!");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Inicio FNINICIO = new Inicio();
            FNINICIO.textBox1.Text = textBox9.Text;
            FNINICIO.Show();
            Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            c.observar(dataGridView1, textBox11.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox11_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void mANTENIMIENTODEPRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CrearProductos Fcrear = new CrearProductos();
            Fcrear.textBox10.Text = textBox9.Text;
            Fcrear.Show();
            Hide();
        }
    }
}
