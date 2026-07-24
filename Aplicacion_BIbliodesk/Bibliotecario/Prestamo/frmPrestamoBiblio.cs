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

namespace Aplicacion_BIbliodesk.Bibliotecario.Prestamo
{
    public partial class frmPrestamoBiblio : Form
    {
        private Conexion accesoConexion;

        public frmPrestamoBiblio()
        {
            InitializeComponent();
            CargarPrestamos();
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmRegistrarPrestamo nuevoPrestamo = new frmRegistrarPrestamo();
                inicioBiblio.AbrirFormularioEnPanel(nuevoPrestamo);
            }
            /*frmInicioBiblio menuPrincipalBibliotecario = new frmInicioBiblio();

            //frmRegistrarPrestamo PantallaRegistar = new frmRegistrarPrestamo();
            menuPrincipalBibliotecario.AbrirFormularioEnPanel(new frmRegistrarPrestamo());*/
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
        P.ID_PRESTAMO AS 'ID Préstamo',
        P.ID_USUARIO AS 'ID Usuario',
        P.ID_EJEMPLAR AS 'ID Ejemplar',
        L.ISBN,
        L.TITULO AS LIBRO,
        CONCAT(
            U.NOMBRE, ' ',
            U.APELLIDOP, ' ',
            U.APELLIDOM
        ) AS USUARIO,
        P.FECHA_INICIO AS 'Fecha inicio',
        P.FECHA_DEVOLUCION AS 'Fecha devolución',
        P.ESTADO
    FROM PRESTAMO P
    INNER JOIN USUARIO U
        ON P.ID_USUARIO = U.ID_USUARIO
    INNER JOIN EJEMPLAR E
        ON P.ID_EJEMPLAR = E.ID_EJEMPLAR
    INNER JOIN LIBRO L
        ON E.ID_LIBRO = L.ID_LIBRO
    ORDER BY P.ID_PRESTAMO DESC;";

                //creamos un lector
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionDB);

                //creamos un data table
                DataTable tablaPrestamos = new DataTable();
                //se vacia los datos a la tabla
                adaptador.Fill(tablaPrestamos);

                dgvPrestamos.DataSource = tablaPrestamos;
            }
        }

        private void txtBuscarPrestamoBiblio_TextChanged(object sender, EventArgs e)
        {
            accesoConexion = new Conexion();
            MySqlConnection conexionDB = accesoConexion.getConection();

            if (conexionDB != null)
            {
                TextBox txt = (TextBox)sender;

                //creamos la consulta
                string consulta = @"
    SELECT
        P.ID_PRESTAMO AS 'ID Préstamo',
        P.ID_USUARIO AS 'ID Usuario',
        P.ID_EJEMPLAR AS 'ID Ejemplar',
        L.ISBN,
        L.TITULO AS LIBRO,
        CONCAT(
            U.NOMBRE, ' ',
            U.APELLIDOP, ' ',
            U.APELLIDOM
        ) AS USUARIO,
        P.FECHA_INICIO AS 'Fecha inicio',
        P.FECHA_DEVOLUCION AS 'Fecha devolución',
        P.ESTADO
    FROM PRESTAMO P
    INNER JOIN USUARIO U
        ON P.ID_USUARIO = U.ID_USUARIO
    INNER JOIN EJEMPLAR E
        ON P.ID_EJEMPLAR = E.ID_EJEMPLAR
    INNER JOIN LIBRO L
        ON E.ID_LIBRO = L.ID_LIBRO
    WHERE CAST(P.ID_PRESTAMO AS CHAR) LIKE @buscar
       OR CAST(P.ID_USUARIO AS CHAR) LIKE @buscar
       OR CAST(P.ID_EJEMPLAR AS CHAR) LIKE @buscar
       OR L.ISBN LIKE @buscar
       OR L.TITULO LIKE @buscar
       OR CONCAT(
            U.NOMBRE, ' ',
            U.APELLIDOP, ' ',
            U.APELLIDOM
          ) LIKE @buscar
    ORDER BY P.ID_PRESTAMO DESC;";

                //creamos un lector
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionDB);

                adaptador.SelectCommand.Parameters.AddWithValue("@buscar", "%" + txt.Text.Trim() + "%");

                //creamos un data table
                DataTable tablaPrestamos = new DataTable();
                //se vacia los datos a la tabla
                adaptador.Fill(tablaPrestamos);

                dgvPrestamos.DataSource = tablaPrestamos;
            }
        }
    }
}
