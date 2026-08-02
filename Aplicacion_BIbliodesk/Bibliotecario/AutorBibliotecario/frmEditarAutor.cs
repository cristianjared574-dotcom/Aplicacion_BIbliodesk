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

namespace Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario
{
    public partial class frmEditarAutor : Form
    {
        private Conexion ConnectionData;
        private string idAutor;
        public frmEditarAutor(string id, string nombre, string paterno, string materno, string nacionalidad, string estado)
        {
            InitializeComponent();

            
            idAutor = id;

            // 2. Llenamos los TextBox con los datos correspondientes
            txtNombre.Text = nombre;
            txtAp.Text = paterno;
            txtAm.Text = materno;
            txtnacionalidad.Text = nacionalidad;
        }

        private void grpEditarAutor_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validamos que no queden campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtAp.Text) ||
               string.IsNullOrWhiteSpace(txtAm.Text) ||
               string.IsNullOrWhiteSpace(txtnacionalidad.Text))
            {
                MessageBox.Show("Por favor rellene todos los campos");
                return;
            }

            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                
                string query = "UPDATE autor SET NOMBRE=@nom, APELLIDOP=@apP, APELLIDOM=@apM, " +
                               "NACIONALIDAD=@nac WHERE ID_AUTOR=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@apP", txtAp.Text.Trim());
                    cmd.Parameters.AddWithValue("@apM", txtAm.Text.Trim());
                    cmd.Parameters.AddWithValue("@nac", txtnacionalidad.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", idAutor); 

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor actualizado correctamente");
                }

                
                btnCancelar_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar: " + ex.Message);
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open) conn.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmAutorInicio formBusqueda = new frmAutorInicio();


            frmInicioBiblio inicioBiblio = System.Windows.Forms.Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;


            if (inicioBiblio != null)
            {
                inicioBiblio.AbrirFormularioEnPanel(formBusqueda);
            }
        }
    }
}
