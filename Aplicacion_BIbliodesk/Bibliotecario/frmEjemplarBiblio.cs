using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmEjemplarBiblio : Form
    {
        private Conexion ConexionData;

        // Variables declaradas
        private bool esModoEdicion = false;
        private int idEjemplarRecibido = 0;
        private int idLibroRecibido = 0;

        private string localizacionRecibida = "";
        private string estadoFisicoRecibido = "";
        private string disponibleRecibido = "";
        private int idEjemplarEditar = 0;

        //agregar un ejemplar sin parametros
        public frmEjemplarBiblio()
        {
            InitializeComponent();
            esModoEdicion = false;
            esModoEdicion = false;

            txtIdEjemplar.Text = "Se genera automáticamente";
            txtIdEjemplar.ReadOnly = true;

            txtIdLibro.Clear();
            txtLocalizacion.Clear();
            
            btnGuardarEjemplar.Text = "Guardar";
        }


        

        // Constructor para editar
        public frmEjemplarBiblio(
            int idEjemplar,
            int idLibro,
            string localizacion,
            string estadoFisico,
            string disponible)
        {
            InitializeComponent();

            esModoEdicion = true;
            idEjemplarEditar = idEjemplar;

            // Llenar directamente las cajas
            txtIdEjemplar.Text = idEjemplar.ToString();
            txtIdLibro.Text = idLibro.ToString();
            txtLocalizacion.Text = localizacion;
           
            txtIdEjemplar.ReadOnly = true;

            btnGuardarEjemplar.Text = "Actualizar";
        }



        // Evento para configurar la pantalla al abrirse

        private void frmEjemplarBiblio_Load(object sender, EventArgs e)
        {

            /*if (esModoEdicion)
            {
                // Muestra los datos seleccionados y bloquea la llave primaria
                txtIdEjemplar.Text = idEjemplarRecibido.ToString();
                txtIdLibro.Text = idLibroRecibido.ToString();
                txtLocalizacion.Text = localizacionRecibida;

                txtIdEjemplar.ReadOnly = true;
                btnGuardarEjemplar.Text = "Actualizar";
                this.Text = "Editar Ejemplar";
            }
            else
            {
                // Deja los campos libres para capturar un registro nuevo
                txtIdEjemplar.Clear();
                txtIdEjemplar.ReadOnly = true;
                txtIdEjemplar.Text = "Se genera automaticamente";
                txtIdLibro.Clear();
                txtLocalizacion.Clear();

                btnGuardarEjemplar.Text = "Guardar";
                this.Text = "Nuevo Ejemplar";
            }*/
        }

        //Evento del boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar los campos que captura el usuario
            if (string.IsNullOrWhiteSpace(txtIdLibro.Text) ||
                string.IsNullOrWhiteSpace(txtLocalizacion.Text))
            {
                MessageBox.Show(
                    "Por favor, llene todos los campos obligatorios.",
                    "Campos vacíos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

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
                if (esModoEdicion)
                {
                    // Actualizar el ejemplar existente
                    string queryActualizar = @"
                UPDATE EJEMPLAR
                SET ID_LIBRO =
                    (SELECT ID_LIBRO
                     FROM LIBRO
                     WHERE ID_LIBRO = @idLibro),
                    LOCALIZACION = @localizacion
                WHERE ID_EJEMPLAR = @idEjemplar;";

                    MySqlCommand cmdActualizar =
                        new MySqlCommand(queryActualizar, con);

                    cmdActualizar.Parameters.AddWithValue(
                        "@idLibro",
                        txtIdLibro.Text.Trim());

                    cmdActualizar.Parameters.AddWithValue(
                        "@localizacion",
                        txtLocalizacion.Text.Trim());

                    cmdActualizar.Parameters.AddWithValue(
                        "@idEjemplar",
                        txtIdEjemplar.Text.Trim());

                    int filasAfectadas =
                        cmdActualizar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show(
                            "Ejemplar actualizado con éxito.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se realizaron modificaciones.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Insertar sin escribir la clave del ejemplar
                    string queryInsertar = @"
                INSERT INTO EJEMPLAR
                (
                    ID_LIBRO,
                    LOCALIZACION,
                    ESTADO_FISICO,
                    DISPONIBLE
                )
                VALUES
                (
                    (SELECT ID_LIBRO
                     FROM LIBRO
                     WHERE ID_LIBRO = @idLibro),
                    @localizacion,
                    'BUENO',
                    'DISPONIBLE'
                );";

                    MySqlCommand cmdInsertar =
                        new MySqlCommand(queryInsertar, con);

                    cmdInsertar.Parameters.AddWithValue(
                        "@idLibro",
                        txtIdLibro.Text.Trim());

                    cmdInsertar.Parameters.AddWithValue(
                        "@localizacion",
                        txtLocalizacion.Text.Trim());

                    int filasAfectadas =
                        cmdInsertar.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        // Obtener el ID automático generado por MySQL
                        //int idEjemplarGenerado =
                        // Convert.ToInt32(cmdInsertar.LastInsertedId);

                        // Crear la clave: EJE001, EJE002...
                        //string claveEjemplarGenerada =
                        //"EJE" + idEjemplarGenerado.ToString("D3");

                        // Guardar la clave generada
                        /*string queryClave = @"
                    UPDATE EJEMPLAR
                    SET CLAVE_EJEMPLAR = @claveEjemplar
                    WHERE ID_EJEMPLAR = @idEjemplar;";

                        MySqlCommand cmdClave =
                            new MySqlCommand(queryClave, con);

                        cmdClave.Parameters.AddWithValue(
                            "@claveEjemplar",
                            claveEjemplarGenerada);

                        cmdClave.Parameters.AddWithValue(
                            "@idEjemplar",
                            idEjemplarGenerado);

                        cmdClave.ExecuteNonQuery();

                        MessageBox.Show(
                            "Ejemplar registrado con éxito.\n" +
                            "Clave generada: " + claveEjemplarGenerada,
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);*/
                        MessageBox.Show(
                            "Ejemplar registrado con éxito.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Close();
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar en la base de datos: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                con.Close();
            }

        }

        //Evento del boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if(inicioBiblio != null)
            {
                frmInicioEjemplaresBiblio inicioEjemplar = new frmInicioEjemplaresBiblio();
                inicioBiblio.AbrirFormularioEnPanel(inicioEjemplar);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
