using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    public partial class opcionesaccesibilidad : Form
    {
        private login formularioLogin;

        public opcionesaccesibilidad(login formPadre)
        {
            InitializeComponent();
            formularioLogin = formPadre;

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.TopMost = true;

            //  Al abrir la ventana, toma el ESTADO ACTUAL automáticamente
            AplicarEstadoActual();
        }

        // Aplica los colores según si contraste está activo o no
        private void AplicarEstadoActual()
        {
            if (formularioLogin.ContrasteActivo)
            {
                AplicarEstadoContraste(Color.Gold, Color.Black, Color.FromArgb(25, 90, 160));
            }
            else
            {
                AplicarEstadoContraste(Color.FromArgb(153, 0, 0), Color.White, Color.FromArgb(128, 0, 0));
            }
        }

        // Cambia colores de TODOS los controles de la ventana
        public void AplicarEstadoContraste(Color fondo, Color texto, Color botonColor)
        {
            this.BackColor = fondo;
            foreach (Control c in this.Controls)
            {
                c.ForeColor = texto;
                if (c is Button btn)
                {
                    btn.BackColor = botonColor;
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void opcionesaccesibilidad_Load(object sender, EventArgs e) { }

        private void cont_Click(object sender, EventArgs e)
        {
            formularioLogin.CambiarContraste();
        }

        private void Zoom1_Click(object sender, EventArgs e)
        {
            formularioLogin.AumentarTamano();
        }

        private void zoom2_Click(object sender, EventArgs e)
        {
            formularioLogin.ReducirTamano();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.Close();
        }
    }
}