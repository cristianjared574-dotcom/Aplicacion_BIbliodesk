using Microsoft.SqlServer.Server;
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

namespace Aplicacion_BIbliodesk.Administrador.AutorAdmin
{
    public partial class frmAutorInicio : Form
    {
        private Conexion dataAccess;
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
            dataAccess = new Conexion();

            using (MySqlConnection conn = dataAccess.getConection())
            {
                
                string query = @"SELECT  
                                    ID_AUTOR, 
                                    CLAVE_AUTOR AS 'Clave autor', 
                                    NOMBRE AS 'Nombre', 
                                    APELLIDOP AS 'Apellido paterno', 
                                    APELLIDOM AS 'Apellido materno', 
                                    NACIONALIDAD AS 'Nacionalidad', 
                                    ESTADO AS 'Estado' 
                                 FROM autor 
                                 WHERE NOMBRE LIKE @criterio 
                                    OR APELLIDOP LIKE @criterio 
                                    OR APELLIDOM LIKE @criterio 
                                    OR CLAVE_AUTOR LIKE @criterio";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@criterio", "%" + filtro.Trim() + "%");

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAutores.DataSource = dt;

                    
                    if (dgvAutores.Columns["ID_AUTOR"] != null)
                    {
                        dgvAutores.Columns["ID_AUTOR"].Visible = false;
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarDatos(txtBuscar.Text);
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            frmInicioAdmin inicioAdmin = Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                frmCambiarEstadoAutor CambioEstadoAutor = new frmCambiarEstadoAutor();
                inicioAdmin.AbrirFormularioEnPanelAdmin(CambioEstadoAutor);
            }
        }
    }
}
