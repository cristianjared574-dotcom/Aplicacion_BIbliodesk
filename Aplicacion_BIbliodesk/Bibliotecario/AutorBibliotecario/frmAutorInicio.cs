using Aplicacion_BIbliodesk.Bibliotecario.LibroBibliotecario;
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
    public partial class frmAutorInicio : Form
    {
        private Conexion ConnectionData;
        public frmAutorInicio()
        {
            InitializeComponent();
        }
        private void frmAutorInicio_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(string filtro)
        {
            ConnectionData = new Conexion();

            MySqlConnection conn = ConnectionData.getConection();

            string query = "SELECT ID_AUTOR, NOMBRE, APELLIDOP, APELLIDOM, NACIONALIDAD, ESTADO FROM autor WHERE NOMBRE LIKE @criterio";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@criterio", "%" + filtro.Trim() + "%");

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvAutor.DataSource = dt;
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.Text);
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmAgregarAutor AgregarAutor = new frmAgregarAutor();
                inicioBiblio.AbrirFormularioEnPanel(AgregarAutor);
            }
        }

        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            if(dgvAutor.SelectedRows.Count > 0)
{

                DataGridViewRow fila = dgvAutor.SelectedRows[0];


                string id = fila.Cells["id_autor"].Value.ToString();


                string nombre = fila.Cells["nombre"].Value.ToString();


                string paterno = fila.Cells["apellidop"].Value.ToString();

                string materno = fila.Cells["apellidom"].Value.ToString();

                string nacionalidad = fila.Cells["nacionalidad"].Value.ToString();



                string estado = fila.Cells["estado"].Value.ToString();

                frmEditarAutor formEdicion = new frmEditarAutor(id, nombre, paterno, materno, nacionalidad, estado);

                frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

                if (inicioBiblio != null)
                {
                    inicioBiblio.AbrirFormularioEnPanel(formEdicion);
                }
                else
                {

                    MessageBox.Show("Por favor, selecciona una fila");

                }

            }
        }
    }
}
