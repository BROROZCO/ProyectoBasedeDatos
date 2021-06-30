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
    public partial class DetalleCompra : Form
    {
        public DetalleCompra()
        {
            InitializeComponent();
        }

        private void DetalleCompra_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            datagridDetalleCompra.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT IdDetalleCompra, IdProveedor_FK, IdInsumo_FK, CantProductoCompra, MontoProductoCompra FROM DetalleCompra";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdDetalleCompra = txtIdDetalleCompra.Text;
            string IdProveedor_FK = txtIdProveedor.Text;
            string IdInsumo_FK = txtIdInsumo.Text;
            string CantProductoCompra = txtCantidadProducto.Text;
            string MontoProductoCompra = txtMontoProductoCompra.Text;

            if( (IdProveedor_FK.Equals("")) || (IdInsumo_FK.Equals("")) || (CantProductoCompra.Equals("")) || (MontoProductoCompra.Equals("")) )
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO DetalleCompra (IdProveedor_FK, IdInsumo_FK, CantProductoCompra, MontoProductoCompra) VALUES (@IdProveedor_FK, @IdInsumo_FK, @CantProductoCompra, @MontoProductoCompra)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@IdProveedor_FK", IdProveedor_FK);
                cmd1.Parameters.AddWithValue("@IdInsumo_FK", IdInsumo_FK);
                cmd1.Parameters.AddWithValue("@CantProductoCompra", CantProductoCompra);
                cmd1.Parameters.AddWithValue("@MontoProductoCompra", MontoProductoCompra);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Nuevo Registro");
                datagridDetalleCompra.DataSource = llenar_Grid();
            }
        }

        private void datagridDetalleCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdDetalleCompra.Text = datagridDetalleCompra.CurrentRow.Cells[0].Value.ToString();
                txtIdProveedor.Text = datagridDetalleCompra.CurrentRow.Cells[1].Value.ToString();
                txtIdInsumo.Text = datagridDetalleCompra.CurrentRow.Cells[2].Value.ToString();
                txtCantidadProducto.Text = datagridDetalleCompra.CurrentRow.Cells[3].Value.ToString();
                txtMontoProductoCompra.Text = datagridDetalleCompra.CurrentRow.Cells[4].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdDetalleCompra = txtIdDetalleCompra.Text;
            string IdProveedor_FK = txtIdProveedor.Text;
            string IdInsumo_FK = txtIdInsumo.Text;
            string CantProductoCompra = txtCantidadProducto.Text;
            string MontoProductoCompra = txtMontoProductoCompra.Text;

            if ( (IdDetalleCompra.Equals("")) || (IdProveedor_FK.Equals("")) || (IdInsumo_FK.Equals("")) || (CantProductoCompra.Equals("")) || (MontoProductoCompra.Equals("")))
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                Conexion.Conectar();
                string actualizar = "UPDATE DetalleCompra SET  CantProductoCompra = @CantProductoCompra, MontoProductoCompra = @MontoProductoCompra  WHERE IdDetalleCompra = @IdDetalleCompra";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@CantProductoCompra", CantProductoCompra);
                cmd2.Parameters.AddWithValue("@MontoProductoCompra", MontoProductoCompra);
                cmd2.Parameters.AddWithValue("@IdDetalleCompra", IdDetalleCompra);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado");
                datagridDetalleCompra.DataSource = llenar_Grid();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtIdDetalleCompra.Text;
            if (ID.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM DetalleCompra WHERE IdDetalleCompra = @IdDetalleCompra";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdDetalleCompra", ID);
                cmd3.ExecuteNonQuery();
                datagridDetalleCompra.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");
            }
        }
    }
}
