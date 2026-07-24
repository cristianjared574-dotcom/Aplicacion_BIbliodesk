using Aplicacion_BIbliodesk.Administrador;
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
    public partial class cambiar_estado : Form
    {
        private Conexion AccesoDatos;

        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();

        public cambiar_estado()
        {
            InitializeComponent();
            //StartPosition = FormStartPosition.CenterScreen;

            cboEstado.Items.Add("ACTIVO");
            cboEstado.Items.Add("INACTIVO");

            // Carga las categorías en el ComboBox
            CargarCategorias();

        }

        // Recibe datos desde categorías
        

        // Guardar cambios
        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedValue == null)
            {
                MessageBox.Show(
                    "Seleccione una categoría.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Seleccione el nuevo estado.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idCategoria = Convert.ToInt32(
                cmbCategoria.SelectedValue);

            string nuevoEstado =
                cboEstado.SelectedItem.ToString();

            ActualizarEstado(
                idCategoria,
                nuevoEstado);
            
        }

        
        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            voz.SpeakAsync("Cancelando, volviendo a categorías");
            VolverACategorias();

        }
        

        // Ajuste de letra
        private void btnMasLetra_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font.FontFamily, this.Font.Size + 1);
            voz.SpeakAsync("Tamaño aumentado");
        }

        private void btnMenosLetra_Click(object sender, EventArgs e)
        {
            if (this.Font.Size > 9)
            {
                this.Font = new Font(this.Font.FontFamily, this.Font.Size - 1);
                voz.SpeakAsync("Tamaño disminuido");
            }
            else
            {
                voz.SpeakAsync("Tamaño mínimo alcanzado");
            }
        }

        private void cambiar_estado_Load(object sender, EventArgs e) { }
       




            private void CargarCategorias()
            {
                AccesoDatos = new Conexion();
                MySqlConnection conn =
                    AccesoDatos.getConection();

                if (conn == null)
                {
                    return;
                }

                try
                {
                    string consulta = @"
                    SELECT
                        ID_CATEGORIA,
                        NOMBRE_CATEGORIA
                    FROM CATEGORIA
                    ORDER BY NOMBRE_CATEGORIA;";

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(consulta, conn);

                    DataTable tablaCategorias =
                        new DataTable();

                    adaptador.Fill(tablaCategorias);

                    cmbCategoria.DataSource =
                        tablaCategorias;

                    cmbCategoria.DisplayMember =
                        "NOMBRE_CATEGORIA";

                    cmbCategoria.ValueMember =
                        "ID_CATEGORIA";

                    cmbCategoria.SelectedIndex = -1;

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al cargar categorías: " +
                        ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            private void ActualizarEstado(
                int idCategoria,
                string nuevoEstado)
            {
                AccesoDatos = new Conexion();
                MySqlConnection conn =
                    AccesoDatos.getConection();

                if (conn == null)
                {
                    return;
                }

                try
                {
                    string consulta = @"
                    UPDATE CATEGORIA
                    SET ESTADO = @nuevoEstado
                    WHERE ID_CATEGORIA = @idCategoria;";

                    MySqlCommand comando =
                        new MySqlCommand(consulta, conn);

                    comando.Parameters.AddWithValue(
                        "@nuevoEstado",
                        nuevoEstado);

                    comando.Parameters.AddWithValue(
                        "@idCategoria",
                        idCategoria);

                    int filasAfectadas =
                        comando.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show(
                            "Estado actualizado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        voz.SpeakAsync(
                            "El estado se cambió correctamente");

                        VolverACategorias();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se encontró la categoría.",
                            "Aviso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }

                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al actualizar: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            

            

            private void VolverACategorias()
            {
                frmInicioAdmin inicioAdmin =
                    Application.OpenForms["frmInicioAdmin"]
                    as frmInicioAdmin;

                if (inicioAdmin != null)
                {
                    categorias formularioCategorias =
                        new categorias();

                    inicioAdmin.AbrirFormularioEnPanelAdmin(
                        formularioCategorias);
                }
            }
        
    }
}
