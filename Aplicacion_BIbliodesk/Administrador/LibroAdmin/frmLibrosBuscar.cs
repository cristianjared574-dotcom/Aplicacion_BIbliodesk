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

namespace Aplicacion_BIbliodesk.Administrador.LibroAdmin
{
    public partial class frmLibrosBuscar : Form
    {
        public frmLibrosBuscar()
        {
            InitializeComponent();
        }

        private void frmLibrosBuscar_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
        private void CargarDatos(string filtro)
        {
            Conexion.ConnectionData con = new Conexion.ConnectionData();

                string query = "SELECT ID_LIBRO, TITULO, ISBN, ESTADO FROM LIBRO WHERE TITULO LIKE @criterio OR ISBN LIKE @criterio";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // El filtro se aplica a ambos campos
                    cmd.Parameters.AddWithValue("@criterio", "%" + filtro.Trim() + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLibros.DataSource = dt;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.Text);
        }

        private void btncambiarEstado_Click(object sender, EventArgs e)
        {
           
        }
    }
}
