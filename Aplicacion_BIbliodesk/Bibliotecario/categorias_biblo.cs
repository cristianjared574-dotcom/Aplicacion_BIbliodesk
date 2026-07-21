using Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class categorias_biblo : Form
    {
        private Conexion AccesoConnection;
        public categorias_biblo()
        {
            InitializeComponent();

            // AJUSTES DE TU TABLA IGUALES
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            dgvCategorias.Margin = new Padding(0);
            StartPosition = FormStartPosition.CenterScreen;

            //  QUITA LA LÍNEA VACÍA DEL FINAL
            dgvCategorias.AllowUserToAddRows = false;

            //  CONEXIÓN SEGURA DEL BUSCADOR
            txtBuscar.TextChanged -= txtBuscar_TextChanged;
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            //  CARGA INICIAL
            CargarCategorias("");
        }

        //  FILTRO QUE MUESTRA SOLO LO QUE BUSCAS
        private void CargarCategorias(string filtro)
        {
            try
            {
                AccesoConnection = new Conexion();
                using (MySqlConnection conn = AccesoConnection.getConection())
                {
                    string sql = @"SELECT 
                                        ID_CATEGORIA AS 'ID Categoría',
                                        NOMBRE_CATEGORIA AS 'Categoría',
                                        DESCRIPCION AS 'Descripción',
                                        ESTADO
                                   FROM CATEGORIA";

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        sql += " WHERE NOMBRE_CATEGORIA LIKE @Filtro OR DESCRIPCION LIKE @Filtro";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                        {
                            cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                        }

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvCategorias.DataSource = dt;

                            if (dgvCategorias.Columns.Count > 0)
                            {
                                dgvCategorias.Columns["ID Categoría"].Width = 100;
                                dgvCategorias.Columns["Categoría"].Width = 180;
                                dgvCategorias.Columns["Descripción"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dgvCategorias.Columns["ESTADO"].Width = 110;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias(txtBuscar.Text.Trim());
        }

     
        private void categorias_biblo_Load(object sender, EventArgs e) { }
        // EVENTO DEL BOTÓN AGREGAR CATEGORÍA


   
       





        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void btnAgregarCategoria_Click_1(object sender, EventArgs e)
        {
            // Busca el formulario principal (frmInicioBiblio)
            frmInicioBiblio formularioInicio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (formularioInicio != null)
            {
                //Crea una instancia NUEVA y VACÍA del formulario de agregar
                categoria_biblio formAgregar = new categoria_biblio();

                // Carga el formulario DENTRO DEL PANEL, SIN VENTANA EXTERNA
                formularioInicio.AbrirFormularioEnPanel(formAgregar);
            }
        }

        private void btnEditarCategoria_Click_1(object sender, EventArgs e)
        {
            // 1. OBLIGA A SELECCIONAR UNA FILA PRIMERO
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Primero selecciona UNA categoría de la tabla (haz clic sobre la fila entera)",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. TOMA LOS DATOS DE LA FILA QUE SELECCIONASTE
                DataGridViewRow filaSeleccionada = dgvCategorias.SelectedRows[0];
                int idCategoria = Convert.ToInt32(filaSeleccionada.Cells["ID Categoría"].Value);
                string nombreActual = filaSeleccionada.Cells["Categoría"].Value.ToString();
                string descripcionActual = filaSeleccionada.Cells["Descripción"].Value?.ToString() ?? "";

                // 3. ABRE LA MISMA PANTALLA PERO CON LOS DATOS CARGADOS
                frmInicioBiblio pantallaInicio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;
                if (pantallaInicio != null)
                {
                    // Usa el constructor que recibe datos para editar
                    categoria_biblio formularioEditar = new categoria_biblio(idCategoria, nombreActual, descripcionActual);
                    pantallaInicio.AbrirFormularioEnPanel(formularioEditar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar edición: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}