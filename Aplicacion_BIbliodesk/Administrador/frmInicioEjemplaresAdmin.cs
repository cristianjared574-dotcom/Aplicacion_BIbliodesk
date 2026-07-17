using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmInicioEjemplaresAdmin : Form
    {
        public frmInicioEjemplaresAdmin()
        {
            InitializeComponent();
        }

        private void frmInicioEjemplaresAdmin_Load(object sender, EventArgs e)
        {
            CargarEjemplares();
        }

        // Método para cargar y filtrar datos en el DataGridView
        private void CargarEjemplares(string filtro = "")
        {
            using (MySqlConnection con = Conexion.ConnectionData.getConection())
            {
                if (con == null) return;

                // Query que selecciona las columnas correspondientes a tu base de datos
                string query = "SELECT ID_EJEMPLAR, ID_LIBRO, LOCALIZACION, ESTADO_FISICO, DISPONIBLE FROM ejemplar";

                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE ID_EJEMPLAR LIKE @filtro OR LOCALIZACION LIKE @filtro";
                }
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvEjemplaresAdmin.DataSource = dt; // Ajusta 'dgvEjemplares' al nombre de tu DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
      
        // Evento de búsqueda en tiempo real al escribir en la barra de texto
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }

        // Evento del botón "Cambiar Estado"
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvEjemplaresAdmin.SelectedRows.Count > 0)
            {
                // Recuperar los datos del ejemplar seleccionado en la fila del DataGrid
                string idEjemplar = dgvEjemplaresAdmin.CurrentRow.Cells["ID_EJEMPLAR"].Value.ToString();
                string estadoActual = dgvEjemplaresAdmin.CurrentRow.Cells["DISPONIBLE"].Value.ToString();

                // Abrimos el formulario de cambio de estado pasándole los datos necesarios
                frmCambiarEstadoEjemplaresAdmin frm = new frmCambiarEstadoEjemplaresAdmin(idEjemplar, estadoActual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarEjemplares(); // Refrescar la tabla al guardar cambios
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ejemplar de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }
    }
}