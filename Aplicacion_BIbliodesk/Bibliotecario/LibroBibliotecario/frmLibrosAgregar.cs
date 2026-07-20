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
            var estados = new[] { "ACTIVO", "INACTIVO" };
            cmbEstado.DataSource = estados;
            cmbEstado.SelectedIndex = 0;
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
            
            
                
                string query = "INSERT INTO libro (ID_EDITORIAL, ID_CATEGORIA, ISBN, TITULO, ESTADO) VALUES (@idEd, @idCat, @isbn, @titulo, @estado)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idEd", cmbEditorial.SelectedValue);
                    cmd.Parameters.AddWithValue("@idCat", cmbCategoria.SelectedValue); 
                    cmd.Parameters.AddWithValue("@isbn", txtISBN.Text.Trim());
                    cmd.Parameters.AddWithValue("@titulo", txtTitulo.Text.Trim());
                    cmd.Parameters.AddWithValue("@estado", cmbEstado.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guardado.");
                    
                }
            
            txtISBN.Clear();
            txtTitulo.Text = "";
            cmbEditorial.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbEstado.SelectedIndex = 0;
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
                        txtstock.Text = (result != null) ? result.ToString() : "0";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al contar ejemplares: " + ex.Message);
                    }
                
            }
        }
    }

}

