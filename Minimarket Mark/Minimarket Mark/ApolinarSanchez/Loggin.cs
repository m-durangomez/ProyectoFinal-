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
    public partial class Loggin : Form
    {

        conexion c = new conexion();
        public Loggin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Quiere salir de sistema?", "ADVERTENCIA", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c.tipousuario(textBox1.Text, textBox2.Text, textBox3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {



                if (textBox2.Text == "")
                {

                    DialogResult r = MessageBox.Show("No debe dejar campos vacios, Desea Intentarlo de nuevos?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        Form DEVUELVELOG = new Loggin();
                        DEVUELVELOG.Show();
                        Hide();


                    }
                    if (r == DialogResult.No)
                    {

                        Application.Exit();

                    }


                }


                if (textBox3.Text != "")
                {
                    c.logins(textBox1.Text, textBox2.Text);
                    Inicio admin = new Inicio();
                    admin.textBox1.Text = textBox3.Text;
                    admin.Show();
                    Hide();

                }

                else
                {
                    c.logins(textBox1.Text, textBox2.Text);

                    Hide();




                }




            }
            catch (Exception ex)
            {

            }
        }

        private void Loggin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                try
                {



                    if (textBox2.Text == "")
                    {

                        DialogResult r = MessageBox.Show("No debe dejar campos vacios, Desea Intentarlo de nuevos?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                        if (r == DialogResult.Yes)
                        {
                            Form DEVUELVELOG = new Loggin();
                            DEVUELVELOG.Show();
                            Hide();


                        }
                        if (r == DialogResult.No)
                        {

                            Application.Exit();

                        }


                    }


                    else if (textBox3.Text == "")
                    {
                        c.logins(textBox1.Text, textBox2.Text);

                        Hide();

                    }

                    else
                    {
                        c.logins(textBox1.Text, textBox2.Text);
                        Inicio admin = new Inicio();
                        admin.textBox1.Text = textBox3.Text;
                        admin.Show();
                        Hide();


                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
