using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Aplicacion_BIbliodesk
{
    public partial class login : Form
    {
        private Conexion AcessConnection;
        public static Empleado EmpleadoActual { get; private set; }

        // Variables para accesibilidad (se mantienen igual)
        private Color colorFondoOriginal;
        private Color colorTextoOriginal;
        private Color colorBotonOriginal;
        private Color colorTextoTituloOriginal;
        private Color colorTextoNormalOriginal;
        private Color colorPanelOriginal;
        private Color colorTextoAccesibilidadOriginal;
        private Color colorFondoIconoOriginal;

        private readonly Color fondoVentanaNormal = Color.FromArgb(153, 0, 0);
        private readonly Color textoVentanaNormal = Color.White;
        private readonly Color botonVentanaNormal = Color.FromArgb(128, 0, 0);

        private readonly Color fondoVentanaContraste = Color.Gold;
        private readonly Color textoVentanaContraste = Color.Black;
        private readonly Color botonVentanaContraste = Color.FromArgb(25, 90, 160);

        private float escalaActual = 1.0f;
        private const float pasoEscala = 0.1f;
        private Size tamanoFormularioOriginal;
        private readonly Point posicionFijaAbsoluta;
        private Dictionary<Control, (Point MargenIzqSup, Size TamanoOriginal, Font FuenteOriginal)> controlesOriginales = new Dictionary<Control, (Point, Size, Font)>();
        private opcionesaccesibilidad ventanaAcces;

        public bool ContrasteActivo { get; private set; } = false;

        public login()
        {
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;
            StartPosition = FormStartPosition.Manual;
            this.Location = new Point(543, 166);
            posicionFijaAbsoluta = this.Location;
            tamanoFormularioOriginal = this.Size;

            txtContrasena.PasswordChar = '*';

            // Colores originales
            this.BackColor = Color.FromArgb(128, 32, 32);
            lblTitulo.ForeColor = Color.FromArgb(153, 0, 0);
            lblSubtitulo.ForeColor = Color.Black;
            lblUsuario.ForeColor = Color.Black;
            lblContrasena.ForeColor = Color.Black;

            btnIniciarSesion.BackColor = Color.FromArgb(128, 0, 0);
            btnIniciarSesion.ForeColor = Color.White;

            panelFondo.BackColor = Color.FromArgb(255, 228, 196);
            iconBtnacces.IconColor = Color.White;

            colorFondoOriginal = this.BackColor;
            colorTextoOriginal = lblTitulo.ForeColor;
            colorBotonOriginal = btnIniciarSesion.BackColor;
            colorTextoTituloOriginal = lblTitulo.ForeColor;
            colorTextoNormalOriginal = lblSubtitulo.ForeColor;
            colorPanelOriginal = panelFondo.BackColor;
            colorTextoAccesibilidadOriginal = iconBtnacces.ForeColor;
            colorFondoIconoOriginal = iconBtnacces.BackColor;

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
                Point margenFijo = new Point(c.Left, c.Top);
                controlesOriginales[c] = (margenFijo, c.Size, c.Font);
                if (c.HasChildren) GuardarEstadoOriginal(c);
            }
        }

        public void CambiarContraste()
        {
            ContrasteActivo = !ContrasteActivo;

            if (ContrasteActivo)
            {
                this.BackColor = Color.FromArgb(255, 248, 230);
                lblTitulo.ForeColor = Color.FromArgb(20, 20, 20);
                lblSubtitulo.ForeColor = Color.FromArgb(40, 40, 40);
                lblUsuario.ForeColor = Color.Black;
                lblContrasena.ForeColor = Color.Black;

                btnIniciarSesion.BackColor = Color.FromArgb(25, 90, 160);
                btnIniciarSesion.ForeColor = Color.White;
                panelFondo.BackColor = Color.White;

                iconBtnacces.IconColor = Color.Black;
                iconBtnacces.ForeColor = Color.Black;
                iconBtnacces.BackColor = Color.FromArgb(212, 175, 55);

                if (ventanaAcces != null && !ventanaAcces.IsDisposed)
                {
                    ventanaAcces.AplicarEstadoContraste(fondoVentanaContraste, textoVentanaContraste, botonVentanaContraste);
                }
            }
            else
            {
                this.BackColor = colorFondoOriginal;
                lblTitulo.ForeColor = colorTextoTituloOriginal;
                lblSubtitulo.ForeColor = colorTextoNormalOriginal;
                lblUsuario.ForeColor = colorTextoNormalOriginal;
                lblContrasena.ForeColor = colorTextoNormalOriginal;

                btnIniciarSesion.BackColor = colorBotonOriginal;
                btnIniciarSesion.ForeColor = Color.White;
                panelFondo.BackColor = colorPanelOriginal;

                iconBtnacces.IconColor = Color.White;
                iconBtnacces.ForeColor = colorTextoAccesibilidadOriginal;
                iconBtnacces.BackColor = colorFondoIconoOriginal;

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
            foreach (var item in controlesOriginales)
            {
                Control c = item.Key;
                var (margenFijo, tamOriginal, fuenteOriginal) = item.Value;
                c.Location = margenFijo;
                c.Size = new Size((int)(tamOriginal.Width * escalaActual), (int)(tamOriginal.Height * escalaActual));
                c.Font = new Font(fuenteOriginal.FontFamily, fuenteOriginal.Size * escalaActual, fuenteOriginal.Style);
            }
            ActualizarPosicionVentana(null, null);
        }

        // ✅ FUNCIÓN CORREGIDA: genera el MISMO código que la base de datos
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
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Completa usuario y contraseña", "Aviso");
                return;
            }

            EmpleadoActual = ValidarCredenciales(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

            if (EmpleadoActual != null)
            {
                MessageBox.Show($"Bienvenido al sistema {EmpleadoActual.NombreCompleto}", "Bibliodesk");

                if (EmpleadoActual.Rol == "ADMINISTRADOR")
                {
                    new frmInicioAdmin().Show();
                }
                else if (EmpleadoActual.Rol == "BIBLIOTECARIO")
                {
                    new frmInicioBiblio().Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario, contraseña incorrectos o cuenta inactiva", "Error");
                txtContrasena.Clear();
            }
        }

        private Empleado ValidarCredenciales(string usuario, string contrasena)
        {
            Empleado empleado = null;
            string hashGenerado = CifrarContrasena(contrasena);

            try
            {
                AcessConnection = new Conexion();
                MySqlConnection conn = AcessConnection.getConection();

                string sql = @"SELECT ID_EMPLEADO, CONCAT(NOMBRE, ' ', APELLIDOP) AS NOMBRE_COMPLETO,
                                      MATRICULA_EMPLEADO, ROL, ESTADO 
                                      FROM EMPLEADO
                                      WHERE MATRICULA_EMPLEADO = @Usu 
                                      AND PASSWORD = @Hash 
                                      AND ESTADO = 'ACTIVO'";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Usu", usuario);
                cmd.Parameters.AddWithValue("@Hash", hashGenerado);

                MySqlDataReader lector = cmd.ExecuteReader();
                if (lector.Read())
                {
                    empleado = new Empleado
                    {
                        IdEmpleado = lector.GetInt32("ID_EMPLEADO"),
                        NombreCompleto = lector.GetString("NOMBRE_COMPLETO"),
                        Username = lector.GetString("MATRICULA_EMPLEADO"),
                        Rol = lector.GetString("ROL"),
                        Estado = lector.GetString("ESTADO")
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error");
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