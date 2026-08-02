using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario;
using Aplicacion_BIbliodesk.Bibliotecario.LibroBibliotecario;
using Aplicacion_BIbliodesk.Bibliotecario.Prestamo;
using FontAwesome.Sharp;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmInicioBiblio : Form
    {
        private IconButton botonSeleccionado = null;
        private Form formularioActivo = null;

        public readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        public bool audioActivo = false;
        private string ultimoTextoLeido = "";
        private audio ventanaAudio; 

        public frmInicioBiblio()
        {
            InitializeComponent();
            AsignarEventoPaseRaton(this);
        }

        private void seleccionarModulo(IconButton boton)
        {
            if (botonSeleccionado != null)
                botonSeleccionado.BackColor = Color.FromArgb(62, 42, 32);
            botonSeleccionado = boton;
            boton.BackColor = Color.FromArgb(123, 30, 30);
        }

        private void AsignarEventoPaseRaton(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                c.MouseEnter += Control_AlPasarRaton;
                if (c.HasChildren) AsignarEventoPaseRaton(c);
            }
        }

        private void Control_AlPasarRaton(object sender, EventArgs e)
        {
            if (!audioActivo) return;

            Control ctrl = sender as Control;
            if (ctrl == null) return;

            string texto = ObtenerContenidoReal(ctrl);
            if (string.IsNullOrWhiteSpace(texto)) return;

            // CORTE INSTANTÁNEO AL CAMBIAR DE ELEMENTO
            voz.SpeakAsyncCancelAll();

            // NO REPITE EL MISMO TEXTO
            if (texto != ultimoTextoLeido)
            {
                voz.SpeakAsync(texto);
                ultimoTextoLeido = texto;
            }
        }

        private string ObtenerContenidoReal(Control ctrl)
        {
            if (!string.IsNullOrWhiteSpace(ctrl.Text))
                return ctrl.Text.Trim();

            if (ctrl is TextBox txt && !string.IsNullOrWhiteSpace(txt.Text))
                return txt.Text.Trim();

            if (ctrl is ComboBox cmb && !string.IsNullOrWhiteSpace(cmb.Text))
                return cmb.Text.Trim();

            if (ctrl is DataGridView dgv)
            {
                string tabla = "";
                foreach (DataGridViewColumn col in dgv.Columns)
                    if (!string.IsNullOrWhiteSpace(col.HeaderText))
                        tabla += col.HeaderText.Trim() + ". ";

                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow) continue;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        if (celda.Value != null && !string.IsNullOrWhiteSpace(celda.Value.ToString()))
                            tabla += celda.Value.ToString().Trim() + ", ";
                    }
                    tabla += "siguiente fila. ";
                }
                return tabla.Trim();
            }

            return string.Empty;
        }

        public void AbrirFormularioEnPanel(Form formulario)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(243, 233, 210);

            // APLICA LA LECTURA AL NUEVO FORMULARIO
            AsignarEventoPaseRaton(formulario);

            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        //  BOTON DE AUDIO 
        private void audio_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<sonido>().Any()) return;

            sonido menuSonido = new sonido(this);
            menuSonido.ShowInTaskbar = false;
            menuSonido.TopMost = true;

            Point posBoton = audio.PointToScreen(Point.Empty);
            menuSonido.StartPosition = FormStartPosition.Manual;
            menuSonido.Location = new Point(
                posBoton.X - menuSonido.Width + audio.Width,
                posBoton.Y + audio.Height + 5
            );

            menuSonido.Show(this);
        }

        // EL RESTO DE TUS BOTONES
        private void btnLibros_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnLibros);
            AbrirFormularioEnPanel(new frmLibrosBuscar());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnAutores);
            AbrirFormularioEnPanel(new frmAutorInicio());
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnEjemplares);
            AbrirFormularioEnPanel(new frmInicioEjemplaresBiblio());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnPrestamos);
            AbrirFormularioEnPanel(new frmPrestamoBiblio());
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCerrarsesion);
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                login loginForm = new login();
                loginForm.Show();

                frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;
                if (inicioBiblio != null)
                {
                    inicioBiblio.Close();
                }
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCategoria);
            AbrirFormularioEnPanel(new categorias_biblo());
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e) { }
    }
}