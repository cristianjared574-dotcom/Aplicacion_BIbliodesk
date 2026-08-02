using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmEjemplarBiblio : Form
    {
        private Conexion ConexionData;

        // Indica si se registrará o editará un ejemplar
        private bool esModoEdicion = false;

        // Datos usados al editar
        private int idEjemplarEditar = 0;
        private int idLibroEditar = 0;

        // Datos visibles usados al editar.
        private string claveEjemplarEditar = "";
        private string localizacionEditar = "";
        private string estadoFisicoEditar = "";

        // Constructor para agregar un ejemplar
        public frmEjemplarBiblio()
        {
            InitializeComponent();

            esModoEdicion = false;
        }

        // Constructor para editar un ejemplar
        public frmEjemplarBiblio(int idEjemplar, string claveEjemplar,int idLibro, string localizacion,string estadoFisico)
        {
            InitializeComponent();

            esModoEdicion = true;

            idEjemplarEditar = idEjemplar;
            claveEjemplarEditar = claveEjemplar;
            idLibroEditar = idLibro;
            localizacionEditar = localizacion;
            estadoFisicoEditar = estadoFisico;
        }

        // Se ejecuta al abrir el formulario
        private void frmEjemplarBiblio_Load(object sender, EventArgs e)
        {
            txtCodigoEjemplar.ReadOnly = true;

            // Agregar sugerencias de títulos al TextBox
            CargarAutocompletadoLibros();

            if (esModoEdicion)
            {
                // Mostrar los datos del ejemplar seleccionado
                txtCodigoEjemplar.Text = claveEjemplarEditar;
                txtLibro.Text = ObtenerTituloLibro(idLibroEditar);
                txtLocalizacion.Text = localizacionEditar;

                if (cmbEstadoFisico.Items.Contains(estadoFisicoEditar))
                {
                    cmbEstadoFisico.SelectedItem =
                        estadoFisicoEditar;
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
                // formulario para un registro nuevo
                txtCodigoEjemplar.Text =GenerarSiguienteClaveEjemplar();

                txtLibro.Clear();
                txtLocalizacion.Clear();

                cmbEstadoFisico.SelectedIndex = -1;

                btnGuardarEjemplar.Text = "Guardar Ejemplar";
                Text = "Agregar ejemplar";
            }
        }

        // Genera un código como EJE260009
        private string GenerarSiguienteClaveEjemplar()
        {
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con == null)
            {
                return "";
            }

            
            //Obtiene el número mayor de las claves existentes, EJE260008 siguiente código EJE260009.
            
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
                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    object resultado = cmd.ExecuteScalar();

                    int siguienteNumero = Convert.ToInt32(resultado);

                    return "EJE26" + siguienteNumero.ToString("D4");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el código del ejemplar: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return "";
            }
            finally
            {
                con.Close();
            }
        }

        // Agrega títulos existentes como sugerencias del TextBox
        private void CargarAutocompletadoLibros()
        {
            AutoCompleteStringCollection titulos = new AutoCompleteStringCollection();

            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con == null)
            {
                return;
            }

            string consulta = @"
                SELECT TITULO
                FROM LIBRO
                WHERE ESTADO = 'ACTIVO'
                ORDER BY TITULO ASC;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            titulos.Add(
                                reader["TITULO"].ToString()
                            );
                        }
                    }
                }

                txtLibro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                txtLibro.AutoCompleteSource = AutoCompleteSource.CustomSource;

                txtLibro.AutoCompleteCustomSource = titulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error al cargar los títulos de los libros: " + ex.Message, "Error", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            finally
            {
                con.Close();
            }
        }

        // Obtiene el título del libro cuando se edita
        private string ObtenerTituloLibro(int idLibro)
        {
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con == null)
            {
                return "";
            }

            string consulta = @"
                SELECT TITULO
                FROM LIBRO
                WHERE ID_LIBRO = @idLibro;";

            try
            {
                using (MySqlCommand cmd =new MySqlCommand(consulta, con))
                {
                    cmd.Parameters.Add("@idLibro",MySqlDbType.Int32).Value = idLibro;

                    object resultado = cmd.ExecuteScalar();

                    if (resultado == null || resultado == DBNull.Value)
                    {
                        return "";
                    }

                    return resultado.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el título del libro: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

                return "";
            }
            finally
            {
                con.Close();
            }
        }

        // Obtiene el ID interno del libro mediante su título
        private int ObtenerIdLibroPorTitulo(MySqlConnection con,string titulo)
        {
            string consulta = @"
                SELECT ID_LIBRO
                FROM LIBRO
                WHERE TITULO = @titulo
                  AND ESTADO = 'ACTIVO'
                LIMIT 1;";

            using (MySqlCommand cmd = new MySqlCommand(consulta, con))
            {
                cmd.Parameters.Add("@titulo",MySqlDbType.VarChar).Value = titulo;

                object resultado = cmd.ExecuteScalar();

                if (resultado == null ||resultado == DBNull.Value)
                {
                    return 0;
                }

                return Convert.ToInt32(resultado);
            }
        }

        // Evento del botón Guardar o Actualizar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar el código generado
            if (string.IsNullOrWhiteSpace(txtCodigoEjemplar.Text))
            {
                MessageBox.Show( "No se pudo generar el código del ejemplar.", "Código requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            // Validar título del libro
            if (string.IsNullOrWhiteSpace(txtLibro.Text))
            {
                MessageBox.Show( "Ingrese el título del libro.", "Campo obligatorio",MessageBoxButtons.OK,  MessageBoxIcon.Warning);

                txtLibro.Focus();
                return;
            }

            // Validar estado físico.
            if (cmbEstadoFisico.SelectedItem == null)
            {
                MessageBox.Show("Seleccione el estado físico del ejemplar.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                cmbEstadoFisico.Focus();
                return;
            }

            // Validar localización
            if (string.IsNullOrWhiteSpace( txtLocalizacion.Text))
            {
                MessageBox.Show("Ingrese la localización del ejemplar.",  "Campo obligatorio", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                txtLocalizacion.Focus();
                return;
            }

            string tituloLibro = txtLibro.Text.Trim();

            string estadoFisico = cmbEstadoFisico.SelectedItem .ToString().Trim().ToUpper();

            string localizacion = txtLocalizacion.Text.Trim();

            // Comprobar que el estado físico sea válido.
            if (estadoFisico != "BUENO" && estadoFisico != "REGULAR" && estadoFisico != "DAÑADO")
            {
                MessageBox.Show( "El estado físico seleccionado no es válido.", "Estado inválido",  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con == null)
            {
                return;
            }

            try
            {
                
                 //El usuario escribe el título pero el sistema obtiene el ID_LIBRO
                 
                int idLibro = ObtenerIdLibroPorTitulo(con, tituloLibro );

                if (idLibro == 0)
                {
                    MessageBox.Show( "El libro ingresado no existe o está dado de baja.\n" + "Seleccione uno de los títulos existentes.", "Libro no encontrado", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    txtLibro.Focus();
                    return;
                }

                if (esModoEdicion)
                {
                    ActualizarEjemplar( con, idLibro, localizacion,  estadoFisico );
                }
                else
                {
                    RegistrarEjemplar( con,idLibro,localizacion, estadoFisico );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( "Error al guardar el ejemplar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // Registra un ejemplar nuevo
        private void RegistrarEjemplar( MySqlConnection con, int idLibro, string localizacion, string estadoFisico)
        {
            string claveEjemplar =txtCodigoEjemplar.Text.Trim();

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

            using (MySqlCommand cmd = new MySqlCommand(consulta, con))
            {
                cmd.Parameters.Add("@claveEjemplar",MySqlDbType.VarChar ).Value = claveEjemplar;

                cmd.Parameters.Add("@idLibro", MySqlDbType.Int32 ).Value = idLibro;

                cmd.Parameters.Add( "@localizacion",MySqlDbType.VarChar ).Value = localizacion;

                cmd.Parameters.Add( "@estadoFisico", MySqlDbType.VarChar).Value = estadoFisico;

                int filasAfectadas =cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show( "El ejemplar se registró correctamente.\n" + "Código generado: " + claveEjemplar, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RegresarAListaEjemplares();
                }
                else
                {
                    MessageBox.Show( "No se pudo registrar el ejemplar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Actualiza un ejemplar existente
        private void ActualizarEjemplar( MySqlConnection con,int idLibro,string localizacion,string estadoFisico)
        {
            string consulta = @"
                UPDATE EJEMPLAR
                SET
                    ID_LIBRO = @idLibro,
                    LOCALIZACION = @localizacion,
                    ESTADO_FISICO = @estadoFisico
                WHERE ID_EJEMPLAR = @idEjemplar;";

            using (MySqlCommand cmd =new MySqlCommand(consulta, con))
            {
                cmd.Parameters.Add("@idLibro",MySqlDbType.Int32).Value = idLibro;

                cmd.Parameters.Add("@localizacion",MySqlDbType.VarChar ).Value = localizacion;

                cmd.Parameters.Add("@estadoFisico", MySqlDbType.VarChar ).Value = estadoFisico;

                cmd.Parameters.Add("@idEjemplar", MySqlDbType.Int32).Value = idEjemplarEditar;

                int filasAfectadas = cmd.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show( "El ejemplar se actualizó correctamente.", "Éxito", MessageBoxButtons.OK,MessageBoxIcon.Information);

                    RegresarAListaEjemplares();
                }
                else
                {
                    MessageBox.Show("No se realizaron modificaciones.", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Regresa a la tabla de ejemplares
        private void RegresarAListaEjemplares()
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmInicioEjemplaresBiblio formulario = new frmInicioEjemplaresBiblio();

                inicioBiblio.AbrirFormularioEnPanel(formulario);
            }

            Close();
        }

        // Evento del botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            RegresarAListaEjemplares();
        }
    }
}