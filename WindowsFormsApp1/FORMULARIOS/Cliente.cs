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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridCliente.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [IdCliente], [Nombre], [Apellido], [Cedula] FROM [Punta_El_Cacique1].[dbo].[Cliente] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        // Insert
        private void button1_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Cedula = txtCedula.Text;

            if( (Nombre.Equals("")) || (Apellido.Equals("")) || (Cedula.Equals("")) )
            {
                MessageBox.Show("Ingrese valores en Nombre, Apellido y Cedula", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else 
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO Cliente (Nombre, Apellido, Cedula) VALUES(@Nombre, @Apellido, @Cedula)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@Nombre", Nombre);
                cmd1.Parameters.AddWithValue("@Apellido", Apellido);
                cmd1.Parameters.AddWithValue("@Cedula", Cedula);
                try
                {
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Producto agregado con exito!");
                    dataGridCliente.DataSource = llenar_Grid();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Producto no agregado!");
                }

 ;

            }
        }

        private void dataGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtId.Text = dataGridCliente.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = dataGridCliente.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = dataGridCliente.CurrentRow.Cells[2].Value.ToString();
                txtCedula.Text = dataGridCliente.CurrentRow.Cells[3].Value.ToString();
                
            }
            catch
            {

            }
        }


        // Actualizar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Cedula = txtCedula.Text;

            if( !(Id.Equals("")) || (Nombre.Equals("")) || (Apellido.Equals("")) || (Cedula.Equals("")) )
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Conexion.Conectar();
            string actualizar = "UPDATE Cliente SET Nombre= @Nombre, Apellido = @Apellido, Cedula = @Cedula  WHERE IdCliente = @IdCliente";
            SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
            cmd2.Parameters.AddWithValue("@IdCliente", Id);
            cmd2.Parameters.AddWithValue("@Nombre", Nombre);
            cmd2.Parameters.AddWithValue("@Apellido", Apellido);
            cmd2.Parameters.AddWithValue("@Cedula",Cedula);
            cmd2.ExecuteNonQuery();
            dataGridCliente.DataSource = llenar_Grid();
            MessageBox.Show("Registro Actualizado");


        }

        // ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;

            if(Id.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else                                                                                                                    
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdCliente", Id);
                cmd3.ExecuteNonQuery();
                dataGridCliente.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtId.Text = "" ;
            txtNombre.Text = "" ;
            txtApellido.Text ="" ;
            txtCedula.Text ="" ;
        }
    }
}
