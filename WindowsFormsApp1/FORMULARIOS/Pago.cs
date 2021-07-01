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
    public partial class Pago : Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [IdPago],[TipoPago],[Moneda] FROM [Punta_El_Cacique1].[dbo].[Pago] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        private void Pago_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridPago.DataSource = llenar_Grid();
        }

        // Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string IdPago = txtpago.Text;
            string TipoPago = txtTipoPagoCB.Text;
            string Moneda = txtTipoMonedaCB.Text;

            if( (!IdPago.Equals("")) || (TipoPago.Equals("")) || (Moneda.Equals("")) )
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO Pago (TipoPago, Moneda) VALUES(@TipoPago, @Moneda)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@TipoPago", TipoPago);
                cmd1.Parameters.AddWithValue("@Moneda", Moneda);
                cmd1.ExecuteNonQuery();
                dataGridPago.DataSource = llenar_Grid();
                MessageBox.Show("Registro agregado con exito!");

            }
        }


        // Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdPago = txtpago.Text;
            string Moneda  = txtTipoPagoCB.Text;
            string TipoPago = txtTipoMonedaCB.Text;

            if ((TipoPago.Equals("")) || (Moneda.Equals("")))
            {
                MessageBox.Show("Registro no actualizado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string actualizar = "UPDATE Pago SET TipoPago = @TipoPago, Moneda = @Moneda WHERE IdPago = @IdPago";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@IdPago", IdPago);
                cmd2.Parameters.AddWithValue("@TipoPago", TipoPago);
                cmd2.Parameters.AddWithValue("@Moneda", Moneda);
                cmd2.ExecuteNonQuery();
                dataGridPago.DataSource = llenar_Grid();
                MessageBox.Show("Registro Actualizado con exito!");

            }



        }

        private void dataGridPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtpago.Text = dataGridPago.CurrentRow.Cells[0].Value.ToString();
                txtTipoMonedaCB.Text = dataGridPago.CurrentRow.Cells[1].Value.ToString();
                txtTipoPagoCB.Text = dataGridPago.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }


        // Eliminar 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtpago.Text;

            if(ID.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Pago WHERE IdPago = @IdPago";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdPago", ID);
                cmd3.ExecuteNonQuery();
                dataGridPago.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");

            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtpago.Text = "";
            txtTipoMonedaCB.Text = "";
            txtTipoPagoCB.Text = "";

        }
    }
}
