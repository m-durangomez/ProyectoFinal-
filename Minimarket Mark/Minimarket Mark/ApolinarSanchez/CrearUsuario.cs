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
    public partial class CrearUsuario : Form
    {
        conexion c = new conexion();
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio FINICIO = new Inicio();
            FINICIO.textBox1.Text = textBox4.Text;
            FINICIO.Show();
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c.contrase(textBox1.Text, textBox2, textBox3, comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" | comboBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "")
            {

                MessageBox.Show("No debes de dejar campos vacios.", "Mensaje");

            }
            else if (c.verificacionusuario(textBox1.Text) == 0)
            {

                if (textBox2.Text == textBox3.Text)
                {
                    c.crearusuario(textBox1.Text, textBox2.Text, comboBox1.Text);
                    MessageBox.Show("Usuario registrado.", "Mensaje");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";


                }


            }
            else
            {
                MessageBox.Show("EL nombre del usuario ya existe");


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.eliminarusuario(textBox1.Text);
            MessageBox.Show("Usuario Eliminado.", "Mensaje");
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text)
            {
                c.editar(textBox2.Text, textBox1.Text);
                MessageBox.Show("La contraseña fue modificada con exito.", "Mensaje");
            }

            else
            {

                MessageBox.Show("Las contraseñas no coinciden.", "Mensaje");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void CrearUsuario_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CrearCredito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CrearUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
