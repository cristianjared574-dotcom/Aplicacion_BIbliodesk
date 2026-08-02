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
    public partial class frmAgregarAutor : Form
    {
        private Conexion ConnectionData;
        public frmAgregarAutor()
        {
            InitializeComponent();
            
        }
        private string GenerarMatriculaAutorUnica(MySqlConnection conn)
        {
            string anioActual = DateTime.Now.ToString("yy"); 
            string prefijo = "AUT" + anioActual;
            string nuevaMatricula = prefijo + "0001";

            string query = "SELECT CLAVE_AUTOR FROM autor WHERE CLAVE_AUTOR LIKE @prefijo ORDER BY ID_AUTOR DESC LIMIT 1";

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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtAp.Text))
            {
                MessageBox.Show("Por favor, rellene los campos obligatorios.");
                return;
            }

            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();

                
                string claveAut = GenerarMatriculaAutorUnica(conn);


                string query = "INSERT INTO autor (CLAVE_AUTOR, NOMBRE, APELLIDOP, APELLIDOM, NACIONALIDAD, ESTADO) " +
                               "VALUES (@clave, @nom, @apP, @apM, @nac, @est)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@clave", claveAut);
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@apP", txtAp.Text.Trim());
                    cmd.Parameters.AddWithValue("@apM", txtAm.Text.Trim());
                    cmd.Parameters.AddWithValue("@nac", txtnacionalidad.Text.Trim());
                    cmd.Parameters.AddWithValue("@est", "ACTIVO");

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor registrado correctamente con la matrícula: " + claveAut);
                }

                
                txtNombre.Clear();
                txtAp.Clear();
                txtAm.Clear();
                txtnacionalidad.Clear();
                txtNombre.Focus(); 


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            finally
            {
                conn.Close();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
