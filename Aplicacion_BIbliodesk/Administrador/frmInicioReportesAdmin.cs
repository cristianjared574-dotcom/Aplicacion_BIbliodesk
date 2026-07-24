using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmInicioReportesAdmin : Form
    {
        private Conexion dataAccess;
        public frmInicioReportesAdmin()
        {
            InitializeComponent();
        }

        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            dataAccess = new Conexion();
            MySqlConnection conn = dataAccess.getConection();

            string query = "";

            // Validar qué opción de reporte está seleccionada
            if (rbPrestamos.Checked)
            {
                // Muestra qué usuario se llevó qué libro (ejemplar), en qué fechas y el estado actual del préstamo.
                query = @"SELECT 
                            p.ID_PRESTAMO,
                            CONCAT(u.NOMBRE, ' ', u.APELLIDOP, ' ', u.APELLIDOM) AS USUARIO,
                            l.TITULO AS LIBRO,
                            e.ID_EJEMPLAR,
                            p.FECHA_INICIO,
                            p.FECHA_DEVOLUCION,
                            p.ESTADO
                          FROM PRESTAMO p
                          INNER JOIN USUARIO u ON p.ID_USUARIO = u.ID_USUARIO
                          INNER JOIN EJEMPLAR e ON p.ID_EJEMPLAR = e.ID_EJEMPLAR
                          INNER JOIN LIBRO l ON e.ID_LIBRO = l.ID_LIBRO
                          WHERE p.FECHA_INICIO BETWEEN @desde AND @hasta
                          ORDER BY p.FECHA_INICIO DESC;";
            }
            else if (rbCategorias.Checked)
            {
                //Permite ver qué categorías de libros son las más solicitadas o prestadas en un periodo de tiempo.
                query = @"SELECT 
                            c.NOMBRE_CATEGORIA AS CATEGORIA,
                            l.TITULO AS LIBRO,
                            COUNT(p.ID_PRESTAMO) AS TOTAL_PRESTAMOS
                          FROM PRESTAMO p
                          INNER JOIN EJEMPLAR e ON p.ID_EJEMPLAR = e.ID_EJEMPLAR
                          INNER JOIN LIBRO l ON e.ID_LIBRO = l.ID_LIBRO
                          INNER JOIN CATEGORIA c ON l.ID_CATEGORIA = c.ID_CATEGORIA
                          WHERE p.FECHA_INICIO BETWEEN @desde AND @hasta
                          GROUP BY c.ID_CATEGORIA, c.NOMBRE_CATEGORIA, l.ID_LIBRO, l.TITULO
                          ORDER BY TOTAL_PRESTAMOS DESC;";
            }
            else if (rbAutores.Checked)
            {
                //Muestra qué autores tienen libros que se han prestado más veces dentro del rango de fechas.
                query = @"SELECT 
                            CONCAT(a.NOMBRE, ' ', a.APELLIDOP, ' ', a.APELLIDOM) AS AUTOR,
                            l.TITULO AS LIBRO,
                            COUNT(p.ID_PRESTAMO) AS TOTAL_PRESTAMOS
                          FROM PRESTAMO p
                          INNER JOIN EJEMPLAR e ON p.ID_EJEMPLAR = e.ID_EJEMPLAR
                          INNER JOIN LIBRO_AUTOR la ON e.ID_LIBRO = la.ID_LIBRO
                          INNER JOIN AUTOR a ON la.ID_AUTOR = a.ID_AUTOR
                          INNER JOIN LIBRO l ON la.ID_LIBRO = l.ID_LIBRO
                          WHERE p.FECHA_INICIO BETWEEN @desde AND @hasta
                          GROUP BY a.ID_AUTOR, a.NOMBRE, a.APELLIDOP, a.APELLIDOM, l.ID_LIBRO, l.TITULO
                          ORDER BY TOTAL_PRESTAMOS DESC;";
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de reporte.");
                return;
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    
                    cmd.Parameters.AddWithValue("@desde", dtpDesde.Value.ToString("yyyy-MM-dd 00:00:00"));
                    cmd.Parameters.AddWithValue("@hasta", dtpHasta.Value.ToString("yyyy-MM-dd 23:59:59"));

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReporte.DataSource = dt;

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontraron registros para el rango de fechas seleccionado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}


