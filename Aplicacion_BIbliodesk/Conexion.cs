using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    internal class Conexion
    {
        private readonly string cadena;

        public Conexion()
        {
            cadena = "Server=localhost; Database=bibliodesk; UserID=root; Password=; Port=3306; SslMode=None;";
        }
        public MySqlConnection getConection()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadena);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }

    }

}

