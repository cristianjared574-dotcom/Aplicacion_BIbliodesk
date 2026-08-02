using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmEjemplarBiblio : Form
    {
        private Conexion ConexionData;

        // Indica si se registrará o editará un ejemplar.
        private bool esModoEdicion = false;

        // Datos utilizados durante la edición.
        private int idEjemplarEditar = 0;
        private int idLibroEditar = 0;

        private string claveEjemplarEditar = "";
        private string localizacionEditar = "";
        private string estadoFisicoEditar = "";

        // Constructor para agregar un ejemplar.
        public frmEjemplarBiblio()
        {
            InitializeComponent();

            esModoEdicion = false;
        }

        // Constructor para editar un ejemplar.
        public frmEjemplarBiblio(
            int idEjemplar,
            string claveEjemplar,
            int idLibro,
            string localizacion,
            string estadoFisico)
        {
            InitializeComponent();

            esModoEdicion = true;

            idEjemplarEditar = idEjemplar;
            claveEjemplarEditar = claveEjemplar;
            idLibroEditar = idLibro;
            localizacionEditar = localizacion;
            estadoFisicoEditar = estadoFisico;
        }

        // Se ejecuta al abrir el formulario.
        private void frmEjemplarBiblio_Load(object sender, EventArgs e)
        {
            txtCodigoEjemplar.ReadOnly = true;

            // Cargar los libros desde la base de datos.
            CargarLibros();

            if (esModoEdicion)
            {
                // Mostrar los datos del ejemplar seleccionado.
                txtCodigoEjemplar.Text = claveEjemplarEditar;

                // Seleccionar el libro relacionado.
                cmbLibro.SelectedValue = idLibroEditar;

                txtLocalizacion.Text = localizacionEditar;

                if (cmbEstadoFisico.Items.Contains(estadoFisicoEditar))
                {
                    cmbEstadoFisico.SelectedItem = estadoFisicoEditar;
                }
                else
                {
                    cmbEstadoFisico.SelectedIndex = -1;
                }

                btnGuardarEjemplar.Text = "Actualizar";
                Text = "Editar ejemplar";
            }
            else
            {
                // Preparar la pantalla para registrar un ejemplar.
                txtCodigoEjemplar.Text =
                    GenerarSiguienteClaveEjemplar();

                cmbLibro.SelectedIndex = -1;
                cmbEstadoFisico.SelectedIndex = -1;

                txtLocalizacion.Clear();

                btnGuardarEjemplar.Text = "Guardar Ejemplar";
                Text = "Agregar ejemplar";
            }
        }

        // Carga los libros activos en el ComboBox.
        private void CargarLibros()
        {
            ConexionData = new Conexion();

            MySqlConnection con =
                ConexionData.getConection();

            if (con == null)
            {
                return;
            }

            string consulta = @"
                SELECT
                    ID_LIBRO,
                    TITULO
                FROM LIBRO
                WHERE ESTADO = 'ACTIVO'
                ORDER BY TITULO ASC;";

            try
            {
                using (MySqlCommand cmd =
                       new MySqlCommand(consulta, con))
                {
                    using (MySqlDataAdapter adaptador =
                           new MySqlDataAdapter(cmd))
                    {
                        DataTable tablaLibros =
                            new DataTable();

                        adaptador.Fill(tablaLibros);

                        cmbLibro.DataSource = tablaLibros;

                        // Texto que verá el bibliotecario.
                        cmbLibro.DisplayMember = "TITULO";

                        // Valor interno utilizado por el sistema.
                        cmbLibro.ValueMember = "ID_LIBRO";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                con.Close();
            }
        }

        // Genera un código como EJE260009.
        private string GenerarSiguienteClaveEjemplar()
        {
            ConexionData = new Conexion();

            MySqlConnection con =
                ConexionData.getConection();

            if (con == null)
            {
                return "";
            }

            string consulta = @"
                SELECT IFNULL(
                    MAX(
                        CAST(
                            SUBSTRING(CLAVE_EJEMPLAR, 6)
                            AS UNSIGNED
                        )
                    ),
                    0
                ) + 1
                FROM EJEMPLAR
                WHERE CLAVE_EJEMPLAR LIKE 'EJE26%';";

            try
            {
                using (MySqlCommand cmd =
                       new MySqlCommand(consulta, con))
                {
                    object resultado =
                        cmd.ExecuteScalar();

                    int siguienteNumero =
                        Convert.ToInt32(resultado);

                    return "EJE26" +
                           siguienteNumero.ToString("D4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el código del ejemplar: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return "";
            }
            finally
            {
                con.Close();
            }
        }

        // Evento del botón Guardar o Actualizar.
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que exista un código generado.
            if (string.IsNullOrWhiteSpace(
                    txtCodigoEjemplar.Text))
            {
                MessageBox.Show(
                    "No se pudo generar el código del ejemplar.",
                    "Código requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Validar que se haya seleccionado un libro.
            if (cmbLibro.SelectedValue == null ||
                cmbLibro.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione un libro.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbLibro.Focus();
                return;
            }

            // Validar estado físico.
            if (cmbEstadoFisico.SelectedItem == null)
            {
                MessageBox.Show(
                    "Seleccione el estado físico del ejemplar.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                cmbEstadoFisico.Focus();
                return;
            }

            // Validar localización.
            if (string.IsNullOrWhiteSpace(
                    txtLocalizacion.Text))
            {
                MessageBox.Show(
                    "Ingrese la localización del ejemplar.",
                    "Campo obligatorio",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtLocalizacion.Focus();
                return;
            }

            // Obtener el ID del libro seleccionado.
            int idLibro =
                Convert.ToInt32(cmbLibro.SelectedValue);

            string estadoFisico =
                cmbEstadoFisico.SelectedItem
                    .ToString()
                    .Trim()
                    .ToUpper();

            string localizacion =
                txtLocalizacion.Text.Trim();

            // Validar el estado físico.
            if (estadoFisico != "BUENO" &&
                estadoFisico != "REGULAR" &&
                estadoFisico != "DAÑADO")
            {
                MessageBox.Show(
                    "El estado físico seleccionado no es válido.",
                    "Estado inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            ConexionData = new Conexion();

            MySqlConnection con =
                ConexionData.getConection();

            if (con == null)
            {
                return;
            }

            try
            {
                if (esModoEdicion)
                {
                    ActualizarEjemplar(
                        con,
                        idLibro,
                        localizacion,
                        estadoFisico
                    );
                }
                else
                {
                    RegistrarEjemplar(
                        con,
                        idLibro,
                        localizacion,
                        estadoFisico
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el ejemplar: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                con.Close();
            }
        }

        // Registra un ejemplar nuevo.
        private void RegistrarEjemplar(
            MySqlConnection con,
            int idLibro,
            string localizacion,
            string estadoFisico)
        {
            string claveEjemplar =
                txtCodigoEjemplar.Text.Trim();

            string consulta = @"
                INSERT INTO EJEMPLAR
                (
                    CLAVE_EJEMPLAR,
                    ID_LIBRO,
                    LOCALIZACION,
                    ESTADO_FISICO,
                    DISPONIBLE
                )
                VALUES
                (
                    @claveEjemplar,
                    @idLibro,
                    @localizacion,
                    @estadoFisico,
                    'DISPONIBLE'
                );";

            using (MySqlCommand cmd =
                   new MySqlCommand(consulta, con))
            {
                cmd.Parameters.Add(
                    "@claveEjemplar",
                    MySqlDbType.VarChar
                ).Value = claveEjemplar;

                cmd.Parameters.Add(
                    "@idLibro",
                    MySqlDbType.Int32
                ).Value = idLibro;

                cmd.Parameters.Add(
                    "@localizacion",
                    MySqlDbType.VarChar
                ).Value = localizacion;

                cmd.Parameters.Add(
                    "@estadoFisico",
                    MySqlDbType.VarChar
                ).Value = estadoFisico;

                int filasAfectadas =
                    cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(
                        "El ejemplar se registró correctamente.\n" +
                        "Código generado: " + claveEjemplar,
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    RegresarAListaEjemplares();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar el ejemplar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        // Actualiza un ejemplar existente.
        private void ActualizarEjemplar(
            MySqlConnection con,
            int idLibro,
            string localizacion,
            string estadoFisico)
        {
            string consulta = @"
                UPDATE EJEMPLAR
                SET
                    ID_LIBRO = @idLibro,
                    LOCALIZACION = @localizacion,
                    ESTADO_FISICO = @estadoFisico
                WHERE ID_EJEMPLAR = @idEjemplar;";

            using (MySqlCommand cmd =
                   new MySqlCommand(consulta, con))
            {
                cmd.Parameters.Add(
                    "@idLibro",
                    MySqlDbType.Int32
                ).Value = idLibro;

                cmd.Parameters.Add(
                    "@localizacion",
                    MySqlDbType.VarChar
                ).Value = localizacion;

                cmd.Parameters.Add(
                    "@estadoFisico",
                    MySqlDbType.VarChar
                ).Value = estadoFisico;

                cmd.Parameters.Add(
                    "@idEjemplar",
                    MySqlDbType.Int32
                ).Value = idEjemplarEditar;

                int filasAfectadas =
                    cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show(
                        "El ejemplar se actualizó correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    RegresarAListaEjemplares();
                }
                else
                {
                    MessageBox.Show(
                        "No se realizaron modificaciones.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        // Regresa a la tabla de ejemplares.
        private void RegresarAListaEjemplares()
        {
            frmInicioBiblio inicioBiblio =
                Application.OpenForms["frmInicioBiblio"]
                as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmInicioEjemplaresBiblio formulario =
                    new frmInicioEjemplaresBiblio();

                inicioBiblio.AbrirFormularioEnPanel(
                    formulario
                );
            }

            Close();
        }

        // Evento del botón Cancelar.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RegresarAListaEjemplares();
        }
    }
}