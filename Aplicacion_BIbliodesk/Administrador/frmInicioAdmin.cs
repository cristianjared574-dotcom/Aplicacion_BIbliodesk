using FontAwesome.Sharp;
using System;
using System.Data;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Aplicacion_BIbliodesk.Administrador.LibroAdmin;
using Aplicacion_BIbliodesk.Administrador.AutorAdmin;
using Aplicacion_BIbliodesk.Administrador.PrestamoAdmin;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmInicioAdmin : Form
    {
        
        private IconButton botonSeleccionado = null;
        private Form formularioActivo = null;

        // SISTEMA DE ACCESIBILIDAD IGUAL AL BIBLIOTECARIO
        public readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        public bool audioActivo = false;
        private string ultimoTextoLeido = "";
        private audio ventanaAudio;

        public frmInicioAdmin()
        {
            InitializeComponent();
            AsignarEventoPaseRaton(this); // ACTIVA LECTURA AL INICIAR
        }

        private void seleccionarModulo(IconButton boton)
        {
            if (botonSeleccionado != null)
                botonSeleccionado.BackColor = Color.FromArgb(62, 42, 32);

            botonSeleccionado = boton;
            boton.BackColor = Color.FromArgb(123, 30, 30);
        }

        public void AbrirFormularioEnPanelAdmin(Form formulario)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(243, 233, 210);

            // ASIGNA LECTURA A LO QUE SE ABRA
            AsignarEventoPaseRaton(formulario);

            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        // ASIGNA EVENTO DE LECTURA A TODOS LOS CONTROLES
        private void AsignarEventoPaseRaton(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                c.MouseEnter += Control_AlPasarRaton;
                if (c.HasChildren) AsignarEventoPaseRaton(c);
            }
        }

        // LEE AL PASAR EL RATÓN, CORTE Y SIN REPETIR
        private void Control_AlPasarRaton(object sender, EventArgs e)
        {
            if (!audioActivo) return;

            Control ctrl = sender as Control;
            if (ctrl == null) return;

            string texto = ObtenerContenidoReal(ctrl);
            if (string.IsNullOrWhiteSpace(texto)) return;

            // CORTE INSTANTÁNEO DEL AUDIO ANTERIOR
            voz.SpeakAsyncCancelAll();

            // NO REPITE EL MISMO TEXTO
            if (texto != ultimoTextoLeido)
            {
                voz.SpeakAsync(texto);
                ultimoTextoLeido = texto;
            }
        }

        // OBTIENE SOLO EL CONTENIDO VISIBLE
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

        // BOTÓN DE AUDIO (MISMA VENTANA QUE ANTES)
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (ventanaAudio == null || ventanaAudio.IsDisposed)
            {
                ventanaAudio = new audio(this);
                ventanaAudio.ShowInTaskbar = false;
                ventanaAudio.TopMost = true;

                Point posBoton = iconButton1.PointToScreen(Point.Empty);
                ventanaAudio.StartPosition = FormStartPosition.Manual;
                ventanaAudio.Location = new Point(
                    posBoton.X - ventanaAudio.Width + iconButton1.Width,
                    posBoton.Y + iconButton1.Height + 5
                );

                ventanaAudio.FormClosed += (s, args) => ventanaAudio = null;
                ventanaAudio.Show(this);
            }
            else
            {
                ventanaAudio.Close();
                ventanaAudio = null;
            }
        }

        // BOTONES ORIGINALES SIN CAMBIOS
        private void btnLibros_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnLibros);
            AbrirFormularioEnPanelAdmin(new frmLibrosBuscar());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnAutores);
            AbrirFormularioEnPanelAdmin(new frmAutorInicio());
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnEjemplares);
            AbrirFormularioEnPanelAdmin(new frmInicioEjemplaresAdmin());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnPrestamos);
            AbrirFormularioEnPanelAdmin(new frmPrestamoAdmin());
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnReporte);
            AbrirFormularioEnPanelAdmin(new frmInicioReportesAdmin());
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCerrarsesion);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCategorias);
            AbrirFormularioEnPanelAdmin(new categorias());
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pnlContenido_Paint_1(object sender, PaintEventArgs e) { }
    }
}