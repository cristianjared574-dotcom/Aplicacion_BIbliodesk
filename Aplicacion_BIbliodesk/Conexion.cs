using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Aplicacion_BIbliodesk
{
    internal class Conexion
    {
        // Cadena de conexión
        private const string CadenaConexion =
            "Server=localhost; Database=bibliodesk; UserID=root; Password=; Port=3306; SslMode=None;";

        // Método ESTÁTICO: así se llama sin crear instancia
        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(CadenaConexion);
                conn.Open();
                return conn;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
  
}