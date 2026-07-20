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

namespace Aplicacion_BIbliodesk.Administrador.PrestamoAdmin
{
    public partial class frmPrestamoAdmin : Form
    {
        private Conexion accesoConexion;

        public frmPrestamoAdmin()
        {
            InitializeComponent();
        }

        private void btnHistorialPrestamo_Click(object sender, EventArgs e)
        {
            if (dgvPrestamoAdmin.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un prestamo de la tabla.", "Prestamo Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(dgvPrestamoAdmin.CurrentRow.Cells["ID_USUARIO"]);

            string nombreUsuario = dgvPrestamoAdmin.CurrentRow.Cells["USUARIO"].Value.ToString();

            //ABRIR FORMULARIO
            frmInicioAdmin inicioAdmin = Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                frmPrestamoHistorial prestamoHistorial = new frmPrestamoHistorial(idUsuario,nombreUsuario);
                inicioAdmin.AbrirFormularioEnPanelAdmin(prestamoHistorial);
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //metodo para cargar datos al datagridview
        private void CargarPrestamos()
        {

            accesoConexion = new Conexion();
            MySqlConnection conexionDB = accesoConexion.getConection();

            if (conexionDB != null)
            {
                //creamos la consulta
                string consulta = @"
                    SELECT
                        P.ID_USUARIO,
                        P.FOLIO_PRESTAMO AS FOLIO,
                        L.ISBN,
                        L.TITULO AS LIBRO,
                        CONCAT(U.NOMBRE, ' ', U.APELLIDOP, ' ', U.APELLIDOM) AS USUARIO,
                        E.CLAVE_EJEMPLAR AS EJEMPLAR,
                        P.FECHA_INICIO,
                        P.FECHA_DEVOLUCION,
                        P.ESTADO
                    FROM PRESTAMO P
                    INNER JOIN USUARIO U ON P.ID_USUARIO = U.ID_USUARIO
                    INNER JOIN EJEMPLAR E ON P.ID_EJEMPLAR = E.ID_EJEMPLAR
                    INNER JOIN LIBRO L ON E.ID_LIBRO = L.ID_LIBRO
                    ORDER BY P.ID_PRESTAMO DESC;";

                //creamos un lector
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionDB);

                //creamos un data table
                DataTable tablaPrestamos = new DataTable();
                //se vacia los datos a la tabla
                adaptador.Fill(tablaPrestamos);

                dgvPrestamoAdmin.DataSource = tablaPrestamos;

                dgvPrestamoAdmin.Columns["ID_USUARIO"].Visible = false; 
            }
        }

        private void txtBuscarPrestamo_TextChanged(object sender, EventArgs e)
        {
            accesoConexion = new Conexion();
            MySqlConnection conexionDB = accesoConexion.getConection();

            if (conexionDB != null)
            {
                TextBox txt = (TextBox)sender;

                //creamos la consulta
                string consulta = @"
                    SELECT
                        P.ID_USUARIO,
                        P.FOLIO_PRESTAMO AS FOLIO,
                        L.ISBN,
                        L.TITULO AS LIBRO,
                        CONCAT(U.NOMBRE, ' ', U.APELLIDOP, ' ', U.APELLIDOM) AS USUARIO,
                        E.CLAVE_EJEMPLAR AS EJEMPLAR,
                        P.FECHA_INICIO,
                        P.FECHA_DEVOLUCION,
                        P.ESTADO
                    FROM PRESTAMO P
                    INNER JOIN USUARIO U ON P.ID_USUARIO = U.ID_USUARIO
                    INNER JOIN EJEMPLAR E ON P.ID_EJEMPLAR = E.ID_EJEMPLAR
                    INNER JOIN LIBRO L ON E.ID_LIBRO = L.ID_LIBRO

                    WHERE P.FOLIO_PRESTAMO LIKE @buscar OR L.TITULO LIKE @buscar OR E.CLAVE_EJEMPLAR LIKE @buscar 
                            OR CONCAT(U.NOMBRE, ' ', U.APELLIDOP, ' ', U.APELLIDOM) LIKE @buscar 
                    ORDER BY P.ID_PRESTAMO DESC;";

                //creamos un lector
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionDB);

                adaptador.SelectCommand.Parameters.AddWithValue("@buscar","%" + txt.Text.Trim() + "%");

                //creamos un data table
                DataTable tablaPrestamos = new DataTable();
                //se vacia los datos a la tabla
                adaptador.Fill(tablaPrestamos);

                dgvPrestamoAdmin.DataSource = tablaPrestamos;

                dgvPrestamoAdmin.Columns["ID_USUARIO"].Visible = false;
            }
        }

        private void frmPrestamoAdmin_Load(object sender, EventArgs e)
        {
            CargarPrestamos();
        }
    }
}
