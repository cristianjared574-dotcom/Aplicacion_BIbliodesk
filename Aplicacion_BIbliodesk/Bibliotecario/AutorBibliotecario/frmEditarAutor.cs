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
        public frmEditarAutor(string id, string nombre, string paterno, string materno, string nacionalidad, string estado)
        {
            InitializeComponent();
            txtIdAutor.Text = id;
            txtNombre.Text = nombre;
            txtAp.Text = paterno;
            txtAm.Text = materno;
            txtnacionalidad.Text = nacionalidad;
            cmbEstado.Text = estado;

            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("INACTIVO");
            cmbEstado.SelectedIndex = 0;
            txtIdAutor.ReadOnly = true;
        }

        private void grpEditarAutor_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
               string.IsNullOrWhiteSpace(txtAp.Text) ||
               string.IsNullOrWhiteSpace(txtAm.Text) ||
               string.IsNullOrWhiteSpace(txtnacionalidad.Text) ||
               string.IsNullOrWhiteSpace(cmbEstado.Text))
            {
                MessageBox.Show("Por favor rellene todos los campos");
                return;

            }

            ConnectionData = new Conexion();
            MySqlConnection conn = ConnectionData.getConection();

            try
            {
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                string query = "UPDATE autor SET NOMBRE=@nom,APELLIDOP=@apP,APELLIDOM=@apM," +
                    "NACIONALIDAD=@nac,ESTADO=@est WHERE ID_AUTOR=@id";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", txtIdAutor.Text.Trim());
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@apP", txtAp.Text.Trim());
                    cmd.Parameters.AddWithValue("@apM", txtAm.Text.Trim());
                    cmd.Parameters.AddWithValue("@nac", txtnacionalidad.Text.Trim());
                    cmd.Parameters.AddWithValue("@est", cmbEstado.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Autor registrado correctamente");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Actualizar: " + ex.Message);
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
