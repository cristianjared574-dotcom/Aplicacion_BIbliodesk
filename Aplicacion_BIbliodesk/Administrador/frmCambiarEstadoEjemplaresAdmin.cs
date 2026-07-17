using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmCambiarEstadoEjemplaresAdmin : Form
    {
        //creacion de variables para almacenar los datos del formulario de inicio ejemplares admin
        private string idEjemplar;
        private string estadoActual;

        //constructor para que reciba los datos del formulario de inicio ejemplares admin
        public frmCambiarEstadoEjemplaresAdmin(string id, string estado)
        {
            InitializeComponent();

            this.idEjemplar = id;
            this.estadoActual = estado;
        }

        // Se ejecuta al cargar el formulario
        private void frmCambiarEstadoEjemplaresAdmin_Load(object sender, EventArgs e)
        {
            // Mostrar por defecto los datos actuales en la interfaz
            txtIdEjemplar.Text = idEjemplar;
            cmbEstado.Text = estadoActual;
        }

        // Guarda la actualización en la base de datts mediante el boton de guardar cambios
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // se verifica que se haya seleccionado un estado válido
            if (cmbEstado.SelectedItem == null && string.IsNullOrEmpty(cmbEstado.Text))
            {
                //y sino le aparece ese mensaje de aviso
                MessageBox.Show("Por favor, seleccione un estado válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nuevoEstado = cmbEstado.Text.Trim();

            
            using (MySqlConnection con = Conexion.ConnectionData.getConection())//conecta a la base
            {
                if (con == null) return;

                // Query para actualizar el estado ya sea activo o inactivo del ejemplar en la base
                string query = "UPDATE ejemplar SET ESTADO = @nuevoEstado WHERE ID_EJEMPLAR = @id";

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        // se añaden los parametros
                        cmd.Parameters.AddWithValue("@nuevoEstado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", idEjemplar);

                        // Ejecutar la consulta
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            //mensaje de actualizacion correcta
                            MessageBox.Show("El estado del ejemplar se ha actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Indicar que la operación fue exitosa para que el formulario de inicio se actualice
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            //y sino le muestra un mensaje de aviso
                            MessageBox.Show("No se realizaron cambios en la base de datos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //aqui el mensaje ya seria debido a un error de la base
                    MessageBox.Show("Error al actualizar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Si presiona el boton de cancelar entonces  se Cierra la ventana sin guardar cambios
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
    
}
