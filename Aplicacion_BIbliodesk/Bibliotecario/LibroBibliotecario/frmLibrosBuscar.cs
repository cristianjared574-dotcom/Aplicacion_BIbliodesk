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

namespace Aplicacion_BIbliodesk.Bibliotecario.LibroBibliotecario
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
            MySqlConnection conn = ConnectionData.getConection();


            string query = @"SELECT  
                            l.ID_LIBRO, 
                            l.CLAVE_LIBRO AS 'Clave libro',
                            l.ISBN,
                            l.TITULO AS 'Titulo',
                            CONCAT(a.NOMBRE, ' ', a.APELLIDOP) AS 'Autor',
                            c.NOMBRE_CATEGORIA AS 'Categoría', 
                            l.ESTADO AS 'Estado',
                            (SELECT COUNT(*) FROM ejemplar e WHERE e.ID_LIBRO = l.ID_LIBRO AND e.DISPONIBLE = 'DISPONIBLE') AS 'Ejemplares',
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

                
                if (dgvLibros.Columns["ID_EDITORIAL"] != null)
                    dgvLibros.Columns["ID_EDITORIAL"].Visible = false;

                if (dgvLibros.Columns["ID_CATEGORIA"] != null)
                    dgvLibros.Columns["ID_CATEGORIA"].Visible = false;

                if (dgvLibros.Columns["ID_LIBRO"] != null)
                    dgvLibros.Columns["ID_LIBRO"].Visible = false;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.Text);
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if(inicioBiblio != null )
            {
                frmLibrosAgregar AgregarLibro = new frmLibrosAgregar();
                inicioBiblio.AbrirFormularioEnPanel(AgregarLibro);
            }
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvLibros.SelectedRows[0];


                string id = fila.Cells["ID_LIBRO"].Value.ToString();
                string idEd = fila.Cells["ID_EDITORIAL"].Value.ToString();
                string idCat = fila.Cells["ID_CATEGORIA"].Value.ToString();
                string isbn = fila.Cells["ISBN"].Value.ToString();
                string titulo = fila.Cells["TITULO"].Value.ToString();



                frmLibrosEditar formEdicion = new frmLibrosEditar(id, idEd, idCat, isbn, titulo);

                frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

                if (inicioBiblio != null)
                {

                    inicioBiblio.AbrirFormularioEnPanel(formEdicion);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila");
            }
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
