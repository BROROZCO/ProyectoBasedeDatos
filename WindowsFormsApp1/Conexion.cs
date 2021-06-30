using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=Punta_El_Cacique1;Persist Security Info=True;User ID=sa;Password=280998");
            cn.Open();
            return cn;
        }
    }
}
