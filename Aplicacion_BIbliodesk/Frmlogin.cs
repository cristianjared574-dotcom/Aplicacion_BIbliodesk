using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Aplicacion_BIbliodesk
{
    public partial class Frmlogin : Form
    {
        
        private float tamanoBase = 9f;
        private SpeechSynthesizer lectorVoz = new SpeechSynthesizer();

        public Frmlogin()
        {
            InitializeComponent();
            EstablecerOrdenTab();
        }

        // BOTÓN INICIAR SESIÓN
        
        private void btnIniciaSsesion_Click(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un rol.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lectorVoz.SpeakAsync("Error: Debe seleccionar un rol.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese su nombre de usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lectorVoz.SpeakAsync("Error: El campo usuario está vacío.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Ingrese su contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lectorVoz.SpeakAsync("Error: El campo contraseña está vacío.");
                return;
            }

            string mensaje = $"Acceso permitido\nUsuario: {txtUsuario.Text}\nRol: {cboRol.Text}";
            MessageBox.Show(mensaje, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lectorVoz.SpeakAsync("Acceso correcto. Bienvenido al sistema Bibliodesk.");
        }

        
        private void btnAumentarTexto_Click(object sender, EventArgs e)
        {
            tamanoBase += 1f;
            CambiarTamanoFuente(this, tamanoBase);
        }

        private void btnDisminuirTexto_Click(object sender, EventArgs e)
        {
            if (tamanoBase > 6f)
            {
                tamanoBase -= 1f;
                CambiarTamanoFuente(this, tamanoBase);
            }
        }

        private void CambiarTamanoFuente(Control control, float tamano)
        {
            control.Font = new Font(control.Font.FontFamily, tamano, control.Font.Style);
            foreach (Control hijo in control.Controls)
            {
                CambiarTamanoFuente(hijo, tamano);
            }
        }

        
        private void btnLeerVoz_Click(object sender, EventArgs e)
        {
            string texto = "Bienvenido a Bibliodesk. Seleccione su rol, escriba su usuario y contraseña, luego presione el botón de iniciar sesión.";
            lectorVoz.SpeakAsync(texto);
        }

        private void Campo_AlEntrar(object sender, EventArgs e)
        {
            if (sender is Control control && !string.IsNullOrEmpty(control.Tag?.ToString()))
            {
                lectorVoz.SpeakAsync(control.Tag.ToString());
            }
        }

        private void EstablecerOrdenTab()
        {
            cboRol.TabIndex = 0;
            txtUsuario.TabIndex = 1;
            txtContrasena.TabIndex = 2;
            btnIniciaSsesion.TabIndex = 3;
            btnLeerVoz.TabIndex = 4;
            btnAumentarTexto.TabIndex = 5;
            btnDisminuirTexto.TabIndex = 6;

        }
       
        private void Frmlogin_Load(object sender, EventArgs e)
        {
           
            if (cboRol.Items.Count > 0)
                cboRol.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeerVoz_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}