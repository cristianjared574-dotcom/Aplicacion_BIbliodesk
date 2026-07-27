using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;

namespace Aplicacion_BIbliodesk
{
    public partial class login : Form
    {
        private Conexion AcessConnection;
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        public static Empleado EmpleadoActual { get; private set; }

        // Variables para accesibilidad
        private Color colorFondoOriginal;
        private Color colorTextoOriginal;
        private Color colorBotonOriginal;
        private Color colorTextoTituloOriginal;
        private Color colorTextoNormalOriginal;
        private Color colorPanelOriginal;

        //  Colores para la ventana de accesibilidad
        private readonly Color fondoVentanaNormal = Color.FromArgb(153, 0, 0);   // Rojo inicial
        private readonly Color textoVentanaNormal = Color.White;                 // Texto blanco
        private readonly Color botonVentanaNormal = Color.FromArgb(128, 0, 0);   // Botones rojos

        private readonly Color fondoVentanaContraste = Color.Gold;               // Amarillo
        private readonly Color textoVentanaContraste = Color.Black;              // Texto negro
        private readonly Color botonVentanaContraste = Color.FromArgb(25, 90, 160); // Botones azules

        private float escalaActual = 1.0f;
        private const float pasoEscala = 0.1f;
        private Size tamanoFormularioOriginal;
        private readonly Point posicionFijaAbsoluta;
        private Dictionary<Control, (Point Posicion, Size Tamano, Font Fuente)> controlesOriginales = new Dictionary<Control, (Point, Size, Font)>();
        private opcionesaccesibilidad ventanaAcces;

        //  ESTADO PÚBLICO para saber si contraste está activo
        public bool ContrasteActivo { get; private set; } = false;


        public login()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            StartPosition = FormStartPosition.Manual;
            this.Location = new Point(543, 166);
            posicionFijaAbsoluta = this.Location;
            tamanoFormularioOriginal = this.Size;

            cboRol.Items.AddRange(new string[] { "ADMINISTRADOR", "BIBLIOTECARIO" });
            txtContrasena.PasswordChar = '*';

            //ESTADO INICIAL (SIN CONTRASTE)
            this.BackColor = Color.FromArgb(128, 32, 32);
            lblTitulo.ForeColor = Color.FromArgb(153, 0, 0);
            lblSubtitulo.ForeColor = Color.Black;
            lblUsuario.ForeColor = Color.Black;
            lblContrasena.ForeColor = Color.Black;
            lblRol.ForeColor = Color.Black;
            btnIniciarSesion.BackColor = Color.FromArgb(128, 0, 0);
            btnIniciarSesion.ForeColor = Color.White;

            panelFondo.BackColor = Color.FromArgb(255, 228, 196);
            iconBtnacces.IconColor = Color.White; //Icono blanco al inicio

            // Guardamos valores originales
            colorFondoOriginal = this.BackColor;
            colorTextoOriginal = lblTitulo.ForeColor;
            colorBotonOriginal = btnIniciarSesion.BackColor;
            colorTextoTituloOriginal = lblTitulo.ForeColor;
            colorTextoNormalOriginal = lblSubtitulo.ForeColor;
            colorPanelOriginal = panelFondo.BackColor;

            GuardarEstadoOriginal(this);

            this.SizeChanged += (s, e) => { this.Location = posicionFijaAbsoluta; };
            this.LocationChanged += ActualizarPosicionVentana;
            iconBtnacces.LocationChanged += ActualizarPosicionVentana;
        }

        private void ActualizarPosicionVentana(object sender, EventArgs e)
        {
            if (ventanaAcces != null && !ventanaAcces.IsDisposed)
            {
                Point posIcono = iconBtnacces.PointToScreen(Point.Empty);
                ventanaAcces.Location = new Point(
                    posIcono.X - ventanaAcces.Width + iconBtnacces.Width,
                    posIcono.Y + iconBtnacces.Height + 5
                );
            }
        }

        private void GuardarEstadoOriginal(Control contenedor)
        {
            foreach (Control c in contenedor.Controls)
            {
                controlesOriginales[c] = (c.Location, c.Size, c.Font);
                if (c.HasChildren) GuardarEstadoOriginal(c);
            }
        }

        // FUNCIÓN DE CONTRASTE 
        public void CambiarContraste()
        {
            ContrasteActivo = !ContrasteActivo;

            if (ContrasteActivo)
            {
                // MODO CONTRASTE ACTIVO
                this.BackColor = Color.FromArgb(255, 248, 230);
                lblTitulo.ForeColor = Color.FromArgb(20, 20, 20);
                lblSubtitulo.ForeColor = Color.FromArgb(40, 40, 40);
                lblUsuario.ForeColor = Color.Black;
                lblContrasena.ForeColor = Color.Black;
                lblRol.ForeColor = Color.Black;
                btnIniciarSesion.BackColor = Color.FromArgb(25, 90, 160);
                btnIniciarSesion.ForeColor = Color.White;
                panelFondo.BackColor = Color.White;

                iconBtnacces.IconColor = Color.Black; //  Icono negro con contraste

                // Actualizar ventana si está abierta
                if (ventanaAcces != null && !ventanaAcces.IsDisposed)
                {
                    ventanaAcces.AplicarEstadoContraste(fondoVentanaContraste, textoVentanaContraste, botonVentanaContraste);
                }
            }
            else
            {
                //  VOLVER A MODO NORMAL
                this.BackColor = colorFondoOriginal;
                lblTitulo.ForeColor = colorTextoTituloOriginal;
                lblSubtitulo.ForeColor = colorTextoNormalOriginal;
                lblUsuario.ForeColor = colorTextoNormalOriginal;
                lblContrasena.ForeColor = colorTextoNormalOriginal;
                lblRol.ForeColor = colorTextoNormalOriginal;
                btnIniciarSesion.BackColor = colorBotonOriginal;
                btnIniciarSesion.ForeColor = Color.White;
                panelFondo.BackColor = colorPanelOriginal;

                iconBtnacces.IconColor = Color.White; // Volver a icono blanco

                // Actualizar ventana si está abierta
                if (ventanaAcces != null && !ventanaAcces.IsDisposed)
                {
                    ventanaAcces.AplicarEstadoContraste(fondoVentanaNormal, textoVentanaNormal, botonVentanaNormal);
                }
            }
        }


        public void AumentarTamano()
        {
            if (escalaActual < 1.8f)
            {
                escalaActual += pasoEscala;
                AplicarEscalaGeneral();
            }
        }

        public void ReducirTamano()
        {
            if (escalaActual > 0.7f)
            {
                escalaActual -= pasoEscala;
                AplicarEscalaGeneral();
            }
        }

        private void AplicarEscalaGeneral()
        {
            this.Location = posicionFijaAbsoluta;
            this.Size = new Size(
                (int)(tamanoFormularioOriginal.Width * escalaActual),
                (int)(tamanoFormularioOriginal.Height * escalaActual)
            );

            foreach (var item in controlesOriginales)
            {
                Control c = item.Key;
                var (pos, tam, fuente) = item.Value;
                c.Location = new Point((int)(pos.X * escalaActual), (int)(pos.Y * escalaActual));
                c.Size = new Size((int)(tam.Width * escalaActual), (int)(tam.Height * escalaActual));
                c.Font = new Font(fuente.FontFamily, fuente.Size * escalaActual, fuente.Style);
            }

            ActualizarPosicionVentana(null, null);
        }

        public string CifrarContrasena(string textoPlano)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void login_Load(object sender, EventArgs e) { }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Completa todos los campos", "Aviso");
                voz.SpeakAsync("Llena todos los campos por favor");
                return;
            }

            EmpleadoActual = ValidarCredenciales(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Rol == cboRol.SelectedItem.ToString())
                {
                    MessageBox.Show($"Bienvenido al sistema {EmpleadoActual.NombreCompleto}", "Bibliodesk");
                    voz.SpeakAsync($"Bienvenido al sistema {EmpleadoActual.NombreCompleto}");

                    if (EmpleadoActual.Rol == "ADMINISTRADOR") { new frmInicioAdmin().Show(); }
                    else if (EmpleadoActual.Rol == "BIBLIOTECARIO") { new frmInicioBiblio().Show(); }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El rol seleccionado no coincide con tu cuenta", "Error");
                    voz.SpeakAsync("El rol no coincide con tu cuenta");
                    txtContrasena.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario, contraseña incorrectos o cuenta inactiva", "Error");
                voz.SpeakAsync("Usuario, contraseña incorrectos o cuenta inactiva");
                txtContrasena.Clear();
            }
        }

        private Empleado ValidarCredenciales(string usuario, string contrasena)
        {
            Empleado empleado = null;
            string hash = CifrarContrasena(contrasena);
            try
            {
                AcessConnection = new Conexion();
                MySqlConnection conn = AcessConnection.getConection();
                string sql = @"SELECT ID_EMPLEADO, CONCAT(NOMBRE, ' ', APELLIDOP) AS NOMBRE_COMPLETO,
                                          USERNAME, ROL, ESTADO FROM EMPLEADO
                                   WHERE USERNAME = @Usu AND PASSWORD = @Hash AND ESTADO = 'ACTIVO'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usu", usuario);
                cmd.Parameters.AddWithValue("@Hash", hash);
                MySqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    empleado = new Empleado
                    {
                        IdEmpleado = lector.GetInt32("ID_EMPLEADO"),
                        NombreCompleto = lector.GetString("NOMBRE_COMPLETO"),
                        Username = lector.GetString("USERNAME"),
                        Rol = lector.GetString("ROL"),
                        Estado = lector.GetString("ESTADO")
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error");
                voz.SpeakAsync("Error al conectar con la base de datos");
            }
            return empleado;
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e) { }
        private void panelFondo_Paint(object sender, PaintEventArgs e) { }

        private void iconBtnacces_Click(object sender, EventArgs e)
        {
            if (ventanaAcces == null || ventanaAcces.IsDisposed)
            {
                ventanaAcces = new opcionesaccesibilidad(this);
                ventanaAcces.ShowInTaskbar = false;
                ventanaAcces.TopMost = true;

                Point posIcono = iconBtnacces.PointToScreen(Point.Empty);
                ventanaAcces.StartPosition = FormStartPosition.Manual;
                ventanaAcces.Location = new Point(posIcono.X - ventanaAcces.Width + iconBtnacces.Width, posIcono.Y + iconBtnacces.Height + 5);

                ventanaAcces.FormClosed += (s, args) => ventanaAcces = null;
                ventanaAcces.Show(this);
            }
            else
            {
                ventanaAcces.Close();
                ventanaAcces = null;
            }
        }

        private void button1_Click(object sender, EventArgs e) { }
    }
}