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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        string user = "";
        string pass = "";
        string estado = "";
        string puesto = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string a = txtUser.Text;
            string b = txtPassword.Text;
            login(a, b);
        }


        public void login(string user_, string pass_)
        {
            try
            {
                Conexion.Conectar();
                MessageBox.Show("Conexion Exitosa");
                string consul = "SELECT UserName ,Password_, CuentaEstado, IdPuesto_FK  FROM Empleado WHERE UserName = @UserName AND Password_ = @Password_  ";
                SqlCommand cmd = new SqlCommand(consul, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@UserName", user_);
                cmd.Parameters.AddWithValue("@Password_", pass_);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    user = dt.Rows[0][0].ToString();
                    pass = dt.Rows[0][1].ToString();
                    estado = dt.Rows[0][2].ToString();
                    puesto = dt.Rows[0][3].ToString();

                    // MessageBox.Show("Usuario: "+ user + " pass: "+pass+" Estado: "+estado+ " ID PUESTO: "+puesto);
                    Form1 form1 = new Form1(user,pass,estado,puesto);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto");
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {

            }
        }
    }
}
