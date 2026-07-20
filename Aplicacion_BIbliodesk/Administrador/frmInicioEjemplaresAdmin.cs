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
        }

        private void frmInicioEjemplaresAdmin_Load(object sender, EventArgs e)
        {
            CargarEjemplares();
        }

        // Método para cargar y filtrar datos en el DataGridView
        private void CargarEjemplares(string filtro = "")
        {


            //conecta con la base
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

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

                        // Cargar el resultado en la tabla
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

        // Evento de búsqueda al escribir en la barra de texto el ejemplar que requiere
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }

        // Evento del botón Cambiar Estado
        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            //Abre elformulario en el en inicio
            frmInicioAdmin inicioAdmin = Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                frmCambiarEstadoEjemplaresAdmin CambioEstadoEjemplares= new frmCambiarEstadoEjemplaresAdmin();
                inicioAdmin.AbrirFormularioEnPanelAdmin(CambioEstadoEjemplares);
            }

            // verificar que el usuario tenga seleccionada una fila en la tabla
            if (dgvEjemplaresAdmin.CurrentRow != null)
            {
                // extraer los valores de las celdas de la fila activa
                string id = dgvEjemplaresAdmin.CurrentRow.Cells["ID_EJEMPLAR"].Value.ToString();
                string estado = dgvEjemplaresAdmin.CurrentRow.Cells["DISPONIBLE"].Value.ToString();

                // Pasaar el ID y el Estado al crear el formulario
                frmCambiarEstadoEjemplaresAdmin frm = new frmCambiarEstadoEjemplaresAdmin(id, estado);

                // Si el cambio se guarda con éxito se refresca la tabla al cerrar la ventana
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarEjemplares(""); // Recargar tabla para mostrar el cambio al instante
                }
            }
            else
            {
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