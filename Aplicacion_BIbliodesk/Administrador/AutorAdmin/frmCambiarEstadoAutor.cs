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

namespace Aplicacion_BIbliodesk.Administrador.AutorAdmin
{
    public partial class frmCambiarEstadoAutor : Form
    {
        public frmCambiarEstadoAutor()
        {
            InitializeComponent();
            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("INACTIVO");
            CargarAutores();
        }

        private void CargarAutores()
        {
            Conexion.ConnectionData con = new Conexion.ConnectionData();
            using (MySqlConnection conn = con.getConection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    // Asegúrate de que los nombres de las columnas sean ID_AUTOR y NOMBRE
                    string query = "SELECT ID_AUTOR, NOMBRE FROM autor";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbAutor.DataSource = dt;
                    cmbAutor.DisplayMember = "NOMBRE";
                    cmbAutor.ValueMember = "ID_AUTOR";
                }
                catch (Exception ex) { MessageBox.Show("Error al cargar autores: " + ex.Message); }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbAutor.SelectedValue == null) return;

            int idSeleccionado = Convert.ToInt32(cmbAutor.SelectedValue);
            string nuevoEstado = cmbEstado.Text;

            Conexion.ConnectionData con = new Conexion.ConnectionData();
            using (MySqlConnection conn = con.getConection())
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    string query = "UPDATE autor SET ESTADO = @estado WHERE ID_AUTOR = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                        cmd.Parameters.AddWithValue("@id", idSeleccionado);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Estado del autor actualizado");
                            //if (this.ParentForm is frmInicioAdmin f) f.AbrirFormularioEnPanel(new frmAutorInicio());
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
            }
        }
    }
}
