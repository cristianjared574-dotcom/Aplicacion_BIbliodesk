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

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class frmInicioBiblio : Form
    {
        private IconButton botonSeleccionado = null;
        private Form formularioActivo = null;

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
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnAutores);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCategorias);
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnEjemplares);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnPrestamos);
            AbrirFormularioEnPanel( new frmPrestamoBiblio());
        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            seleccionarModulo(btnCerrarsesion);
        }
    }
}
