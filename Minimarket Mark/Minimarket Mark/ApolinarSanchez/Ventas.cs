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
    public partial class Ventas : Form
    {
        conexion c = new conexion();
        DateTime FECHA = new DateTime();
        public Ventas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            dtgDesglose.Rows.Clear();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            
            
            c.llenarTextboxConsulta(textBox1);
            double cantidad1 = Convert.ToDouble(textBox1.Text);
            cantidad1++;
            textBox1.Text = Convert.ToString(cantidad1);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            c.duplicidadventas(textBox2.Text, textBox3, textBox4, textBox5,textBox6, textBox8);
            if (textBox8.Text == "0")
            {

                textBox7.Enabled = false;
                textBox7.Text = "0";

            }
           
            else
            {
                textBox7.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox7.Text == "0")
                {

                    MessageBox.Show("Este producto no tiene existencia.", "ADVERTENCIA!");
                    textBox7.Text = "0";

                }
                else if (textBox1.Text == "" | textBox2.Text == "" | textBox3.Text == "" | textBox4.Text == "" | textBox5.Text == "" | textBox6.Text == "" | textBox8.Text == "" | textBox7.Text == "")
                {

                    MessageBox.Show("No debe de dejar campos vacio.", "ADVERTENCIA!");
                }
             
                else
                {
                    Int32 MESES = 1;
                    for (int I = 1; I < MESES + 1; I = I + 1)
                    {
                        DateTime FFecha;
                        FFecha = Convert.ToDateTime(this.time.Value.ToString());
                        FECHA = DateTime.Parse(FFecha.ToString());
                        FECHA.AddMonths(I - 1).ToShortDateString();


                        double cantidad = Convert.ToDouble(textBox7.Text);
                        double existencia = Convert.ToDouble(textBox8.Text);

                        double totalcantidad1 = 0;
                        totalcantidad1 = existencia - cantidad;

                        double ITBIS = 0.00;
                       
                    
                        double precio = Convert.ToDouble(textBox6.Text);
                        double totalcantidad = Convert.ToDouble(textBox7.Text);
                        double total = 0;
                        if (existencia < cantidad)
                        {

                            MessageBox.Show("No hay esta cantidad disponible.", "ADVERTENCIA!");
                            textBox7.Text = "";

                        }
                        else
                        {
                            total = totalcantidad * precio;
                            textBox9.Text = totalcantidad1.ToString();
                            textBox10.Text = total.ToString();
                            dtgDesglose.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, FECHA.AddMonths(I - 1).ToString("yyyy/MM/dd"), ITBIS, FECHA.AddMonths(I - 999).ToString("yyyy/MM/dd"), textBox9.Text, textBox10.Text);
                        }
                        foreach (DataGridViewRow row in dtgDesglose.Rows)
                        {
                            //  row.Cells[dtgDesglose.Columns["totalprecio"].Index].Value=(Convert.ToDouble(row.Cells[dtgDesglose.Columns[]]));

                        }
                        double total2020 = 0;
                        for (int i = 0; i < dtgDesglose.Rows.Count - 0; i++)
                        {

                            total2020 += int.Parse(dtgDesglose.Rows[i].Cells[11].Value.ToString());
                            textBox13.Text = total2020.ToString();

                        }
                        
                        textBox8.Text = textBox9.Text;
                      

                    }


                }
            }
            catch (Exception ex) 
            {
            
                   MessageBox.Show("Has Introducido datos Erroneos.","AVISO!");
            
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dtgDesglose_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
            



        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                
            }
            c.insertar(dtgDesglose);
            c.updateexistenciaventas(textBox9.Text,textBox2.Text,textBox3.Text);
            Factura FFACTURA = new Factura();
            FFACTURA.textBox1.Text = textBox1.Text;
            FFACTURA.Show();

            double cantidad = Convert.ToDouble(textBox1.Text);
            cantidad++;
            textBox1.Text = cantidad.ToString();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
           
            
            dtgDesglose.Rows.Clear();
           
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicio FINICIO = new Inicio();
            FINICIO.textBox1.Text = textBox11.Text;
            FINICIO.Show();
            Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgDesglose_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dtgDesglose.Rows)
            {
                //  row.Cells[dtgDesglose.Columns["totalprecio"].Index].Value=(Convert.ToDouble(row.Cells[dtgDesglose.Columns[]]));

            }
            double total2020 = 0;
            foreach (DataGridViewRow row in dtgDesglose.Rows)
            {

                total2020 += Convert.ToDouble(row.Cells["TotalPrecio"].Value);
                
            }

            textBox13.Text = Convert.ToString(total2020);
            textBox10.Text="";
            textBox9.Text = "";
         

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
          
        }

        private void CrearCredito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ventas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
