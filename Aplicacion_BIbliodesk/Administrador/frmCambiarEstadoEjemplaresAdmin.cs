using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aplicacion_BIbliodesk
{
    public partial class frmCambiarEstadoEjemplaresAdmin : Form
    {
        // Variables globales para almacenar los datos recibidos del primer formulario
        private string idEjemplar="";
        private string estadoActual = "";

        // 1. CONSTRUCTOR VACÍO: Requerido obligatoriamente por el Diseñador de Visual Studio
        public frmCambiarEstadoEjemplaresAdmin()
        {
            InitializeComponent();
        }

        // 2. CONSTRUCTOR CON PARÁMETROS: El que usamos en código para pasar los datos de la fila
        public frmCambiarEstadoEjemplaresAdmin(string id, string estado)
        {
            InitializeComponent();

            this.idEjemplar = id;
            this.estadoActual = estado;
        }

        // Se ejecuta al cargar el formulario de cambio de estado
        private void frmCambiarEstadoEjemplaresAdmin_Load(object sender, EventArgs e)
        {
            // Validamos que los datos no hayan llegado nulos por seguridad
            if (!string.IsNullOrEmpty(idEjemplar))
            {
                txtIdEjemplar.Text = idEjemplar;
                cmbEstado.Text = estadoActual;
            }
        }

        // Evento Click del botón "Guardar Cambios"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 1. Leemos el ID directamente del cuadro de texto de la interfaz gráfica
            string idTexto = txtIdEjemplar.Text.Trim();

            // Validación extra: Si por algún motivo el cuadro está vacío, detenemos el proceso ordenadamente
            if (string.IsNullOrEmpty(idTexto))
            {
                MessageBox.Show("No hay un ID de ejemplar visible en la pantalla para modificar.", "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Validamos que se haya seleccionado un estado válido
            if (cmbEstado.SelectedItem == null && string.IsNullOrEmpty(cmbEstado.Text))
            {
                MessageBox.Show("Por favor, seleccione un estado válido de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Convertimos el estado seleccionado a MAYÚSCULAS ("ACTIVO" / "INACTIVO")
            string nuevoEstado = cmbEstado.Text.Trim().ToUpper();

            // 4. Conectamos a la base de datos
            using (MySqlConnection con = Conexion.getConection())
            {
                if (con == null) return;

                // Query definitivo usando tus columnas físicas reales: DISPONIBLE e ID_EJEMPLAR
                string query = "UPDATE ejemplar SET DISPONIBLE = @nuevoEstado WHERE ID_EJEMPLAR = @id";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // Asignamos los parámetros de manera segura
                        cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);

                        // CORRECCIÓN CLAVE: Convertimos el texto del cuadro físico en número entero
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(idTexto));

                        // Ejecutamos la consulta en MySQL
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("El estado del ejemplar se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            // Alerta si intentas guardar el mismo estado que ya tiene en SQLyog
                            MessageBox.Show("No se realizaron cambios porque el ejemplar ya tiene ese estado asignado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Evento Click del botón "Cancelar"
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}