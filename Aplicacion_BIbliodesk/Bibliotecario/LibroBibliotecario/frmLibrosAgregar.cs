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
    public partial class frmLibrosAgregar : Form
    {
        private Conexion ConnectionData;
        public frmLibrosAgregar()
        {
            InitializeComponent();
            CargarComboBoxes();
            
        }

        private void CargarComboBoxes()
        {
            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();
            
                // Cargar Editoriales
                string queryEdit = "SELECT ID_EDITORIAL, NOMBRE_EDITORIAL FROM editorial";
                MySqlDataAdapter daEdit = new MySqlDataAdapter(queryEdit, conn);
                DataTable dtEdit = new DataTable();
                daEdit.Fill(dtEdit);
                cmbEditorial.DataSource = dtEdit;
                cmbEditorial.DisplayMember = "NOMBRE_EDITORIAL";
                cmbEditorial.ValueMember = "ID_EDITORIAL";

                // Cargar Categorías
                string queryCat = "SELECT ID_CATEGORIA, NOMBRE_CATEGORIA FROM categoria";
                MySqlDataAdapter daCat = new MySqlDataAdapter(queryCat, conn);
                DataTable dtCat = new DataTable();
                daCat.Fill(dtCat);
                cmbCategoria.DataSource = dtCat;
                cmbCategoria.DisplayMember = "NOMBRE_CATEGORIA";
                cmbCategoria.ValueMember = "ID_CATEGORIA";

                // Cargar Autores
                string queryAut = "SELECT ID_AUTOR, NOMBRE FROM autor";
                MySqlDataAdapter daAut = new MySqlDataAdapter(queryAut, conn);
                DataTable dtAut = new DataTable();
                daAut.Fill(dtAut);
                cmbAutor.DataSource = dtAut;
                cmbAutor.DisplayMember = "NOMBRE";
                cmbAutor.ValueMember = "ID_AUTOR";


        }
        private string GenerarMatriculaUnica(MySqlConnection conn)
        {
            string anioActual = DateTime.Now.ToString("yy"); 
            string prefijo = "LIB" + anioActual;
            string nuevaMatricula = prefijo + "0001";

            string query = "SELECT CLAVE_LIBRO FROM libro WHERE CLAVE_LIBRO LIKE @prefijo ORDER BY ID_LIBRO DESC LIMIT 1";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@prefijo", prefijo + "%");
                object resultado = cmd.ExecuteScalar();

                if (resultado != null && resultado != DBNull.Value)
                {
                    string ultimaMatricula = resultado.ToString();
                    
                    string parteNumerica = ultimaMatricula.Substring(5);

                    if (int.TryParse(parteNumerica, out int numero))
                    {
                        numero++;
                       
                        nuevaMatricula = prefijo + numero.ToString("D4");
                    }
                }
            }

            return nuevaMatricula;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) || string.IsNullOrWhiteSpace(txtISBN.Text))
            {
                MessageBox.Show("Rellene los campos obligatorios.");
                return;
            }
            if (cmbAutor.SelectedValue == null)
            {
                MessageBox.Show("Por favor, seleccione un autor.");
                return;
            }

            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

               
                string claveLibroUnica = GenerarMatriculaUnica(conn);

              
                string queryLibro = "INSERT INTO libro (CLAVE_LIBRO, ID_EDITORIAL, ID_CATEGORIA, ISBN, TITULO) VALUES (@clave, @idEd, @idCat, @isbn, @titulo)";

                using (MySqlCommand cmdLibro = new MySqlCommand(queryLibro, conn))
                {
                    cmdLibro.Parameters.AddWithValue("@clave", claveLibroUnica);
                    cmdLibro.Parameters.AddWithValue("@idEd", cmbEditorial.SelectedValue);
                    cmdLibro.Parameters.AddWithValue("@idCat", cmbCategoria.SelectedValue);
                    cmdLibro.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
                    cmdLibro.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());

                    cmdLibro.ExecuteNonQuery();
                }

               
                long idLibroNuevo = 0;
                string queryId = "SELECT LAST_INSERT_ID();";
                using (MySqlCommand cmdId = new MySqlCommand(queryId, conn))
                {
                    idLibroNuevo = Convert.ToInt64(cmdId.ExecuteScalar());
                }

                
                string queryAutorLibro = "INSERT INTO libro_autor (ID_AUTOR, ID_LIBRO) VALUES (@idAutor, @idLibro)";

                using (MySqlCommand cmdAutorLibro = new MySqlCommand(queryAutorLibro, conn))
                {
                    cmdAutorLibro.Parameters.AddWithValue("@idAutor", cmbAutor.SelectedValue);
                    cmdAutorLibro.Parameters.AddWithValue("@idLibro", idLibroNuevo);

                    cmdAutorLibro.ExecuteNonQuery();
                }

                MessageBox.Show("Libro guardado correctamente con matrícula: " + claveLibroUnica);

                txtISBN.Clear();
                txtTitulo.Text = "";
                cmbEditorial.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
                cmbAutor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el libro: " + ex.Message);
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

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

