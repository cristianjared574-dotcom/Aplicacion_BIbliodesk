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
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmEditarAutor EditarAutor = new frmEditarAutor();
                inicioBiblio.AbrirFormularioEnPanel(EditarAutor);
            }
        }
    }
}
