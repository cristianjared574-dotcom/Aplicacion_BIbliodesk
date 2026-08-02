using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmInicioEjemplaresAdmin : Form
    {
        private Conexion ConexionData;
        public frmInicioEjemplaresAdmin()
        {
            InitializeComponent();

            dgvEjemplaresAdmin.AutoGenerateColumns = false;  //para qur no genere mas columnas
        }

        private void frmInicioEjemplaresAdmin_Load(object sender, EventArgs e)
        {
            CargarEjemplares();
        }

        // Método para cargar y filtrar datos en el DataGridView
        private void CargarEjemplares(string filtro = "")
        {
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con == null)
                return;

            string query = @"
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
                query += @"
            WHERE E.CLAVE_EJEMPLAR LIKE @filtro
               OR L.TITULO LIKE @filtro
               OR E.LOCALIZACION LIKE @filtro";
            }

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        cmd.Parameters.AddWithValue(
                            "@filtro",
                            "%" + filtro.Trim() + "%"
                        );
                    }

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvEjemplaresAdmin.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los datos en la tabla: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Evento de búsqueda 
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }

        // Evento del botón Cambiar Estado
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            // Verificar que exista una fila seleccionada
            if (dgvEjemplaresAdmin.CurrentRow == null)
            {
                MessageBox.Show(
                    "Por favor, seleccione un ejemplar de la tabla.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Obtener el ID y el estado de la fila seleccionada
            string id = dgvEjemplaresAdmin.CurrentRow
                .Cells["ID_EJEMPLAR"]
                .Value
                .ToString();

            string codigo = dgvEjemplaresAdmin.CurrentRow
            .Cells["CLAVE_EJEMPLAR"]
            .Value
            .ToString();

            string estado = dgvEjemplaresAdmin.CurrentRow
                .Cells["DISPONIBLE"]
                .Value
                .ToString();

            // Buscar el formulario principal del administrador
            frmInicioAdmin inicioAdmin =
                Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                // Crear un solo formulario y enviarle los datos
                frmCambiarEstadoEjemplaresAdmin formulario =
                    new frmCambiarEstadoEjemplaresAdmin(id, codigo, estado);

                // Actualizar la tabla cuando se cierre el formulario
                formulario.FormClosed += (s, args) =>
                {
                    CargarEjemplares("");
                };

                // Abrir el formulario dentro del panel
                inicioAdmin.AbrirFormularioEnPanelAdmin(formulario);
            }
        }


        //text changed para que al momento de que se ingrese el texto en la busqueda esta ya este buscando
        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvEjemplaresAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}