using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.FORMULARIOS
{
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridProducto.DataSource = llenar_Grid_Cliente();
        }

        string ID_Global;
        string nombre;

        public DataTable llenar_Grid_Cliente()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [IdProducto], [NombreProducto], [PrecioProducto], [TipoProducto] FROM [Punta_El_Cacique1].[dbo].[Producto] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        // ACTUALIZAR
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                ID_Global = dataGridProducto.CurrentRow.Cells[0].Value.ToString();
                nombre = dataGridProducto.CurrentRow.Cells[1].Value.ToString();
                txtId.Text = dataGridProducto.CurrentRow.Cells[0].Value.ToString();
                txtNombreProducto.Text = dataGridProducto.CurrentRow.Cells[1].Value.ToString();
                txtPrecioProducto.Text = dataGridProducto.CurrentRow.Cells[2].Value.ToString();
                cmbTipoProducto.Text = dataGridProducto.CurrentRow.Cells[3].Value.ToString();
            }
            catch 
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        // Insert dela tabla Cliente
        private void BTNAGREGAR_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string NombreProducto = txtNombreProducto.Text;
            string PrecioProducto = txtPrecioProducto.Text;
            string TipoProducto = cmbTipoProducto.Text;

            if (NombreProducto.Equals(""))
            {
                MessageBox.Show("Ingresa Nombre del Producto ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (PrecioProducto.Equals(""))
            {
                MessageBox.Show("Ingresa Precio del Producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if(TipoProducto.Equals(""))
            {
                MessageBox.Show("Elige un tipo de Producto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                // TODO
                try
                {

                    float precioProducto = convertidor(PrecioProducto);

                    if (precioProducto < 0)
                    {
                        MessageBox.Show("El precio no pude ser negativo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        // TODO
                        

                        // Insert
                        Conexion.Conectar();
                        string insertar = "INSERT INTO Producto (NombreProducto, PrecioProducto, TipoProducto) VALUES(@NombreProducto, @PrecioProducto, @TipoProducto)";
                        SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                        cmd1.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                        cmd1.Parameters.AddWithValue("@PrecioProducto", precioProducto);
                        cmd1.Parameters.AddWithValue("@TipoProducto", TipoProducto);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado con exito!");
                        dataGridProducto.DataSource = llenar_Grid_Cliente();

                    }

                }catch (FormatException)
                {
                    MessageBox.Show("Precio de producto Incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
        

        private float convertidor(string x)
        {

            decimal precioProducto_ = decimal.Parse(x);
            precioProducto_ = decimal.Round(precioProducto_, 2, MidpointRounding.ToEven);

            string aux = precioProducto_.ToString();
            float a = float.Parse(aux);

            return a;
        }


        // Solo caracteres Numericos

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47 ) || (e.KeyChar >= 58 && e.KeyChar <= 255)) 
            {
                MessageBox.Show("Ingresa Solo Caracteres Numericos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        // Solo caracteres Alfabeticos

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
/*            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Caracteres Alfabeticos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
        }

        private void BNTMODIFICAR_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            int id = int.Parse(Id);
            string NombreProducto = txtNombreProducto.Text;
            string PrecioProducto = txtPrecioProducto.Text;
        //    float p = float.Parse(PrecioProducto);
            string TipoProducto = cmbTipoProducto.Text;


            if (Id.Equals(""))
            {
                MessageBox.Show("Selecciones Nuea mente el Registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (PrecioProducto.Equals(""))
            {
                Conexion.Conectar();
                string actualizar = "UPDATE Producto SET NombreProducto= @NombreProducto, TipoProducto = @TipoProducto WHERE IdProducto = @IdProducto";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@IdProducto", id);
                cmd2.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                cmd2.Parameters.AddWithValue("@TipoProducto", TipoProducto);
                cmd2.ExecuteNonQuery();
                dataGridProducto.DataSource = llenar_Grid_Cliente();
                MessageBox.Show("Registro Actualizado");

            }
            else if(NombreProducto.Equals(""))
            {
                

                // ROCORDAR VALIDAR PARSEO
                try
                {
                    float precioProducto = convertidor(PrecioProducto);
                    if (precioProducto < 0)
                    {
                        MessageBox.Show("Precio de producto Incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        Conexion.Conectar();
                        string actualizar = "UPDATE Producto SET PrecioProducto = @PrecioProducto, TipoProducto = @TipoProducto WHERE IdProducto = @IdProducto";
                        SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                        cmd2.Parameters.AddWithValue("@IdProducto", id);
                        cmd2.Parameters.AddWithValue("@PrecioProducto", precioProducto);
                        cmd2.Parameters.AddWithValue("@TipoProducto", TipoProducto);
                        cmd2.ExecuteNonQuery();
                        dataGridProducto.DataSource = llenar_Grid_Cliente();
                        MessageBox.Show("Registro Actualizado");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Precio de producto Incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }


            // TODO 

            // VALIDACIONES DE LOS OTROS CAMPOS VACIOS ESPERA

            /*            Conexion.Conectar();
                        string actualizar = "UPDATE Producto SET NombreProducto= @NombreProducto, PrecioProducto = @PrecioProducto, TipoProducto = @TipoProducto WHERE IdProducto = @IdProducto";
                        SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                        cmd2.Parameters.AddWithValue("@IdProducto", id);
                        cmd2.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                        cmd2.Parameters.AddWithValue("@PrecioProducto", p);
                        cmd2.Parameters.AddWithValue("@TipoProducto", TipoProducto);
                        cmd2.ExecuteNonQuery(); 
                        dataGridProducto.DataSource = llenar_Grid_Cliente();
                        MessageBox.Show("Registro Actualizado");*/

        }

        // ELIMINAR
        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;

            if (Id.Equals(""))
            {
                MessageBox.Show("Selecione un registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                try
                {
                    int id = int.Parse(Id);
                    Conexion.Conectar();
                    string eliminar = "DELETE FROM Producto WHERE IdProducto = @IdProducto";
                    SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                    cmd3.Parameters.AddWithValue("@IdProducto", id);
                    cmd3.ExecuteNonQuery();
                    dataGridProducto.DataSource = llenar_Grid_Cliente();
                    MessageBox.Show("Registro eliminado");

                }
                catch(FormatException)
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            }

            


        }
    }
}
