using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class accesoDatosRespaldoBD
    {
        SqlConnection cnx; //Conexion
        Conexion cn = new Conexion(); //Conexion 
        SqlCommand cm = null; //Comandos SQL
        int indicador = 0; //Variable indicador para comprobar ejecución correcta

        public int respaldarBD()
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion

                cm = new SqlCommand("respaldoBD_Productos", cnx);
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            { cm.Connection.Close(); }
            return indicador;
        }
    }
}
