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
using Aplicacion_BIbliodesk.Administrador.LibroAdmin;
using Aplicacion_BIbliodesk.Administrador.AutorAdmin;
using Aplicacion_BIbliodesk.Administrador.PrestamoAdmin;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmInicioAdmin : Form
    {
        private IconButton botonSeleccionado = null;
        private Form formularioActivo = null;
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();


        public frmInicioAdmin()
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

        public void AbrirFormularioEnPanelAdmin(Form formulario)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }

            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(243, 233, 210);

            pnlContenido.Controls.Add(formulario);
            formulario.Show();
        }
        
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

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCategorias); //  AGREGAMOS ESTA LÍNEA QUE FALTABA
            voz.SpeakAsync("Módulo de Categorías"); // LEE EL TEXTO DEL BOTÓN
            // 1. Busca el formulario de INICIO DE ADMINISTRADOR que YA TIENES ABIERTO
            frmInicioAdmin inicioAdmin = Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

            // 2. Verifica que exista para no dar error
            if (inicioAdmin != null)
            {
                // 3. Crea el formulario de categorías
                categorias formCategorias = new categorias();

                // 4. Lo abre DENTRO del panel del menú de administrador
                inicioAdmin.AbrirFormularioEnPanel(formCategorias);
            }
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
            voz.SpeakAsync("Cerrar sesión"); //  LEE EL TEXTO DEL BOTÓN
        }

        private void pnlContenido_Paint(object sender, PaintEventArgs e) { }
        

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        
    }
}
