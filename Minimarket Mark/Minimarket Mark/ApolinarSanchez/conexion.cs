using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using ApolinarSanchez.Properties;
using System.Configuration;
namespace ApolinarSanchez
{
    class conexion
    {
        public static string ObtenerString()
        {
            return Settings.Default.NegocioPolinConnectionString;

        }
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        SqlDataAdapter da;


        public conexion()
        {
            try
            {
                cn = new SqlConnection(ObtenerString());
                cn.Open();

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se conecto con la base de datos" + ex.ToString());
            }


        }



        public string crearproductosusuario(string id, string descripcion, string marca, string tipocategoria, string cantidad, string preciocompra, string precioventa,string fecha)
        {
            string salida = "";
            try
            {
                cmd = new SqlCommand("Insert into Inventario (Id, Descripcion,Marca,tipocategoria,cantidad,preciocompra,precioventa,fecha) values(" + id + ",'" + descripcion + "','" + marca + "','" + tipocategoria + "'," + cantidad + ",'" + preciocompra + "','" + precioventa + "','"+fecha+"')", cn);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public void Traerparticular(TextBox textBox1)
        {
            try
            {
                cmd = new SqlCommand("select * from inventario ORDER BY Id DESC", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["Id"].ToString();



                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
      
        public string eliminarProducto(string Id, string descripcion)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("Delete Inventario where Id =" + Id + " and descripcion = '" + descripcion + "' ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se ha eliminado el producto", "Mensaje!");

            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;

        }
        public void duplicidad(string Id, TextBox textBox2, TextBox textBox3, ComboBox comboBox1, TextBox textBox5, TextBox textBox6, TextBox textBox7)
        {
            try
            {
                cmd = new SqlCommand("Select * from  Inventario where Id = '" + Id + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["descripcion"].ToString();
                    textBox3.Text = dr["marca"].ToString();
                    comboBox1.Text = dr["tipocategoria"].ToString();
                    textBox5.Text = dr["preciocompra"].ToString();
                    textBox6.Text = dr["precioventa"].ToString();
                    textBox7.Text = dr["cantidad"].ToString();


                }
                else
                {

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Debes Poner Letras. ", "Aviso!");
            }
        }
        public string updateexistencia(string cantidad, string Id1, string descripcion,string fecha)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Inventario set Cantidad = "+cantidad+",fecha = '"+fecha+"' where Id = " + Id1 + " and descripcion = '" + descripcion + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public string updateexistenciaventas(string cantidad, string Id1, string descripcion)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Inventario set Cantidad = " + cantidad + " where Id = " + Id1 + " and descripcion = '" + descripcion + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }

        public string updateproducto(string descripcion,string marca, string preciocompra, string precioventa,string Id1)
        {
            string salida = "Se actualizaron los datos";
            try
            {
                cmd = new SqlCommand("Update Inventario set Descripcion = '" + descripcion+ " ', marca='"+marca+"', preciocompra='"+preciocompra+"',precioventa = '"+precioventa+"'  where Id = "  + Id1 + " ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se actualizo" + ex.ToString();
            }
            return salida;
        }
        public void llenarTextboxConsulta(TextBox textBox1)
        {
            try
            {
                cmd = new SqlCommand("Select  * from ventas order by IdCliente desc ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox1.Text = dr["IdCliente"].ToString();
                 

                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public void duplicidadventas(string Id, TextBox textBox2, TextBox textBox3, TextBox textBox4, TextBox textBox5, TextBox textBox8)
        {
            try
            {
                cmd = new SqlCommand("Select * from  Inventario where Id = '" + Id + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox2.Text = dr["descripcion"].ToString();
                    textBox3.Text = dr["marca"].ToString();
                    textBox4.Text = dr["tipocategoria"].ToString();
                    textBox5.Text = dr["precioventa"].ToString();
                    textBox8.Text = dr["cantidad"].ToString();


                }
                else
                {

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No Debes Poner Letras. ", "Aviso!");
            }
        }

        public void insertar(DataGridView dtgDesglose)
        {

            cmd = new SqlCommand("insert into ventas values (@IdCliente,@IdProducto,@Descripcion,@Marca,@TipoCategoria,@Cantidad ,@PrecioVenta,@fechapagada,@ITBIS,@FECHAREPORTE,@FECHAREPORTE2)", cn);
            try
            {
                foreach (DataGridViewRow row in dtgDesglose.Rows)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@IdCliente", Convert.ToString(row.Cells["IdCliente"].Value));
                    cmd.Parameters.AddWithValue("@IdProducto", Convert.ToString(row.Cells["IdProducto"].Value));
                    cmd.Parameters.AddWithValue("@Descripcion", Convert.ToString(row.Cells["Descripcion"].Value));
                    cmd.Parameters.AddWithValue("@Marca", Convert.ToString(row.Cells["Marca"].Value));
                    cmd.Parameters.AddWithValue("@TipoCategoria", Convert.ToString(row.Cells["TipoCategoria"].Value));
                    cmd.Parameters.AddWithValue("@Cantidad", Convert.ToString(row.Cells["Cantidad"].Value));
                    cmd.Parameters.AddWithValue("@PrecioVenta", Convert.ToString(row.Cells["PrecioVenta"].Value));
                    cmd.Parameters.AddWithValue("@fechapagada", Convert.ToString(row.Cells["fechapagada"].Value));
                    cmd.Parameters.AddWithValue("@ITBIS", Convert.ToString(row.Cells["ITBIS"].Value));
                    cmd.Parameters.AddWithValue("@FECHAREPORTE", Convert.ToString(row.Cells["fechareporte"].Value));
                    cmd.Parameters.AddWithValue("@FECHAREPORTE2", Convert.ToString(row.Cells["fechareporte"].Value));
                  
                    cmd.ExecuteNonQuery();




                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Se inserto correctamente.", "Mensaje!");
        }

        public string logins(string nombre, string contraseña)
        {

            string salida = "";
            try
            {

                {

                    using (SqlCommand cmd = new SqlCommand("SELECT nombre, contraseña FROM USUARIO WHERE nombre='" + nombre + "' AND contraseña='" + contraseña + "' ", cn))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {


                            dr.Close();

                        }

                        else
                        {
                            DialogResult r = MessageBox.Show("Datos Incorrectos, Desea Intentarlo de nuevos?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                            if (r == DialogResult.Yes)
                            {
                                Form DEVUELVELOG = new Loggin();
                                DEVUELVELOG.Show();




                            }

                            if (r == DialogResult.No)
                            {
                                Application.Exit();


                            }

                            dr.Close();


                        }
                    }
                }


            }

            catch (Exception ex)
            {

            }
            return salida;


        }
        public void tipousuario(string nombre, string contraseña, TextBox textBox3)
        {
            try
            {
                cmd = new SqlCommand("Select * from  usuario where nombre = '" + nombre + "' and contraseña ='" + contraseña + "' ", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {


                    textBox3.Text = dr["Tipodeusuario"].ToString();

                }

                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public string crearusuario(string nombre, string contraseña, string tipo)
        {
            string salida = "";
            try
            {
                cmd = new SqlCommand("Insert into USUARIO (nombre, contraseña,tipodeusuario) values('" + nombre + "','" + contraseña + "','" + tipo + "')", cn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;

        }
        public string eliminarusuario(string nombre)
        {
            string salida = "Se elimino la persona";
            try
            {
                cmd = new SqlCommand("Delete USUARIO where nombre ='" + nombre + "'", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se elimino" + ex.ToString();
            }
            return salida;
        }
        public int editar(string contrase, string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("update usuario set contraseña = '" + contrase + "' where nombre  = '" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }
        public void contrase(string nombre, TextBox textBox2, TextBox textBox3, ComboBox comboBox1)
        {
            try
            {
                cmd = new SqlCommand("Select * from  usuario where nombre = '" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox2.Text = dr["contraseña"].ToString();
                    textBox3.Text = dr["contraseña"].ToString();
                    comboBox1.Text = dr["tipodeusuario"].ToString();

                }
                dr.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontar por : " + ex.ToString());
            }
        }
        public int verificacionusuario(string nombre)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from USUARIO where nombre ='" + nombre + "'", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return contador;
        }

        public string reportefecha(string reportefecha1, string reportefecha2)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update inventario set fecha1 = '" + reportefecha1 + "', fecha2 = '" + reportefecha2 + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }
        public string reportefecha1(string reportefecha1, string reportefecha2)
        {
            string salida = "Se se inserto";
            try
            {
                cmd = new SqlCommand("Update ventas set fechareporte = '" + reportefecha1 + "', fechareporte2 = '" + reportefecha2 + "' ", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

        public string buscar(DataGridView dataGridView1, string textBox1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id,descripcion,Marca,tipocategoria,cantidad,PrecioCompra,PrecioVenta FROM inventario order by id asc", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
        public string buscar1(DataGridView dataGridView1, string textBox1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT id,descripcion,Marca,tipocategoria,cantidad,PrecioCompra,PrecioVenta FROM inventario where descripcion like('"+textBox1+"%') order by id asc", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }
        public string observar(DataGridView dataGridView1, string textBox1)
        {
            string salida = "Wtf";
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter("select id, descripcion from Inventario where Descripcion like ('"+textBox1+"%')", cn);
                DataTable data = new DataTable();

                sda.Fill(data);
                dataGridView1.DataSource = data;


                dr.Close();
            }




            catch (Exception ex)
            {

            }
            return salida;


        }

    }

}
