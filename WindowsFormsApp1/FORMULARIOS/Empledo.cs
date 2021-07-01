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
    public partial class Empledo : Form
    {
        public Empledo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string IdEmpleado = txtCodigoEmpleado.Text;
            string IdPuesto = txtCodigoPuesto.Text;
            string Sexo = txtSexoCB.Text;
            string Edad = txtEdad.Text;
            string Fecha = txtfecha.Text;
            string NumTelefono = txTelefono.Text;
            string UserName = txtUsuario.Text;
            string Password = txtpassword.Text;
            string CuentaEstado = txtEstadoCB.Text;
            string PrimerNombre = txtNombrePrimero.Text;
            string SegundoNombre = txtNombreSegundo.Text;
            string PrimerApellido = txtApellidoPrimero.Text;
            string SegundoApellido = txtApellidoSegundo.Text;

            if( (IdPuesto.Equals("")) || (Sexo.Equals("")) || (Edad.Equals("")) || (Fecha.Equals("")) || (NumTelefono.Equals("")) || (UserName.Equals("")) || (Password.Equals("")) || (CuentaEstado.Equals("")) || (PrimerNombre.Equals("")) || (PrimerApellido.Equals("")))
            {
                MessageBox.Show("Datos Incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if( (CuentaEstado.Equals("Habilitada") == false) && (CuentaEstado.Equals("Deshabilitada")) == false)
                {
                    MessageBox.Show("Estado de Cuenta Incorrecto", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (SegundoNombre.Equals(""))
                    {
                        SegundoNombre = "NULL";
                    }

                    if (SegundoApellido.Equals(""))
                    {
                        SegundoApellido = "NULL";
                    }

                    int EstadoCuenta_ = 0;
                    if(CuentaEstado.Equals("Habilitado"))
                    {
                        EstadoCuenta_ = 1;
                    }
                    else
                    {
                        EstadoCuenta_ = 0;
                    }

                    // Insert
                    Conexion.Conectar();
                    string insertar = "INSERT INTO [dbo].[Empleado] (IdPuesto_FK, sexo, Edad, FechaIngreso, NumeroTelefonoEmpleado, UserName, Password_, CuentaEstado, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido) VALUES(@IdPuesto_FK, @sexo, @Edad, @FechaIngreso, @NumeroTelefonoEmpleado, @UserName, @Password_, @CuentaEstado, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido)";
                    SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                    cmd1.Parameters.AddWithValue("@IdPuesto_FK", IdPuesto);
                    cmd1.Parameters.AddWithValue("@sexo", Sexo);
                    cmd1.Parameters.AddWithValue("@Edad", Edad);
                    cmd1.Parameters.AddWithValue("@FechaIngreso", Fecha);
                    cmd1.Parameters.AddWithValue("@NumeroTelefonoEmpleado", NumTelefono);
                    cmd1.Parameters.AddWithValue("@UserName", UserName);
                    cmd1.Parameters.AddWithValue("@Password_", Password);
                    cmd1.Parameters.AddWithValue("@CuentaEstado", EstadoCuenta_);
                    cmd1.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
                    cmd1.Parameters.AddWithValue("@SegundoNombre", SegundoNombre);
                    cmd1.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                    cmd1.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Registro agregado con exito!");
                    datadridEmpleados.DataSource = llenar_Grid();
                }
            }
        }

        private void Empledo_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion Exitosa");
            datadridEmpleados.DataSource = llenar_Grid();
        }

        public DataTable llenar_Grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT [IdEmpleado],[IdPuesto_FK],[sexo],[Edad],[FechaIngreso],[NumeroTelefonoEmpleado],[UserName],[Password_],[CuentaEstado],[PrimerNombre],[SegundoNombre],[PrimerApellido],[SegundoApellido] FROM [Punta_El_Cacique1].[dbo].[Empleado] GO;";
            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        // UPDATE
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string IdEmpleado = txtCodigoEmpleado.Text;
            string IdPuesto = txtCodigoPuesto.Text;
            string Sexo = txtSexoCB.Text;
            string Edad = txtEdad.Text;
            string Fecha = txtfecha.Text;
            string NumTelefono = txTelefono.Text;
            string UserName = txtUsuario.Text;
            string Password = txtpassword.Text;
            string CuentaEstado = txtEstadoCB.Text;
            string PrimerNombre = txtNombrePrimero.Text;
            string SegundoNombre = txtNombreSegundo.Text;
            string PrimerApellido = txtApellidoPrimero.Text;
            string SegundoApellido = txtApellidoSegundo.Text;

            if ((IdPuesto.Equals("")) || (Sexo.Equals("")) || (Edad.Equals("")) || (Fecha.Equals("")) || (NumTelefono.Equals("")) || (UserName.Equals("")) || (Password.Equals("")) || (CuentaEstado.Equals("")) || (PrimerNombre.Equals("")) || (PrimerApellido.Equals("")))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {

                if(SegundoNombre.Equals(""))
                {
                    SegundoNombre = "NULL";
                }

                if(SegundoApellido.Equals(""))
                {
                    SegundoApellido = "NULL";
                }

                char EstadoCuenta_ = '0';
                if (CuentaEstado.Equals("Deshabilitada"))
                {
                    EstadoCuenta_ = '0';
                }
                else
                {
                    EstadoCuenta_ = '1';
                }
                // Update
                Conexion.Conectar();
                string actualizar = "UPDATE [dbo].[Empleado]  SET sexo= @sexo, Edad = @Edad, FechaIngreso = @FechaIngreso, NumeroTelefonoEmpleado = @NumeroTelefonoEmpleado, UserName = @UserName, Password_ = @Password_, CuentaEstado = @CuentaEstado, PrimerNombre = @PrimerNombre, SegundoNombre = @SegundoNombre, PrimerApellido = @PrimerApellido, SegundoApellido = @SegundoApellido WHERE IdEmpleado = @IdEmpleado";
                SqlCommand cmd2 = new SqlCommand(actualizar, Conexion.Conectar());
                cmd2.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                cmd2.Parameters.AddWithValue("@sexo", Sexo);
                cmd2.Parameters.AddWithValue("@Edad", Edad);
                cmd2.Parameters.AddWithValue("@FechaIngreso", Fecha);
                cmd2.Parameters.AddWithValue("@NumeroTelefonoEmpleado", NumTelefono);
                cmd2.Parameters.AddWithValue("@UserName", UserName);
                cmd2.Parameters.AddWithValue("@Password_", Password);
                cmd2.Parameters.AddWithValue("@CuentaEstado", EstadoCuenta_);
                cmd2.Parameters.AddWithValue("@PrimerNombre", PrimerNombre);
                cmd2.Parameters.AddWithValue("@SegundoNombre", SegundoNombre);
                cmd2.Parameters.AddWithValue("@PrimerApellido", PrimerApellido);
                cmd2.Parameters.AddWithValue("@SegundoApellido", SegundoApellido);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Registro Actualizado con exito!");
                datadridEmpleados.DataSource = llenar_Grid();

            }

        }

        private void datadridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtCodigoEmpleado.Text = datadridEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtCodigoPuesto.Text = datadridEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtSexoCB.Text = datadridEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtEdad.Text = datadridEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtfecha.Text = datadridEmpleados.CurrentRow.Cells[4].Value.ToString();
                txTelefono.Text = datadridEmpleados.CurrentRow.Cells[5].Value.ToString();
                txtUsuario.Text = datadridEmpleados.CurrentRow.Cells[6].Value.ToString();
                txtpassword.Text = datadridEmpleados.CurrentRow.Cells[7].Value.ToString();
                // si es 1 -> habilitado
                string aux = datadridEmpleados.CurrentRow.Cells[8].Value.ToString();
                if (aux.Equals("1"))
                {
                    txtEstadoCB.Text = "Habilitada";
                }
                else
                {
                    txtEstadoCB.Text = "Deshabilitada";
                }
                txtNombrePrimero.Text = datadridEmpleados.CurrentRow.Cells[9].Value.ToString();
                txtNombreSegundo.Text = datadridEmpleados.CurrentRow.Cells[10].Value.ToString();
                txtApellidoPrimero.Text = datadridEmpleados.CurrentRow.Cells[11].Value.ToString();
                txtApellidoSegundo.Text = datadridEmpleados.CurrentRow.Cells[12].Value.ToString();
                

            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string IdEmpleado = txtCodigoEmpleado.Text;
            if(IdEmpleado.Equals(""))
            {
                MessageBox.Show("Seleccione Nuevamente el registro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                Conexion.Conectar();
                string eliminar = "DELETE FROM Empleado WHERE IdEmpleado = @IdEmpleado";
                SqlCommand cmd3 = new SqlCommand(eliminar, Conexion.Conectar());
                cmd3.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Registro Eliminado!");
                datadridEmpleados.DataSource = llenar_Grid();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigoEmpleado.Text = "";
            txtCodigoPuesto.Text = "";
            txtSexoCB.Text = "";
            txtEdad.Text = "";
            txtfecha.Text = "";
            txTelefono.Text = "";
            txtUsuario.Text = "";
            txtpassword.Text = "";
            txtNombrePrimero.Text = "";
            txtNombreSegundo.Text = ""; ;
            txtApellidoPrimero.Text = "";
            txtApellidoSegundo.Text = "";
        }
    }
}
