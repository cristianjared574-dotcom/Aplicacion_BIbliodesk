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
            using (MySqlConnection con = Conexion.ConnectionData.getConection())//conecta con la base
            {
                if (con == null) return;

                // Query que selecciona las columnas correspondientes a ejemplares en la bas de datos
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

                        //crear una tabla con los datos de la base para filtrarla en el DataGriView
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvEjemplaresAdmin.DataSource = dt;
                        }
                    }
                }
                //errores de cargar los datos, puede ser problema de conexion
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos en la tabla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
      
        // Evento de búsqueda al escribir en la barra de texto el ejemplar que requiere
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }

        // Evento del botón Cambiar Estado
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvEjemplaresAdmin.SelectedRows.Count > 0)
            {
                // si lo selecciona entonces recupera los datos del ejemplar seleccionado en la fila 
                string idEjemplar = dgvEjemplaresAdmin.CurrentRow.Cells["ID_EJEMPLAR"].Value.ToString();
                string estadoActual = dgvEjemplaresAdmin.CurrentRow.Cells["DISPONIBLE"].Value.ToString();

                // y se abre el formulario de cambio de estado pasándole los datos que ocupa
                frmCambiarEstadoEjemplaresAdmin frm = new frmCambiarEstadoEjemplaresAdmin(idEjemplar, estadoActual);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarEjemplares(); // actualiza la tabla al guardar cambios
                }
            }
            else
            {
                //se debe seleccionar la fila y si no le aparece este mensaje
                MessageBox.Show("Por favor, seleccione un ejemplar de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        //text changed para que al momento de que se ingrese el texto en la busqueda esta ya este buscando
        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }
    }
}