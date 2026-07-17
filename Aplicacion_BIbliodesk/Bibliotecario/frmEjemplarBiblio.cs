using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmEjemplarBiblio : Form
    {
        // Variables declaradas
        private bool esModoEdicion = false;
        private string idEjemplarRecibido = "";
        private string idLibroRecibido = "";
        private string localizacionRecibida = "";

       //agregar un ejemplar sin parametros
        public frmEjemplarBiblio()
        {
            InitializeComponent();
            esModoEdicion = false;
        }

        
        // constructor para editar 
        
        public frmEjemplarBiblio(string idEjemplar, string idLibro, string localizacion)
        {
            InitializeComponent();
            esModoEdicion = true;

            // Guardar la información que viene de la tabla
            this.idEjemplarRecibido = idEjemplar;
            this.idLibroRecibido = idLibro;
            this.localizacionRecibida = localizacion;
        }


        
        // Evento para configurar la pantalla al abrirse
       
        private void frmEjemplarBiblio_Load(object sender, EventArgs e)
        {
            if (esModoEdicion)
            {
                // Muestra los datos seleccionados y bloquea la llave primaria
                txtIdEjemplar.Text = idEjemplarRecibido;
                txtIdLibro.Text = idLibroRecibido;
                txtLocalizacion.Text = localizacionRecibida;

                txtIdEjemplar.ReadOnly = true;
                btnGuardarEjemplar.Text = "Actualizar";
                this.Text = "Editar Ejemplar";
            }
            else
            {
                // Deja los campos libres para capturar un registro nuevo
                txtIdEjemplar.Clear();
                txtIdEjemplar.ReadOnly = false;
                txtIdLibro.Clear();
                txtLocalizacion.Clear();

                btnGuardarEjemplar.Text = "Guardar";
                this.Text = "Nuevo Ejemplar";
            }
        }

        //Evento del boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validamos que no se dejen campos en blanco
            if (string.IsNullOrWhiteSpace(txtIdEjemplar.Text) ||
                string.IsNullOrWhiteSpace(txtIdLibro.Text) ||
                string.IsNullOrWhiteSpace(txtLocalizacion.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //declarar variable del estado fisico para que sea bueno y que este activo
            string estadoFisicoPorDefecto = "BUENO";
            string disponiblePorDefecto = "ACTIVO";

            using (MySqlConnection con = Conexion.getConection())
            {
                if (con == null) return;

                string query = "";

                if (esModoEdicion)
                {
                    query = "UPDATE ejemplar SET ID_LIBRO = @idLibro, LOCALIZACION = @localizacion WHERE ID_EJEMPLAR = @idEjemplar";
                }
                else
                {
                    query = "INSERT INTO ejemplar (ID_EJEMPLAR, ID_LIBRO, LOCALIZACION, ESTADO_FISICO, DISPONIBLE) " +
                            "VALUES (@idEjemplar, @idLibro, @localizacion, 'Excelente', 'S')";
                }

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@idEjemplar", txtIdEjemplar.Text.Trim());
                        cmd.Parameters.AddWithValue("@idLibro", txtIdLibro.Text.Trim());
                        cmd.Parameters.AddWithValue("@localizacion", txtLocalizacion.Text.Trim());

                        // agregar los valores por defecto asignados arriba
                        if (!esModoEdicion)
                        {
                            cmd.Parameters.AddWithValue("@estadoFisico", estadoFisicoPorDefecto);
                            cmd.Parameters.AddWithValue("@disponible", disponiblePorDefecto);
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            string mensaje = esModoEdicion ? "Ejemplar actualizado con éxito." : "Ejemplar registrado con éxito.";
                            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK; // Indica éxito al formulario principal
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se realizaron modificaciones en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Evento del boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
