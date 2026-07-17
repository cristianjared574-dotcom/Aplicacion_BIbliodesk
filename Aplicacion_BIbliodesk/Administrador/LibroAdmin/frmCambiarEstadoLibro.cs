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

namespace Aplicacion_BIbliodesk.Administrador.LibroAdmin
{
    public partial class frmCambiarEstadoLibro : Form
    {
        public frmCambiarEstadoLibro()
        {
            InitializeComponent();
            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("INACTIVO");

            // Cargamos los libros automáticamente al abrir
            CargarLibros();
        }

        private void CargarLibros()
        {
            Conexion.ConnectionData con = new Conexion.ConnectionData();
            using (MySqlConnection conn = con.getConection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string query = "SELECT ID_LIBRO, TITULO FROM libro";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Vinculamos el ComboBox a la tabla
                    cmbLibro.DataSource = dt;
                    cmbLibro.DisplayMember = "TITULO";
                    cmbLibro.ValueMember = "ID_LIBRO";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar libros: " + ex.Message);
                }
            }
        }

        private void ActualizarEstado(int id, string nuevoEstado)
        {
            if (string.IsNullOrEmpty(nuevoEstado))
            {
                MessageBox.Show("Por favor selecciona un estado.");
                return;
            }

            Conexion.ConnectionData con = new Conexion.ConnectionData();
            using (MySqlConnection conn = con.getConection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    string query = "UPDATE libro SET ESTADO = @estado WHERE ID_LIBRO = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", id);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Estado actualizado correctamente");
                            /*if (this.ParentForm is frmInicioAdmin formInicio)
                            {
                                formInicio.AbrirFormularioEnPanel(new frmLibrosBuscar());
                            }
                            */
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el libro para actualizar.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error técnico: " + ex.Message);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedValue != null)
            {
                int idSeleccionado = Convert.ToInt32(cmbLibro.SelectedValue);
                ActualizarEstado(idSeleccionado, cmbEstado.Text);
            }
            else
            {
                MessageBox.Show("Selecciona un libro primero.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            /*if (this.ParentForm is frmInicioAdmin formInicio)
                  {
                   formInicio.AbrirFormularioEnPanel(new frmLibrosBuscar());
                  }
            */
        }
    }
}
