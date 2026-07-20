using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    public partial class cambiar_estado : Form
    {
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();

        public cambiar_estado()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            // Colores y contraste
            this.BackColor = Color.FromArgb(255, 224, 192);
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            txtCategoria.BackColor = Color.White;
            txtCategoria.ForeColor = Color.Black;
            cboEstado.BackColor = Color.White;
            cboEstado.ForeColor = Color.Black;

            // Opciones de estado
            cboEstado.Items.AddRange(new string[] { "ACTIVO", "INACTIVO" });
        }

        // Recibe datos desde categorías
        public void CargarDatos(string nombre, string estado)
        {
            txtCategoria.Text = nombre;
            cboEstado.Text = estado;
            txtCategoria.ReadOnly = true;
        }

        // Guardar cambios
        private void BtnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona el nuevo estado", "Aviso");
                voz.SpeakAsync("Elige el estado que quieres asignar");
                return;
            }

            try
            {
                using (MySqlConnection conn = Conexion.getConection())
                {
                    string sql = "UPDATE CATEGORIA SET ESTADO = @NuevoEstado WHERE NOMBRE_CATEGORIA = @NombreCat";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@NuevoEstado", cboEstado.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@NombreCat", txtCategoria.Text);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Estado actualizado correctamente", "Éxito");
                voz.SpeakAsync("El estado se cambió exitosamente");

                // VOLVER A CATEGORÍAS DENTRO DEL PANEL
                VolverACategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error");
                voz.SpeakAsync("No se pudo guardar el cambio");
            }
        }

        // Cancelar y volver
        private void btnCancelarCambios_Click(object sender, EventArgs e)
        {
            voz.SpeakAsync("Cancelando, volviendo a categorías");

            // VOLVER A CATEGORÍAS SIN GUARDAR
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
        private void VolverACategorias()
        {
            // Busca el menú principal
            Form ventanaPrincipal = null;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "frmInicioAdmin")
                {
                    ventanaPrincipal = form;
                    break;
                }
            }

            if (ventanaPrincipal != null)
            {
                // Busca el mismo panel donde cargaste el formulario
                Panel panel = ventanaPrincipal.Controls.Find("pnlContenido", true).FirstOrDefault() as Panel;
                if (panel != null)
                {
                    panel.Controls.Clear();
                    categorias formCategorias = new categorias();
                    formCategorias.TopLevel = false;
                    formCategorias.FormBorderStyle = FormBorderStyle.None;
                    formCategorias.Dock = DockStyle.Fill;
                    panel.Controls.Add(formCategorias);
                    formCategorias.Show();
                }
            }
        }
    }
}