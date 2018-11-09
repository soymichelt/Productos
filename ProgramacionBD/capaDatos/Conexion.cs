using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Productos;Integrated Security=True;";
            return cn;
        }
    }
}
// cn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=bd_ger;Integrated Security=True;";
            //cn.ConnectionString = "Data Source=DESKTOP-QEQ9I0B;Initial Catalog=bd_ger;Integrated Security=True;";