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
    public partial class FacturaCompra : Form
    {
        public FacturaCompra()
        {
            InitializeComponent();
        }

        private void FacturaCompra_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            datagridFacturaCompra.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT NumFacturaCompra,IdEmpleado_FK,IdDetalleCompra_Fk,FechaCompra FROM [Punta_El_Cacique1].[dbo].[FacturaCompra] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NumFacturaCompra = txtNumeroFactura.Text;
            string IdEmpleado = txtCodigoEmpleado.Text;
            string IdDetalleCompra = txtDetalleCompra.Text;
            string year = txtYEAR.Text;
            string mes = txtMES.Text;
            string dia = txtDIA.Text;


            if ((IdEmpleado.Equals("")) || (IdDetalleCompra.Equals("")) || (year.Equals("")) || (dia.Equals("")) || (mes.Equals("")) )
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if(year.Length < 4)
                {
                    MessageBox.Show("Ingresa el año con un formato de 4 digitos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int a = int.Parse(year);
                int b = int.Parse(mes);
                int c = int.Parse(dia);
                DateTime fecha = new DateTime(a,b,c);
                Conexion.Conectar();
                string insertar = "INSERT INTO FacturaCompra (IdEmpleado_FK, IdDetalleCompra_Fk, FechaCompra) VALUES (@IdEmpleado_FK, @IdDetalleCompra_Fk, @FechaCompra)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@IdEmpleado_FK", IdEmpleado);
                cmd1.Parameters.AddWithValue("@IdDetalleCompra_Fk", IdDetalleCompra);
                cmd1.Parameters.AddWithValue("@FechaCompra", fecha);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Registro agregado con exito!");
                datagridFacturaCompra.DataSource = llenar_Grid();

            }
        }

        private void datagridFacturaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNumeroFactura.Text = datagridFacturaCompra.CurrentRow.Cells[0].Value.ToString();
                txtCodigoEmpleado.Text = datagridFacturaCompra.CurrentRow.Cells[1].Value.ToString();
                txtDetalleCompra.Text = datagridFacturaCompra.CurrentRow.Cells[2].Value.ToString();
                string fecha_s = datagridFacturaCompra.CurrentRow.Cells[3].Value.ToString();
                char delimitador = '/';
                string[] valores = fecha_s.Split(delimitador);

                // Setiando la year
                string aux = valores[2];
                string year = aux[0] + "" + aux[1] + "" + aux[2] + "" + aux[3];

                txtYEAR.Text = year;
                txtMES.Text = valores[1];
                txtDIA.Text = valores[0];

            }
            catch
            {

            }
        }

        // UPDATE
        private void button2_Click(object sender, EventArgs e)
        {
            string NumFacturaCompra = txtNumeroFactura.Text;
            string IdEmpleado = txtCodigoEmpleado.Text;
            string IdDetalleCompra = txtDetalleCompra.Text;
            string year = txtYEAR.Text;
            string mes = txtMES.Text;
            string dia = txtDIA.Text;
            if ( (NumFacturaCompra.Equals("")) || (IdEmpleado.Equals("")) || (IdDetalleCompra.Equals("")) || (year.Equals("")) || (dia.Equals("")) || (mes.Equals("")))
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (year.Length < 4)
                {
                    MessageBox.Show("Ingresa el año con un formato de 4 digitos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                int a = int.Parse(year);
                int b = int.Parse(mes);
                int c = int.Parse(dia);
                DateTime fecha = new DateTime(a, b, c);

                Conexion.Conectar();
                string actualizar = "UPDATE FacturaCompra SET  FechaCompra = @FechaCompra WHERE NumFacturaCompra = @NumFacturaCompra";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@NumFacturaCompra", NumFacturaCompra);
                cmd2.Parameters.AddWithValue("FechaCompra", fecha);
                cmd2.ExecuteNonQuery();
                datagridFacturaCompra.DataSource = llenar_Grid();
                MessageBox.Show("Registro Actualizado con exito!");

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ID = txtNumeroFactura.Text;

            if (ID.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM FacturaCompra WHERE NumFacturaCompra = @NumFacturaCompra";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@NumFacturaCompra", ID);
                cmd3.ExecuteNonQuery();
                datagridFacturaCompra.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtNumeroFactura.Text = "";
            txtCodigoEmpleado.Text = "";
            txtDetalleCompra.Text = "";
            txtYEAR.Text = "";
            txtMES.Text = "";
            txtDIA.Text = "";

        }
    }
}
