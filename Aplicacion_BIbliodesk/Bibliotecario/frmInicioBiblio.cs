using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario.Prestamo;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_BIbliodesk.Bibliotecario.Prestamo;
using Aplicacion_BIbliodesk.Bibliotecario.LibroBibliotecario;
using Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmInicioBiblio : Form
    {
        private IconButton botonSeleccionado = null;
        private Form formularioActivo = null;

        // CREAMOS EL MOTOR DE VOZ
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();


        public frmInicioBiblio()
        {
            InitializeComponent();
        }
        private void seleccionarModulo(IconButton boton)
        {
            if (botonSeleccionado != null)
            {
                botonSeleccionado.BackColor = Color.FromArgb(62, 42, 32);
            }
            botonSeleccionado = boton;
            boton.BackColor = Color.FromArgb(123, 30, 30);
        }

        public void AbrirFormularioEnPanel(Form formulario)
        {
            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;

            //  LLENA TODO EL PANEL para que se vea completo y bien alineado
            formulario.Dock = DockStyle.Fill;
           

            pnlContenido.Controls.Clear();
            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }

        //  Botón que abre categorías DENTRO del panel principal
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            voz.SpeakAsync("Módulo de Categorías"); //LEE EL TEXTO DEL BOTÓN
            seleccionarModulo(btnCategorias);
            //  Abre categorias_biblo SIN ventana externa, dentro del panel
            AbrirFormularioEnPanel(new categorias_biblo());
        }
        private void btnLibros_Click(object sender, EventArgs e)
        {
            //isksjjs
            seleccionarModulo(btnLibros);
            AbrirFormularioEnPanel(new frmLibrosBuscar());
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnAutores);
            AbrirFormularioEnPanel(new frmAutorInicio());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCategorias);

        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnEjemplares);
            AbrirFormularioEnPanel(new frmInicioEjemplaresBiblio());
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnPrestamos);
            voz.SpeakAsync("Módulo de Préstamos"); // LEE EL TEXTO DEL BOTÓN
            AbrirFormularioEnPanel(new frmPrestamoBiblio());
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCerrarsesion);
            voz.SpeakAsync("Cerrar sesión"); // LEE EL TEXTO DEL BOTÓN
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
