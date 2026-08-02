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

namespace Aplicacion_BIbliodesk.Administrador.LibroAdmin
{
    public partial class frmLibrosBuscar : Form
    {
        private Conexion ConnectionData;
        public frmLibrosBuscar()
        {
            InitializeComponent();
        }

        private void frmLibrosBuscar_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(string filtro)
        {
            ConnectionData = new Conexion();

            using (MySqlConnection conn = ConnectionData.getConection())
            {
                // Consulta actualizada con el orden de columnas solicitado y los JOINs correspondientes
                string query = @"SELECT  
                                    l.ID_LIBRO, 
                                    l.CLAVE_LIBRO AS 'CLAVE AUTOR',
                                    l.ISBN,
                                    l.TITULO,
                                    CONCAT(a.NOMBRE, ' ', a.APELLIDOP) AS AUTOR,
                                    c.NOMBRE_CATEGORIA AS CATEGORIA, 
                                    l.ESTADO,
                                    (SELECT COUNT(*) FROM ejemplar e WHERE e.ID_LIBRO = l.ID_LIBRO AND e.DISPONIBLE = 'DISPONIBLE') AS EJEMPLARES,
                                    l.ID_EDITORIAL,  
                                    l.ID_CATEGORIA
                                 FROM LIBRO l 
                                 INNER JOIN editorial ed ON l.ID_EDITORIAL = ed.ID_EDITORIAL
                                 INNER JOIN categoria c ON l.ID_CATEGORIA = c.ID_CATEGORIA
                                 LEFT JOIN libro_autor la ON l.ID_LIBRO = la.ID_LIBRO
                                 LEFT JOIN autor a ON la.ID_AUTOR = a.ID_AUTOR
                                 WHERE l.TITULO LIKE @criterio 
                                    OR l.ISBN LIKE @criterio 
                                    OR l.CLAVE_LIBRO LIKE @criterio 
                                    OR ed.NOMBRE_EDITORIAL LIKE @criterio 
                                    OR c.NOMBRE_CATEGORIA LIKE @criterio 
                                    OR a.NOMBRE LIKE @criterio 
                                    OR a.APELLIDOP LIKE @criterio";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@criterio", "%" + filtro.Trim() + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLibros.DataSource = dt;

                    // Ocultamos las columnas de ID para que no se muestren en la interfaz, 
                    // conservando el orden limpio para el administrador.
                    if (dgvLibros.Columns["ID_LIBRO"] != null)
                        dgvLibros.Columns["ID_LIBRO"].Visible = false;

                    if (dgvLibros.Columns["ID_EDITORIAL"] != null)
                        dgvLibros.Columns["ID_EDITORIAL"].Visible = false;

                    if (dgvLibros.Columns["ID_CATEGORIA"] != null)
                        dgvLibros.Columns["ID_CATEGORIA"].Visible = false;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.Text);
        }

        private void btncambiarEstado_Click(object sender, EventArgs e)
        {
            frmInicioAdmin inicioAdmin = Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                frmCambiarEstadoLibro CambioEstadoLibro = new frmCambiarEstadoLibro();
                inicioAdmin.AbrirFormularioEnPanelAdmin(CambioEstadoLibro);
            }
        }
    }
}
