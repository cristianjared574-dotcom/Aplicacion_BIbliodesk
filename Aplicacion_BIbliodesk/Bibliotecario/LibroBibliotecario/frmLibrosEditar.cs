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
        private string idLibroActual;
        public frmLibrosEditar(string id, string idEd, string idCat, string isbn, string titulo)
        {
            InitializeComponent();

            idLibroActual = id;
            CargarCombos();

            txtISBN.Text = isbn;
            txtTitulo.Text = titulo;

            cmbEditorial.SelectedValue = idEd;
            cmbCategoria.SelectedValue = idCat;


            // Cargamos el autor actual asociado a este libro
            CargarAutorActual();
        }
        private void CargarCombos()
        {
            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            // Cargar Editoriales
            MySqlDataAdapter daEdit = new MySqlDataAdapter("SELECT ID_EDITORIAL, NOMBRE_EDITORIAL FROM editorial", conn);
            DataTable dtEdit = new DataTable();
            daEdit.Fill(dtEdit);
            cmbEditorial.DataSource = dtEdit;
            cmbEditorial.DisplayMember = "NOMBRE_EDITORIAL";
            cmbEditorial.ValueMember = "ID_EDITORIAL";

            // Cargar Categorías
            MySqlDataAdapter daCat = new MySqlDataAdapter("SELECT ID_CATEGORIA, NOMBRE_CATEGORIA FROM categoria", conn);
            DataTable dtCat = new DataTable();
            daCat.Fill(dtCat);
            cmbCategoria.DataSource = dtCat;
            cmbCategoria.DisplayMember = "NOMBRE_CATEGORIA";
            cmbCategoria.ValueMember = "ID_CATEGORIA";

            // Cargar Autores (Asumiendo que la tabla se llama 'autor' con 'ID_AUTOR' y 'NOMBRE_AUTOR' o similar)
            MySqlDataAdapter daAutor = new MySqlDataAdapter("SELECT ID_AUTOR, NOMBRE FROM autor", conn);
            DataTable dtAutor = new DataTable();
            daAutor.Fill(dtAutor);
            cmbAutor.DataSource = dtAutor;
            cmbAutor.DisplayMember = "NOMBRE";
            cmbAutor.ValueMember = "ID_AUTOR";
        }

        private void CargarAutorActual()
        {
            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string query = "SELECT ID_AUTOR FROM libro_autor WHERE ID_LIBRO = @idLibro LIMIT 1";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idLibro", idLibroActual);
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null && resultado != DBNull.Value)
                    {
                        cmbAutor.SelectedValue = resultado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el autor del libro: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

                // 1. Actualizar los datos principales del libro
                string queryLibro = "UPDATE libro SET ID_EDITORIAL = @idEd, ID_CATEGORIA = @idCat, " +
                                    "ISBN = @isbn, TITULO = @titulo " +
                                    "WHERE ID_LIBRO = @idLibro";

                using (MySqlCommand cmdLibro = new MySqlCommand(queryLibro, conn))
                {
                    cmdLibro.Parameters.AddWithValue("@idLibro", idLibroActual);
                    cmdLibro.Parameters.AddWithValue("@idEd", cmbEditorial.SelectedValue);
                    cmdLibro.Parameters.AddWithValue("@idCat", cmbCategoria.SelectedValue);
                    cmdLibro.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
                    cmdLibro.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());


                    cmdLibro.ExecuteNonQuery();
                }

                // 2. Actualizar el autor en la tabla intermedia 'libro_autor'
                // Primero verificamos si ya existe la relación; si existe se actualiza, si no, se inserta.
                string queryVerificar = "SELECT COUNT(*) FROM libro_autor WHERE ID_LIBRO = @idLibro";
                int existeRelacion = 0;

                using (MySqlCommand cmdVerif = new MySqlCommand(queryVerificar, conn))
                {
                    cmdVerif.Parameters.AddWithValue("@idLibro", idLibroActual);
                    existeRelacion = Convert.ToInt32(cmdVerif.ExecuteScalar());
                }

                string queryAutor = "";
                if (existeRelacion > 0)
                {
                    queryAutor = "UPDATE libro_autor SET ID_AUTOR = @idAutor WHERE ID_LIBRO = @idLibro";
                }
                else
                {
                    queryAutor = "INSERT INTO libro_autor (ID_LIBRO, ID_AUTOR) VALUES (@idLibro, @idAutor)";
                }

                using (MySqlCommand cmdAutor = new MySqlCommand(queryAutor, conn))
                {
                    cmdAutor.Parameters.AddWithValue("@idLibro", idLibroActual);
                    cmdAutor.Parameters.AddWithValue("@idAutor", cmbAutor.SelectedValue);
                    cmdAutor.ExecuteNonQuery();
                }

                MessageBox.Show("Libro actualizado correctamente.");
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

        
    }
}
