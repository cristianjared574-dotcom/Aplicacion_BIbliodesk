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
       
            public static MySqlConnection getConection()
            { 

                string cadena ="Server=localhost; Database=bibliodesk1; UserID=root; Password=; Port=3306; SslMode=None;";
            
            
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

        // ✅ Cifrado también estático
        public static string CifrarContrasena(string textoPlano)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        
    }
}

