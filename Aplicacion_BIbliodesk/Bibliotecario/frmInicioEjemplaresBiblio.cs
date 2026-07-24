using Aplicacion_BIbliodesk.Bibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    
    public partial class frmInicioEjemplaresBiblio : Form
    {

        private Conexion ConexionData;
        public frmInicioEjemplaresBiblio()
        {
            InitializeComponent();
        }

        // Se ejecuta cuando se abre la pantalla de inicio de ejemplares
        private void frmInicioEjemplaresBiblio_Load(object sender, EventArgs e)
        {
            CargarEjemplares(); // Solo cargamos los datos de la base de datos al abrir
        }

        //metodo para cargar los ejemplares en el DataGridView
        private void CargarEjemplares(string filtro = "")
        {
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con != null)
            {
                string consulta = @"
                    SELECT
                        
                        E.ID_EJEMPLAR,
                        L.ID_LIBRO,
                        E.LOCALIZACION AS `Localización`,
                        E.ESTADO_FISICO AS `Estado`,
                        E.DISPONIBLE AS `Disponible`
                    FROM EJEMPLAR E
                    INNER JOIN LIBRO L ON E.ID_LIBRO = L.ID_LIBRO
                    ORDER BY E.ID_EJEMPLAR DESC;";

                MySqlDataAdapter adaptador =
                    new MySqlDataAdapter(consulta, con);

                DataTable tablaEjemplares =
                    new DataTable();

                adaptador.Fill(tablaEjemplares);

                dgvEjemplares.DataSource = tablaEjemplares;

                // Ocultar el ID interno real
                //dgvEjemplares.Columns["ID_EJEMPLAR"].Visible = false;

            }

        }

        //text changed para que al momento de que se ingrese el texto en la busqueda esta ya este buscando
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //CargarEjemplares(txtBuscarEjemplar.Text.Trim());
        }
        
        //evento al dar clic en el boton agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Usar el constructor vacío del formulario único para poder agregar
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmEjemplarBiblio frmAgregarBiblio= new frmEjemplarBiblio();
                inicioBiblio.AbrirFormularioEnPanel(frmAgregarBiblio);
            }

        }

        
        //Evento al dar clic en el boton editar ejemplar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEjemplares.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un ejemplar.");
                return;
            }


            int idEjemplar = Convert.ToInt32(
        dgvEjemplares.CurrentRow.Cells["ID_EJEMPLAR"].Value);

            int idLibro = Convert.ToInt32(
                dgvEjemplares.CurrentRow.Cells["ID_LIBRO"].Value);

            string localizacion =
                dgvEjemplares.CurrentRow.Cells["Localización"].Value.ToString();

            string estadoFisico =
                dgvEjemplares.CurrentRow.Cells["Estado"].Value.ToString();

            string disponible =
                dgvEjemplares.CurrentRow.Cells["Disponible"].Value.ToString();

            frmInicioBiblio inicioBiblio =
                Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                frmEjemplarBiblio frmEditar =
                    new frmEjemplarBiblio(
                        idEjemplar,
                        idLibro,
                        localizacion, estadoFisico, disponible);

                inicioBiblio.AbrirFormularioEnPanel(frmEditar);
            }
        }

        private void txtBuscarEjemplar_TextChanged(object sender, EventArgs e)
        {
            ConexionData = new Conexion();
            MySqlConnection con = ConexionData.getConection();

            if (con != null)
            {
                TextBox txt = (TextBox)sender;

                string consulta = @"
                    SELECT
                        
                        E.ID_EJEMPLAR AS `ID Ejemplar`,
                        L.ID_LIBRO AS `ID Libro`,
                        E.LOCALIZACION AS `Localización`,
                        E.ESTADO_FISICO AS `Estado`,
                        E.DISPONIBLE AS `Disponible`
                    FROM EJEMPLAR E
                    INNER JOIN LIBRO L
                        ON E.ID_LIBRO = L.ID_LIBRO
                    WHERE E.ID_EJEMPLAR LIKE @busqueda
                       OR L.ID_LIBRO LIKE @busqueda
                       OR E.LOCALIZACION LIKE @busqueda
                       OR E.ESTADO_FISICO LIKE @busqueda
                       OR E.DISPONIBLE LIKE @busqueda
                    ORDER BY E.ID_EJEMPLAR DESC;";

                MySqlDataAdapter adaptador =
                    new MySqlDataAdapter(consulta, con);

                adaptador.SelectCommand.Parameters.AddWithValue("@busqueda","%" + txt.Text.Trim() + "%");

                DataTable tablaEjemplares = new DataTable();

                adaptador.Fill(tablaEjemplares);

                dgvEjemplares.DataSource = tablaEjemplares;

                //dgvEjemplares.Columns["ID_EJEMPLAR"].Visible = false;
            }
        }
    }
}