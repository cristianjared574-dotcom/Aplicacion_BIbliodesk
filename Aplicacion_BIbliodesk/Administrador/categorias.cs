using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Administrador.AutorAdmin;
using Aplicacion_BIbliodesk.Bibliotecario;
using Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;


namespace Aplicacion_BIbliodesk
{
    public partial class categorias : Form
    {
        private Conexion AccessData;
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();

        public categorias()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CargarCategorias("");
        }

        private void CargarCategorias(string filtro)
        {
            try
            {
                AccessData = new Conexion();
                using (MySqlConnection conn = AccessData.getConection())
                {
                    string sql = @"SELECT ID_CATEGORIA AS 'ID Categoría',
                                          NOMBRE_CATEGORIA AS 'Categoría',
                                          DESCRIPCION AS 'Descripción',
                                          ESTADO
                                   FROM CATEGORIA";

                    if (!string.IsNullOrWhiteSpace(filtro))
                        sql += " WHERE NOMBRE_CATEGORIA LIKE @Filtro OR DESCRIPCION LIKE @Filtro";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(filtro))
                            cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");

                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dgvCategorias.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message, "Error");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarCategorias(txtBuscar.Text.Trim());
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            // 1. Primero verifica que tengas una fila seleccionada
            if (dgvCategorias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Primero selecciona una categoría de la tabla", "Aviso");
                return;
            }

            // 2. Obtiene los datos de la fila que elegiste
            int idCat = Convert.ToInt32(dgvCategorias.SelectedRows[0].Cells["ID Categoría"].Value);
            string nombreCat = dgvCategorias.SelectedRows[0].Cells["Categoría"].Value.ToString();
            string estadoCat = dgvCategorias.SelectedRows[0].Cells["ESTADO"].Value.ToString();

            // 3. Abre el formulario y le pasa los datos
            frmInicioAdmin inicioAdmin = Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            if (inicioAdmin != null)
            {
                // Enviamos los datos al crear el formulario
                cambiar_estado CambioEstadoCategoria = new cambiar_estado(idCat, nombreCat, estadoCat);
                inicioAdmin.AbrirFormularioEnPanelAdmin(CambioEstadoCategoria);
            }
            else
            {
                MessageBox.Show("No se encontró el menú principal", "Error");
            }



            // Verificar selección
            /* if (dgvCategorias.SelectedRows.Count == 0)
             {
                 MessageBox.Show("Selecciona una categoría primero", "Aviso");
                 return;
             }
             else
             {

             }

             // Buscar menú principal abierto
             Form ventanaPrincipal = null;
             foreach (Form form in Application.OpenForms)
             {
                 if (form.Name == "frmInicioAdmin")
                 {
                     ventanaPrincipal = form;
                     break;
                 }
             }

             if (ventanaPrincipal == null)
             {
                 MessageBox.Show("No se encontró el menú principal", "Error");
                 return;
             }

             // Preparar formulario
             cambiar_estado formEstado = new cambiar_estado();
             string nombreCat = dgvCategorias.SelectedRows[0].Cells["Categoría"].Value.ToString();
             string estadoCat = dgvCategorias.SelectedRows[0].Cells["ESTADO"].Value.ToString();
             formEstado.CargarDatos(nombreCat, estadoCat);

             // USAMOS EL NOMBRE EXACTO QUE ENCONTRAMOS: pnlContenido
             Panel panel = ventanaPrincipal.Controls.Find("pnlContenido", true).FirstOrDefault() as Panel;

             if (panel != null)
             {
                 panel.Controls.Clear();
                 formEstado.TopLevel = false;
                 formEstado.FormBorderStyle = FormBorderStyle.None;
                 formEstado.Dock = DockStyle.Fill;
                 panel.Controls.Add(formEstado);
                 formEstado.Show();
             }
             else
             {
                 MessageBox.Show("No se pudo acceder al panel de contenido", "Error");
             }*/

        }

        private void categorias_Load(object sender, EventArgs e) { }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}