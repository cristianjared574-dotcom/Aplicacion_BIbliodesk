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

            string query = "SELECT ID_LIBRO,ID_EDITORIAL,ID_CATEGORIA, TITULO, ISBN, ESTADO FROM LIBRO WHERE TITULO LIKE @criterio OR ISBN LIKE @criterio";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                // El filtro se aplica a ambos campos
                cmd.Parameters.AddWithValue("@criterio", "%" + filtro.Trim() + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvLibros.DataSource = dt;
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
                string estado = fila.Cells["ESTADO"].Value.ToString();


                frmLibrosEditar formEdicion = new frmLibrosEditar(id, idEd, idCat, isbn, titulo, estado);

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
    }
}
