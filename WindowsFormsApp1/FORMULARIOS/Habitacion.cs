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
    public partial class Habitacion : Form
    {
        public Habitacion()
        {
            InitializeComponent();
        }

        private void Habitacion_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridHabitacion.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [NumHabitacion] ,[IdCliente_FK],[TipoHabitacion],[PrecioHabitacion] FROM [Punta_El_Cacique1].[dbo].[habitacion] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // INSERT

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdCliente = txtIdCliente.Text;
            string Numhabitacion = txtNumHabitacion.Text;
            string tipoHabitacion = txtTipoHabitacionCB.Text;
            string PrecioHabitacion = txtPrecioHabitacionCB.Text;

            if ((IdCliente.Equals("")) ||  (tipoHabitacion.Equals("")) || (PrecioHabitacion.Equals("")))
            {
                MessageBox.Show("Ingrese valores correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO habitacion (IdCliente_FK, TipoHabitacion, PrecioHabitacion) VALUES(@IdCliente_FK, @TipoHabitacion, @PrecioHabitacion)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@IdCliente_FK", IdCliente);
                cmd1.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion);
                cmd1.Parameters.AddWithValue("@PrecioHabitacion", PrecioHabitacion);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Producto agregado con exito!");
                dataGridHabitacion.DataSource = llenar_Grid();

            }
        }

        // UPDATE
        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string IdCliente = txtIdCliente.Text;
            string Numhabitacion = txtNumHabitacion.Text;
            string tipoHabitacion = txtTipoHabitacionCB.Text;
            string PrecioHabitacion = txtPrecioHabitacionCB.Text;

            if ( (Numhabitacion.Equals("")) || (IdCliente.Equals("")) || (tipoHabitacion.Equals("")) || (PrecioHabitacion.Equals("")))
            {
                MessageBox.Show("Ingrese valores correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string actualizar = "UPDATE habitacion SET TipoHabitacion = @TipoHabitacion, PrecioHabitacion = @PrecioHabitacion  WHERE NumHabitacion = @NumHabitacion";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@NumHabitacion", Numhabitacion);
                cmd2.Parameters.AddWithValue("@TipoHabitacion", tipoHabitacion);
                cmd2.Parameters.AddWithValue("@PrecioHabitacion", PrecioHabitacion);
                cmd2.ExecuteNonQuery();
                dataGridHabitacion.DataSource = llenar_Grid();
                MessageBox.Show("Registro Actualizado");
            }

        }

        private void dataGridHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdCliente.Text = dataGridHabitacion.CurrentRow.Cells[0].Value.ToString();
                txtNumHabitacion.Text = dataGridHabitacion.CurrentRow.Cells[1].Value.ToString();
                txtPrecioHabitacionCB.Text = dataGridHabitacion.CurrentRow.Cells[2].Value.ToString();
                txtTipoHabitacionCB.Text = dataGridHabitacion.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }


        // DELETE
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IdCliente = txtIdCliente.Text;
            string Numhabitacion = txtNumHabitacion.Text;
            string tipoHabitacion = txtTipoHabitacionCB.Text;
            string PrecioHabitacion = txtPrecioHabitacionCB.Text;
            if ((Numhabitacion.Equals("")) || (IdCliente.Equals("")) || (tipoHabitacion.Equals("")) || (PrecioHabitacion.Equals("")))
            {
                MessageBox.Show("Selecione nuevamente el Registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM habitacion WHERE NumHabitacion = @NumHabitacion";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@NumHabitacion", IdCliente);
                cmd3.ExecuteNonQuery();
                dataGridHabitacion.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");

            }
        }
    }
}
