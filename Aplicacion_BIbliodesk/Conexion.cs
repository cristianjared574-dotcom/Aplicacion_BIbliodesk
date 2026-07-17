using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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

            }
        
    }
}

