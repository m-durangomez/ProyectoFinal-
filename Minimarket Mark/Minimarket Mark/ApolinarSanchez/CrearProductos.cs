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
    public partial class CrearProductos : Form
    {
        conexion c = new conexion();
        public CrearProductos()
        {
            InitializeComponent();
        }

        private void CrearProductos_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBox11.Text = DateTime.Now.ToString("yyyy/MM/dd");
            if (textBox10.Text == "ADMINISTRADOR" | textBox10.Text == "INVENTRARISTA")
            {

                vENTASToolStripMenuItem.Enabled = true;

            }
            else
            {
                vENTASToolStripMenuItem.Enabled = false;
            }

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            c.Traerparticular(textBox1);
            double cantidad = Convert.ToDouble(textBox1.Text);
            cantidad++;
            textBox1.Text = cantidad.ToString();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | comboBox1.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" | textBox7.Text == "" | textBox8.Text == "" | textBox9.Text == "")
            {
                MessageBox.Show("NO DEBES DE DEJAR CAMPOS VACIOS.", "ADVERTENCIA!");

            }
            else
            {
                c.crearproductosusuario(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text, textBox9.Text, textBox5.Text, textBox6.Text,textBox11.Text);
                MessageBox.Show("Se Ha Creado El Producto.", "Mensaje!");
                CrearProductos fcrearproducto = new CrearProductos();
                fcrearproducto.textBox10.Text = textBox10.Text;
                txtalmacen.Text = txtalmacen.Text;
                fcrearproducto.Show();
                Hide();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "0.00")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;

            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "0.00";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "0.00")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;

            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "0.00";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
               
            }
            catch (Exception ex)
            {
              
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox4.Text != "" | textBox5.Text != "")
                {
                    double cantidad = Convert.ToDouble(this.textBox4.Text);
                    double compra = Convert.ToDouble(this.textBox5.Text);
                    double resultadocompra;
                    resultadocompra = cantidad * compra;
                    textBox7.Text = resultadocompra.ToString();
                }
                else
                {
                    textBox6.Text = "0";

                }

                if (textBox4.Text != "" | textBox6.Text != "")
                {
                    double cantidad = Convert.ToDouble(this.textBox4.Text);
                    double ventas = Convert.ToDouble(this.textBox6.Text);
                    double resultadoVentas;
                    resultadoVentas = cantidad * ventas;
                    textBox8.Text = resultadoVentas.ToString();

                }
                else
                {
                    textBox6.Text = "0";

                }
                string op = comboBox1.Text;

                switch (op)
                {
                    case "Docena":

                        double cantidad = Convert.ToDouble(this.textBox4.Text);

                        double  resultadocantidad = 0;
                        resultadocantidad= cantidad * 12;
                        textBox9.Text = resultadocantidad.ToString();

                        comboBox1.BackColor = Color.White;
                        break;
                    case "Unidad":

                        double cantidad1 = Convert.ToDouble(this.textBox4.Text);

                        double resultadocantidad1 = 0;
                        resultadocantidad1 = cantidad1 * 1;
                        textBox9.Text = resultadocantidad1.ToString();

                        comboBox1.BackColor = Color.White;
                        break;

                    case "Media Docena":

                        double cantidad2 = Convert.ToDouble(this.textBox4.Text);

                        double resultadocantidad2 = 0;
                        resultadocantidad2 = cantidad2 * 6;
                        textBox9.Text = resultadocantidad2.ToString();

                        comboBox1.BackColor = Color.White;
                        break;



                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("Llene Los Campos Correctamente.", "ADVERTENCIA.");
            
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            

        }
       

        private void CrearProductos_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CrearProductos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mANTENIMIENTODEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mANTENIMIENTODEPRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void cAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cAJAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Ventas fventas = new Ventas();
            fventas.textBox11.Text = textBox10.Text;
            fventas.Show();
            Hide();
        }

        private void mANTENIMIENTODEPRODUCTOSToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form1 fmantenimiento = new Form1();
            fmantenimiento.textBox9.Text = textBox10.Text;
            fmantenimiento.Show();
            Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inicio FNINICIO = new Inicio();
            FNINICIO.textBox1.Text = textBox10.Text;
            FNINICIO.Show();
            Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private void CrearCredito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    }
}
