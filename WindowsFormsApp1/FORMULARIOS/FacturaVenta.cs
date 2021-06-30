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
    public partial class FacturaVenta : Form
    {
        public FacturaVenta()
        {
            InitializeComponent();
        }

        private void FacturaVenta_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            datagridFacturaVenta.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT NumFacturaVenta, IdDetalleVenta_FK, IdCliente_FK, IdEmpleado_Fk, FechaVenta ,TipoVenta FROM FacturaVenta GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string NumFacturaVenta = txtNumFacturaVenta.Text;
            string IdDetalleVenta = txtIdDetalleVenta.Text;
            string IdCliente = txtIdCliente.Text;
            string IdEmpleado = txtIdEmpledo.Text;
            DateTime hoy = DateTime.Today;
            string TipoVenta = txtTipoVenta.Text;

            if(  (IdDetalleVenta.Equals("")) || (IdCliente.Equals("")) || (IdEmpleado.Equals("")) || (TipoVenta.Equals("")) )
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO FacturaVenta (IdDetalleVenta_FK, IdCliente_FK, IdEmpleado_Fk, FechaVenta ,TipoVenta) VALUES (@IdDetalleVenta_FK, @IdCliente_FK, @IdEmpleado_Fk, @FechaVenta ,@TipoVenta)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@IdDetalleVenta_FK", IdDetalleVenta);
                cmd1.Parameters.AddWithValue("@IdCliente_FK", IdCliente);
                cmd1.Parameters.AddWithValue("@IdEmpleado_Fk", IdEmpleado);
                cmd1.Parameters.AddWithValue("@FechaVenta", hoy);
                cmd1.Parameters.AddWithValue("@TipoVenta", TipoVenta);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Nuevo Registro");
                datagridFacturaVenta.DataSource = llenar_Grid();

            }

            
        }

        // Update
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string NumFacturaVenta = txtNumFacturaVenta.Text;
            string IdDetalleVenta = txtIdDetalleVenta.Text;
            string IdCliente = txtIdCliente.Text;
            string IdEmpleado = txtIdEmpledo.Text;
            DateTime hoy = DateTime.Today;
            string TipoVenta = txtTipoVenta.Text;

            if ( (NumFacturaVenta.Equals("")) || (IdDetalleVenta.Equals("")) || (IdCliente.Equals("")) || (IdEmpleado.Equals("")) || (TipoVenta.Equals("")))
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string actualizar = "UPDATE FacturaVenta SET  TipoVenta = @TipoVenta WHERE NumFacturaVenta = @NumFacturaVenta";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@TipoVenta",TipoVenta);
                cmd2.Parameters.AddWithValue("@NumFacturaVenta", NumFacturaVenta);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                datagridFacturaVenta.DataSource = llenar_Grid();
            }

        }

        private void datagridFacturaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumFacturaVenta.Text = datagridFacturaVenta.CurrentRow.Cells[0].Value.ToString();
                txtIdDetalleVenta.Text = datagridFacturaVenta.CurrentRow.Cells[1].Value.ToString();
                txtIdCliente.Text = datagridFacturaVenta.CurrentRow.Cells[2].Value.ToString();
                txtIdEmpledo.Text = datagridFacturaVenta.CurrentRow.Cells[3].Value.ToString();
                txtFecha.Text = datagridFacturaVenta.CurrentRow.Cells[4].Value.ToString();
                txtTipoVenta.Text = datagridFacturaVenta.CurrentRow.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtNumFacturaVenta.Text;

            if (ID.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM FacturaVenta WHERE NumFacturaVenta = @NumFacturaVenta";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@NumFacturaVenta", ID);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado");
                datagridFacturaVenta.DataSource = llenar_Grid();

            }

        }
    }
}
