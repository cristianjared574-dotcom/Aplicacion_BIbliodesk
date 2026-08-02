using Aplicacion_BIbliodesk.Bibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    public partial class frmInicioEjemplaresBiblio : Form
    {
        private Conexion ConexionData;

        public frmInicioEjemplaresBiblio()
        {
            InitializeComponent();

            // Las columnas se crearán desde las propiedades del DataGridView
            dgvEjemplares.AutoGenerateColumns = false;
        }

        // Se ejecuta cuando se abre la pantalla
        private void frmInicioEjemplaresBiblio_Load(object sender,EventArgs e)
        {
            CargarEjemplares();
        }

        // Cargar y buscar ejemplares
        private void CargarEjemplares(string filtro = "")
        {
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con == null)
            {
                return;
            }

            string consulta = @"
                SELECT
                    E.ID_EJEMPLAR,
                    E.ID_LIBRO,
                    E.CLAVE_EJEMPLAR,
                    L.TITULO,
                    E.LOCALIZACION,
                    E.ESTADO_FISICO,
                    E.DISPONIBLE
                FROM EJEMPLAR E
                INNER JOIN LIBRO L
                    ON E.ID_LIBRO = L.ID_LIBRO";

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                consulta += @"
                    WHERE E.CLAVE_EJEMPLAR LIKE @filtro
                       OR L.TITULO LIKE @filtro
                       OR E.LOCALIZACION LIKE @filtro
                       OR E.ESTADO_FISICO LIKE @filtro
                       OR E.DISPONIBLE LIKE @filtro";
            }

            consulta += " ORDER BY E.ID_EJEMPLAR ASC;";

            try
            {
                using (MySqlCommand cmd =new MySqlCommand(consulta, con))
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro","%" + filtro.Trim() + "%");
                    }

                    using (MySqlDataAdapter adaptador =new MySqlDataAdapter(cmd))
                    {
                        DataTable tablaEjemplares =new DataTable();

                        adaptador.Fill(tablaEjemplares);

                        dgvEjemplares.DataSource = tablaEjemplares;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los ejemplares: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Buscar mientras se escribe
        private void txtBuscarEjemplar_TextChanged(object sender,EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }

        // Abrir formulario para agregar un ejemplar
        private void btnAgregar_Click(object sender,EventArgs e)
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmEjemplarBiblio frmAgregar =new frmEjemplarBiblio();

                inicioBiblio.AbrirFormularioEnPanel(frmAgregar);
            }
        }

        // Abrir formulario para editar el ejemplar seleccionado
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEjemplares.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un ejemplar de la tabla.","Ejemplar requerido",MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // ID interno del ejemplar
            int idEjemplar = Convert.ToInt32(dgvEjemplares.CurrentRow.Cells["ID_EJEMPLAR"].Value);

            // Código visible, por ejemplo EJE260001
            string claveEjemplar = dgvEjemplares.CurrentRow.Cells["CLAVE_EJEMPLAR"].Value.ToString();

            // ID interno del libro
            int idLibro = Convert.ToInt32(dgvEjemplares.CurrentRow.Cells["ID_LIBRO"].Value);

            string localizacion = dgvEjemplares.CurrentRow.Cells["LOCALIZACION"].Value.ToString();

            string estadoFisico = dgvEjemplares.CurrentRow.Cells["ESTADO_FISICO"].Value.ToString();

            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmEjemplarBiblio frmEditar = new frmEjemplarBiblio(idEjemplar,claveEjemplar,idLibro,localizacion,estadoFisico);

                inicioBiblio.AbrirFormularioEnPanel(frmEditar);
            }
        }
    }
}