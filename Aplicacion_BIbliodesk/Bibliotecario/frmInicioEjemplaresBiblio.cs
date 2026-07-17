using Aplicacion_BIbliodesk.Bibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    
    public partial class frmInicioEjemplaresBiblio : Form
    {
        public frmInicioEjemplaresBiblio()
        {
            InitializeComponent();
        }

        // Se ejecuta cuando se abre la pantalla de inicio de ejemplares
        private void frmInicioEjemplaresBiblio_Load(object sender, EventArgs e)
        {
            CargarEjemplares(); // Solo cargamos los datos de la base de datos al abrir
        }

        //metodo para cargar los ejemplares en el DataGridView
        private void CargarEjemplares(string filtro = "")
        {
            using (MySqlConnection con = Conexion.getConection())
            {
                if (con == null) return;

                // Consultar y seleccionar las columnas  de la tabla EJEMPLAR
                string query = "SELECT ID_EJEMPLAR, ID_LIBRO, LOCALIZACION, ESTADO_FISICO, DISPONIBLE FROM ejemplar";

                // Si hay texto en la barra de búsqueda
                if (!string.IsNullOrEmpty(filtro))
                {
                    query += " WHERE ID_EJEMPLAR LIKE @filtro OR LOCALIZACION LIKE @filtro OR ESTADO_FISICO LIKE @filtro OR DISPONIBLE LIKE @filtro";
                }

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(filtro))
                        {
                            cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            // Cargar el resultado en la tabla 
                            dgvEjemplares.DataSource = dt;

                            // Ajustamos las columnas para que llenen la pantalla ordenadamente
                            dgvEjemplares.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los ejemplares: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //text changed para que al momento de que se ingrese el texto en la busqueda esta ya este buscando
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }
        
        //evento al dar clic en el boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Usar el constructor vacío del formulario único para poder agregar
            frmEjemplarBiblio frm = new frmEjemplarBiblio();

            // Si se guardó con éxito en el otro formulario se refrescamos la tabla al instante
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CargarEjemplares();
            }
        }

        
        //Evento al dar clic en el boton editar ejemplar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Validar que el usuario tenga seleccionada una fila en la tabla
            if (dgvEjemplares.CurrentRow != null)
            {
                //Extraer valores de la fila activa
                string idEjemplar = dgvEjemplares.CurrentRow.Cells["ID_EJEMPLAR"].Value.ToString();
                string idLibro = dgvEjemplares.CurrentRow.Cells["ID_LIBRO"].Value.ToString();
                string localizacion = dgvEjemplares.CurrentRow.Cells["LOCALIZACION"].Value.ToString();

                //Abre el formulario pasando los parámetros para poder editar
                frmEjemplarBiblio frm = new frmEjemplarBiblio(idEjemplar, idLibro, localizacion);

                //Si se edito correctamente, se refresca la tabla al cerrar
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarEjemplares();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un ejemplar de la tabla para poder editarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}