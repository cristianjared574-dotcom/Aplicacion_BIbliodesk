using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    public partial class sonido : Form
    {
        private Form formPadre;

        public sonido(Form origen)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            BackColor = Color.FromArgb(255, 228, 196);

            formPadre = origen;
        }

        private void btnaudio1_Click(object sender, EventArgs e)
        {
            // Guardamos posición antes de abrir
            Point posMenu = this.PointToScreen(Point.Empty);

            //  el botón Audio se queda visible
            // this.Close(); ELIMINADO

            // opciones al lado izquierdo
            audio ventanaOpciones = new audio(formPadre);
            ventanaOpciones.ShowInTaskbar = false;
            ventanaOpciones.TopMost = true;

            ventanaOpciones.StartPosition = FormStartPosition.Manual;
            ventanaOpciones.Location = new Point(posMenu.X - ventanaOpciones.Width, posMenu.Y);

            // Solo al elegir opción se cierran las dos juntas
            ventanaOpciones.FormClosed += (s, args) => this.Close();

            ventanaOpciones.Show();
            ventanaOpciones.BringToFront();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        // protected override void OnDeactivate(EventArgs e)
        // {
        //     base.OnDeactivate(e);
        //     this.Close();
        // }
    }
}