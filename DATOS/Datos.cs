using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODELOS;
using System.Data.SqlClient;

namespace DATOS
{
    public class Datos
    {
        public static int Agregar(Table table)
        {
            int retorno = 0;
            string sql = "INSERT INTO table (CustomerID, CompanyName, ContactName, Phone) values (@CustomerID, @CompanyName, @ContactName, @Phone)";
            SqlCommand comando = new SqlCommand(sql, Conexion.ObtenerConexion());
            comando.Parameters.AddWithValue("@CustomerID", table.CustomerID);
            comando.Parameters.AddWithValue("@CompanyName", table.CompanyName);
            comando.Parameters.AddWithValue("@ContactName", table.ContactName);
            comando.Parameters.AddWithValue("@Phone", table.Phone);
            try
            {
                retorno = comando.ExecuteNonQuery();
            }
            catch (SqlException) { }
            finally
            {
                comando.Dispose();
                Conexion.ObtenerConexion().Close();
                Conexion.ObtenerConexion().Dispose();
            }
            return retorno;
        }
    }
}
