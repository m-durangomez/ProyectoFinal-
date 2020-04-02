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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void mANTENIMIENTODEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearProductos Fcrear = new CrearProductos();
            Fcrear.textBox10.Text = textBox1.Text;
            Fcrear.Show();
            Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (textBox1.Text == "INVENTARISTA" | textBox1.Text == "ADMINISTRADOR")
            {
                cREARPRODUCTOSToolStripMenuItem.Enabled = true;
                rEPORTESToolStripMenuItem.Enabled = true;
            }

            else if (textBox1.Text == "CAJERA" | textBox1.Text == "ADMINISTRADOR") 
            {
                cAJAToolStripMenuItem.Enabled = true;
            
            }
            else
            {
                cREARPRODUCTOSToolStripMenuItem.Enabled = false;
                rEPORTESToolStripMenuItem.Enabled = false;
                cAJAToolStripMenuItem.Enabled = false;
            }

           
        }

        private void mANTENIMIENTODEPRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 FMANTENIMIENTO = new Form1();
            FMANTENIMIENTO.textBox9.Text = textBox1.Text;
            FMANTENIMIENTO.Show();
            Hide();
        }

        private void cREARPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cAJAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas FVENTAS = new Ventas();
            FVENTAS.textBox11.Text = textBox1.Text;
            FVENTAS.Show();
            Hide();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "INVENTARISTA" | textBox1.Text == "ADMINISTRADOR")
            {
                cREARPRODUCTOSToolStripMenuItem.Enabled = true;
                rEPORTESToolStripMenuItem.Enabled = true;
            }

            else if (textBox1.Text == "CAJERA" | textBox1.Text == "ADMINISTRADOR")
            {
                cAJAToolStripMenuItem.Enabled = true;

            }
            else
            {
                cREARPRODUCTOSToolStripMenuItem.Enabled = false;
                rEPORTESToolStripMenuItem.Enabled = false;
                cAJAToolStripMenuItem.Enabled = false;
            }

        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuario FCREAR = new CrearUsuario();
            FCREAR.textBox4.Text = textBox1.Text;
            FCREAR.Show();
            Hide();
        }

        private void gANANCIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fganancia = new Reporteria();
            fganancia.Show();

        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RREPORTERIA = new Reporteria2();
            RREPORTERIA.Show();
        }

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void rEPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aRCHIVOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEVISIONDEFACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FVISTA = new Form2();
            FVISTA.Show();
        }

        private void pRODUCTOSCOMPLETOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRODUCTOSTODOS KLOK = new PRODUCTOSTODOS();
            KLOK.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString();
            lblfecha.Text = DateTime.Now.ToLongDateString();
        }
    }

      
}
