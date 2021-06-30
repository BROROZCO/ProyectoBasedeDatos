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
    public partial class Puesto : Form
    {
        public Puesto()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // LECTURA DEL DATAGRIEW
        private void dataGridPuesto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPuesto.Text = dataGridPuesto.CurrentRow.Cells[0].Value.ToString();
            txtNombrePuesto.Text = dataGridPuesto.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dataGridPuesto.CurrentRow.Cells[2].Value.ToString();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [IdPuesto],[NombrePuesto],[Descripcion] FROM [Punta_El_Cacique1].[dbo].[Puesto] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void Puesto_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            dataGridPuesto.DataSource = llenar_Grid();
        }

        // INSERT
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdPuesto = txtIdPuesto.Text;
            string NombrePuesto = txtNombrePuesto.Text;
            string Descrip = txtDescripcion.Text;

            if( NombrePuesto.Equals("") )
            {
                MessageBox.Show("ingresa un puesto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO Puesto (NombrePuesto, Descripcion) VALUES(@NombrePuesto, @Descripcion)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@NombrePuesto", NombrePuesto);
                cmd1.Parameters.AddWithValue("@Descripcion", Descrip);
                cmd1.ExecuteNonQuery();
                dataGridPuesto.DataSource = llenar_Grid();
                MessageBox.Show("Producto agregado con exito!");
            }
        }

        // UPDATE
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdPuesto = txtIdPuesto.Text;
            string NombrePuesto = txtNombrePuesto.Text;
            string Descrip = txtDescripcion.Text;
            
            if( (IdPuesto.Equals("")) || (NombrePuesto.Equals("")))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string actualizar = "UPDATE Puesto SET NombrePuesto = @NombrePuesto, Descripcion = @Descripcion WHERE IdPuesto = @IdPuesto";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@IdPuesto",IdPuesto);
                cmd2.Parameters.AddWithValue("@NombrePuesto", NombrePuesto);
                cmd2.Parameters.AddWithValue("@Descripcion", Descrip);
                cmd2.ExecuteNonQuery();
                dataGridPuesto.DataSource = llenar_Grid();
                MessageBox.Show("Registro actualizado con exito!");

            }

        }


        // ELIMINAR QUEDASTE AQUI CRACK 
        private void jajaja_Click(object sender, EventArgs e)
        {
            string Id = txtIdPuesto.Text;
            if(Id.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Puesto WHERE IdPuesto = @IdPuesto";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdPuesto", Id);
                cmd3.ExecuteNonQuery();
                dataGridPuesto.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");
            }
        }
    }
}
