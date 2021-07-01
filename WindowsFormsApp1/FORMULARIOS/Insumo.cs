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
    public partial class Insumo : Form
    {
        public Insumo()
        {
            InitializeComponent();
        }

        private void Insumo_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            datagridInsumo.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT IdInsumo, NombreInsumo, CantInsumo, PrecioInsumo FROM Insumo";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdInsumo = txtIdInsumo.Text;
            string NombreInsumo = txtNombreInsumo.Text;
            string CantInsumo = txtCantidadInsumo.Text;
            string PrecioInsumo = txtPrecioInsumo.Text;

            if( (NombreInsumo.Equals("")) || (CantInsumo.Equals("")) || (PrecioInsumo.Equals("")) )
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string insertar = "INSERT INTO Insumo (NombreInsumo, CantInsumo, PrecioInsumo) VALUES (@NombreInsumo, @CantInsumo, @PrecioInsumo)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@NombreInsumo", NombreInsumo);
                cmd1.Parameters.AddWithValue("@CantInsumo", CantInsumo);
                cmd1.Parameters.AddWithValue("@PrecioInsumo", PrecioInsumo);
                cmd1.ExecuteNonQuery();
                datagridInsumo.DataSource = llenar_Grid();
                MessageBox.Show("Registro agregado con exito!");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdInsumo = txtIdInsumo.Text;
            string NombreInsumo = txtNombreInsumo.Text;
            string CantInsumo = txtCantidadInsumo.Text;
            string PrecioInsumo = txtPrecioInsumo.Text;

            if ( (IdInsumo.Equals("")) || (NombreInsumo.Equals("")) || (CantInsumo.Equals("")) || (PrecioInsumo.Equals("")))
            {
                MessageBox.Show("Ingresa Datos Correctos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string actualizar = "UPDATE Insumo SET  NombreInsumo = @NombreInsumo, CantInsumo = @CantInsumo, PrecioInsumo = @PrecioInsumo  WHERE IdInsumo = @IdInsumo";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@IdInsumo", IdInsumo);
                cmd2.Parameters.AddWithValue("@NombreInsumo", NombreInsumo);
                cmd2.Parameters.AddWithValue("@CantInsumo", CantInsumo);
                cmd2.Parameters.AddWithValue("@PrecioInsumo", PrecioInsumo);
                cmd2.ExecuteNonQuery();
                datagridInsumo.DataSource = llenar_Grid();
                MessageBox.Show("Registro Actualizado!");
            }

        }

        private void datagridInsumo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdInsumo.Text = datagridInsumo.CurrentRow.Cells[0].Value.ToString();
                txtNombreInsumo.Text = datagridInsumo.CurrentRow.Cells[1].Value.ToString();
                txtCantidadInsumo.Text = datagridInsumo.CurrentRow.Cells[2].Value.ToString();
                txtPrecioInsumo.Text = datagridInsumo.CurrentRow.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string ID = txtIdInsumo.Text;
            if (ID.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Insumo WHERE IdInsumo = @IdInsumo";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdInsumo", ID);
                cmd3.ExecuteNonQuery();
                datagridInsumo.DataSource = llenar_Grid();
                MessageBox.Show("Registro eliminado");
            }
        }
    }
}
