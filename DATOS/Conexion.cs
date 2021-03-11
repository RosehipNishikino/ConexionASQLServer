using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DATOS
{
    public class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + @"\SampleDataBase.mdf;Integrated Security=True");
            conexion.Open();
            return conexion;
        }
    }
}
