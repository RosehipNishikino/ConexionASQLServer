using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DATOS
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shana\source\repos\ConexionASQLServer\ConexionASQLServer\SampleDataBase.mdf;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}
