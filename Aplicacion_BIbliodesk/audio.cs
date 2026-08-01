using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario;
using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    public partial class audio : Form
    {
        private frmInicioBiblio formBiblio = null;
        private frmInicioAdmin formAdmin = null;
        private SpeechSynthesizer voz;

        public audio(Form formPadre)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ShowInTaskbar = false;
            TopMost = true;
            BackColor = Color.FromArgb(255, 228, 196);

            if (formPadre is frmInicioBiblio biblio)
            {
                formBiblio = biblio;
                voz = biblio.voz;
            }
            else if (formPadre is frmInicioAdmin admin)
            {
                formAdmin = admin;
                voz = admin.voz;
            }
        }

        private void Activado_Click(object sender, EventArgs e)
        {
            if (formBiblio != null) formBiblio.audioActivo = true;
            if (formAdmin != null) formAdmin.audioActivo = true;

            voz.SpeakAsyncCancelAll();
            voz.SpeakAsync("Lectura activada. Pase el ratón sobre los elementos.");
            this.Close();
        }

        private void Desactivado_Click(object sender, EventArgs e)
        {
            if (formBiblio != null) formBiblio.audioActivo = false;
            if (formAdmin != null) formAdmin.audioActivo = false;

            voz.SpeakAsyncCancelAll();
            this.Close();
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            this.Close();
        }
    }
}