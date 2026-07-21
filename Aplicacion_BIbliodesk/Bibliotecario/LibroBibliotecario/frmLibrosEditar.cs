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

namespace Aplicacion_BIbliodesk.Bibliotecario.LibroBibliotecario
{
    public partial class frmLibrosEditar : Form
    {
        private Conexion ConnectionData;
        public frmLibrosEditar(string id, string idEd, string idCat, string isbn, string titulo, string estado)
        {
            InitializeComponent();

            CargarCombos();


            txtIdLibro.Text = id;
            txtIdLibro.ReadOnly = true;
            txtISBN.Text = isbn;
            txtTitulo.Text = titulo;


            cmbEditorial.SelectedValue = idEd;
            cmbCategoria.SelectedValue = idCat;
            cmbEstado.Text = estado;


            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("INACTIVO");
            cmbEstado.SelectedIndex = 0;
            txtIdLibro.ReadOnly = true;
        }
        private void CargarCombos()
        {
            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();


            MySqlDataAdapter daEdit = new MySqlDataAdapter("SELECT ID_EDITORIAL, NOMBRE_EDITORIAL FROM editorial", conn);
            DataTable dtEdit = new DataTable();
            daEdit.Fill(dtEdit);
            cmbEditorial.DataSource = dtEdit;
            cmbEditorial.DisplayMember = "NOMBRE_EDITORIAL";
            cmbEditorial.ValueMember = "ID_EDITORIAL";


            MySqlDataAdapter daCat = new MySqlDataAdapter("SELECT ID_CATEGORIA, NOMBRE_CATEGORIA FROM categoria", conn);
            DataTable dtCat = new DataTable();
            daCat.Fill(dtCat);
            cmbCategoria.DataSource = dtCat;
            cmbCategoria.DisplayMember = "NOMBRE_CATEGORIA";
            cmbCategoria.ValueMember = "ID_CATEGORIA";

            string query = "SELECT id_libro, titulo FROM libro";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbLibro.DisplayMember = "titulo";
            cmbLibro.ValueMember = "id_libro";
            cmbLibro.DataSource = dt;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Rellene los campos obligatorios.");
                return;
            }

            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();


                string query = "UPDATE libro SET ID_EDITORIAL = @idEd, ID_CATEGORIA = @idCat, " +
                               "ISBN = @isbn, TITULO = @titulo, ESTADO = @estado " +
                               "WHERE ID_LIBRO = @idLibro";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@idLibro", txtIdLibro.Text.Trim());
                    cmd.Parameters.AddWithValue("@idEd", cmbLibro.SelectedValue);
                    cmd.Parameters.AddWithValue("@idCat", cmbEstado.SelectedValue);
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Libro actualizado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmLibrosBuscar formBusqueda = new frmLibrosBuscar();
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                inicioBiblio.AbrirFormularioEnPanel(formBusqueda);
            }
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLibro.SelectedIndex != -1 && cmbLibro.SelectedValue != null)
            {
                ConnectionData = new Conexion();
                MySqlConnection conn = ConnectionData.getConection();

                // Contamos cuántos registros existen en la tabla 'ejemplar' para ese libro
                string query = "SELECT COUNT(*) FROM ejemplar WHERE id_libro = @id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", cmbLibro.SelectedValue);

                try
                {
                    // ExecuteScalar devuelve el resultado del COUNT
                    object result = cmd.ExecuteScalar();
                    txtStock.Text = (result != null) ? result.ToString() : "0";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al contar ejemplares: " + ex.Message);
                }

            }
        }
    }
}
