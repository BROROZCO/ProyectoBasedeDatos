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
    public partial class Proveedor : Form
    {
        public Proveedor()
        {
            InitializeComponent();
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGriDProveedor.DataSource = llenar_Grid();
        }
        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [IdProveedor],[NombreEmpresa],[Telefono],[direccion],[NombreEncargado] FROM [Punta_El_Cacique1].[dbo].[Proveedor] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingresa Solo Caracteres Numericos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdProveedor = txtProvedor.Text;
            string NombreEmpresa = txtNombreEmpresa.Text;
            string NombreEncargado = txtNombreEncargado.Text;
            string Telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;

            if( (NombreEmpresa.Equals(""))  || (NombreEncargado.Equals("")) || (Telefono.Equals("")) || (Direccion.Equals("")) )
            {
                MessageBox.Show("Faltan Datos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO Proveedor (NombreEmpresa, Telefono, direccion, NombreEncargado) VALUES(@NombreEmpresa, @Telefono, @direccion, @NombreEncargado)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                cmd1.Parameters.AddWithValue("@Telefono", Telefono);
                cmd1.Parameters.AddWithValue("@direccion", Direccion);
                cmd1.Parameters.AddWithValue("@NombreEncargado", NombreEncargado);
                cmd1.ExecuteNonQuery();
                dataGriDProveedor.DataSource = llenar_Grid();
                MessageBox.Show("Producto agregado con exito!");

            }


        }

        private void dataGriDProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtProvedor.Text = dataGriDProveedor.CurrentRow.Cells[0].Value.ToString();
                txtNombreEmpresa.Text = dataGriDProveedor.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = dataGriDProveedor.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = dataGriDProveedor.CurrentRow.Cells[3].Value.ToString();
                txtNombreEncargado.Text = dataGriDProveedor.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        // Update
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdProveedor = txtProvedor.Text;
            string NombreEmpresa = txtNombreEmpresa.Text;
            string NombreEncargado = txtNombreEncargado.Text;
            string Telefono = txtTelefono.Text;
            string Direccion = txtDireccion.Text;
            if ((NombreEmpresa.Equals("")) || (NombreEncargado.Equals("")) || (Telefono.Equals("")) || (Direccion.Equals("")))
            {
                MessageBox.Show("Seleccione nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else 
            {
                Conexion.Conectar();
                string actualizar = "UPDATE Proveedor SET NombreEmpresa = @NombreEmpresa, Telefono = @Telefono, direccion = @direccion, NombreEncargado = @NombreEncargado  WHERE IdProveedor = @IdProveedor";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                cmd2.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                cmd2.Parameters.AddWithValue("@Telefono", Telefono);
                cmd2.Parameters.AddWithValue("@direccion", Direccion);
                cmd2.Parameters.AddWithValue("@NombreEncargado", NombreEncargado);
                cmd2.ExecuteNonQuery();
                dataGriDProveedor.DataSource = llenar_Grid();
                MessageBox.Show("Registro Actualizado");
            }
        }

        // Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IdProveedor = txtProvedor.Text;
            if(IdProveedor.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Proveedor WHERE IdProveedor = @IdProveedor";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdProveedor", IdProveedor);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Registro eliminado");
                dataGriDProveedor.DataSource = llenar_Grid();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtProvedor.Text = "";
            txtNombreEmpresa.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtNombreEncargado.Text = "";
        }
    }
}
