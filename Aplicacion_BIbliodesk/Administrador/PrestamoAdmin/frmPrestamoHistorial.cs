using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Administrador.PrestamoAdmin
{
    public partial class frmPrestamoHistorial : Form
    {
        private Conexion accesoConexion;
        private int idUsuarioSeleccionado;

        public frmPrestamoHistorial(int idUsuario,string nombreUsuario)
        {
            InitializeComponent();

            idUsuarioSeleccionado = idUsuario;

            txtNombreUsuario.Text = nombreUsuario;
            txtNombreUsuario.ReadOnly = true;
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            frmInicioAdmin inicioAdmin =Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                frmPrestamoAdmin prestamos = new frmPrestamoAdmin();

                inicioAdmin.AbrirFormularioEnPanelAdmin(prestamos);
            }

        }

        private void frmPrestamoHistorial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            accesoConexion = new Conexion();

            MySqlConnection conexionDB =
                accesoConexion.getConection();

            if (conexionDB != null)
            {
                string consulta = @"
                                    SELECT
                                        P.FECHA_INICIO AS FECHA_PRESTAMO,
                                        L.TITULO AS LIBRO
                                    FROM PRESTAMO P
                                    INNER JOIN EJEMPLAR E ON P.ID_EJEMPLAR = E.ID_EJEMPLAR
                                    INNER JOIN LIBRO L ON E.ID_LIBRO = L.ID_LIBRO
                                    WHERE P.ID_USUARIO = @idUsuario
                                    ORDER BY P.FECHA_INICIO DESC;";

                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta,conexionDB);

                adaptador.SelectCommand.Parameters.AddWithValue("@idUsuario", idUsuarioSeleccionado);

                DataTable tablaHistorial = new DataTable();

                adaptador.Fill(tablaHistorial);

                dgvHistorial.DataSource = tablaHistorial;

            }
        }
    }
}
