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
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
        {
            InitializeComponent();
        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            datagridDetalleVenta.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT IdDetalleVenta, IdProducto_FK, Id_Pago_FK, CantidadProducto, MontoPago FROM DetalleVenta";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }


        // Evento para seleccionar
        private void datagridDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdDetalleVenta.Text = datagridDetalleVenta.CurrentRow.Cells[0].Value.ToString();
                txtIdProducto.Text = datagridDetalleVenta.CurrentRow.Cells[1].Value.ToString();
                txtIdPago.Text = datagridDetalleVenta.CurrentRow.Cells[2].Value.ToString();
                txtCantidadProducto.Text = datagridDetalleVenta.CurrentRow.Cells[3].Value.ToString();
                txtMontoPago.Text = datagridDetalleVenta.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {

            }

        }

        // Insertar
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string IdDetalleVenta = txtIdDetalleVenta.Text;
            string IdProducto_FK = txtIdProducto.Text;
            string Id_Pago_FK = txtIdPago.Text;
            string MontoPago = txtMontoPago.Text;
            string CantidadProducto = txtCantidadProducto.Text;

            if( (IdProducto_FK.Equals("")) || (Id_Pago_FK.Equals("")) || (MontoPago.Equals("")) || (CantidadProducto.Equals("")) )
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO DetalleVenta (IdProducto_FK, Id_Pago_FK, CantidadProducto, MontoPago) VALUES (@IdProducto_FK, @Id_Pago_FK, @CantidadProducto, @MontoPago)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@IdProducto_FK", IdProducto_FK);
                cmd1.Parameters.AddWithValue("@Id_Pago_FK", Id_Pago_FK);
                cmd1.Parameters.AddWithValue("@CantidadProducto", CantidadProducto);
                cmd1.Parameters.AddWithValue("@MontoPago", MontoPago);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con exito!");
                datagridDetalleVenta.DataSource = llenar_Grid();

            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdDetalleVenta = txtIdDetalleVenta.Text;
            string IdProducto_FK = txtIdProducto.Text;
            string Id_Pago_FK = txtIdPago.Text;
            string MontoPago = txtMontoPago.Text;
            string CantidadProducto = txtCantidadProducto.Text;

            if ((IdDetalleVenta.Equals("")) || (IdProducto_FK.Equals("")) || (Id_Pago_FK.Equals("")) || (MontoPago.Equals("")) || (CantidadProducto.Equals("")))
            {
                MessageBox.Show("Seleccione Nuevamente el Registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string actualizar = "UPDATE DetalleVenta SET  CantidadProducto = @CantidadProducto, MontoPago = @MontoPago  WHERE IdDetalleVenta = @IdDetalleVenta";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@CantidadProducto", CantidadProducto);
                cmd2.Parameters.AddWithValue("@MontoPago", MontoPago);
                cmd2.Parameters.AddWithValue("@IdDetalleVenta", IdDetalleVenta);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado!");
                datagridDetalleVenta.DataSource = llenar_Grid();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtIdDetalleVenta.Text;
            if (ID.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM DetalleVenta WHERE IdDetalleVenta = @IdDetalleVenta";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdDetalleVenta", ID);
                cmd3.ExecuteNonQuery();
                datagridDetalleVenta.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");
            }
        }
    }
}
