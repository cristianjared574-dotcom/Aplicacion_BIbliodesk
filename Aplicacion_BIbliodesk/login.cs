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

namespace Aplicacion_BIbliodesk
{
    public partial class login : Form
    {

        private Conexion AcessConnection;

        private Color colorFondoOriginal;
        private Color colorTextoOriginal;
        private Color colorBotonOriginal;
        private bool modoContrasteRojoActivo = false;


        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        public static Empleado EmpleadoActual { get; private set; }

        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cboRol.Items.AddRange(new string[] { "ADMINISTRADOR", "BIBLIOTECARIO" });
            txtContrasena.PasswordChar = '*';

            // Colores originales
            this.BackColor = Color.Beige;
            lblTitulo.ForeColor = Color.FromArgb(20, 20, 20);
            lblSubtitulo.ForeColor = Color.FromArgb(50, 50, 50);
            lblUsuario.ForeColor = Color.Black;
            lblContrasena.ForeColor = Color.Black;
            lblRol.ForeColor = Color.Black;

            btnIniciarSesion.BackColor = Color.FromArgb(20, 80, 160);
            btnIniciarSesion.ForeColor = Color.White;
            btnLeerPantalla.BackColor = Color.FromArgb(212, 175, 55);
            btnLeerPantalla.ForeColor = Color.White;
            btnContraste.BackColor = Color.White;
            btnContraste.ForeColor = Color.Black;

            // Guardamos valores originales
            colorFondoOriginal = this.BackColor;
            colorTextoOriginal = lblTitulo.ForeColor;
            colorBotonOriginal = btnIniciarSesion.BackColor;
        }


        // Cifrado también estático
        public string CifrarContrasena(string textoPlano)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
            //hddnn
        }



        private void login_Load(object sender, EventArgs e) { }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("Completa todos los campos", "Aviso"); voz.SpeakAsync("Llena todos los campos por favor");
                return;
            }

            EmpleadoActual = ValidarCredenciales(txtUsuario.Text.Trim(), txtContrasena.Text.Trim());

            if (EmpleadoActual != null)
            {
                if (EmpleadoActual.Rol == cboRol.SelectedItem.ToString())
                {
                    MessageBox.Show($"¡Bienvenido {EmpleadoActual.NombreCompleto}!", "Acceso concedido");
                    voz.SpeakAsync($"Bienvenido al sistema {EmpleadoActual.NombreCompleto}");

                    //  ABRIR EL FORMULARIO SEGÚN EL ROL
                    if (EmpleadoActual.Rol == "ADMINISTRADOR")
                    {
                        frmInicioAdmin formAdmin = new frmInicioAdmin();
                        formAdmin.Show();
                    }
                    else if (EmpleadoActual.Rol == "BIBLIOTECARIO")
                    {
                        frmInicioBiblio formBiblio = new frmInicioBiblio();
                        formBiblio.Show();
                    }
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
                                          USERNAME, ROL, ESTADO
                                   FROM EMPLEADO
                                   WHERE USERNAME = @Usu 
                                     AND PASSWORD = @Hash 
                                     AND ESTADO = 'ACTIVO'";

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

        // ✅ LECTURA DE PANTALLA
        private void btnLeerPantalla_Click(object sender, EventArgs e)
        {
            voz.SpeakAsync("Bienvenido a Bibliodesk. Selecciona tu rol en la lista, escribe tu usuario y contraseña, luego presiona el botón Iniciar Sesión.");
        }

        // ✅ CAMBIO DE CONTRASTE (ahora incluye Leer pantalla)
        private void btnContraste_Click(object sender, EventArgs e)
        {
            if (!modoContrasteRojoActivo)
            {
                // 🎨 MODO ALTO CONTRASTE ROJO
                this.BackColor = Color.FromArgb(128, 32, 32);
                lblTitulo.ForeColor = Color.FromArgb(153, 0, 0);
                lblSubtitulo.ForeColor = Color.Black;
                lblUsuario.ForeColor = Color.Black;
                lblContrasena.ForeColor = Color.Black;
                lblRol.ForeColor = Color.Black;

                // Botones en modo contraste
                btnContraste.BackColor = Color.White;
                btnContraste.ForeColor = Color.Black;

                btnLeerPantalla.BackColor = Color.White; // ✅ Leer pantalla cambia a fondo blanco
                btnLeerPantalla.ForeColor = Color.Black;

                btnIniciarSesion.BackColor = Color.FromArgb(128, 0, 0);
                btnIniciarSesion.ForeColor = Color.White;

                btnContraste.Text = "Volver a color original";
                modoContrasteRojoActivo = true;
            }
            else
            {
                // 🎨 VUELVE AL COLOR ORIGINAL
                this.BackColor = colorFondoOriginal;
                lblTitulo.ForeColor = colorTextoOriginal;
                lblSubtitulo.ForeColor = colorTextoOriginal;
                lblUsuario.ForeColor = colorTextoOriginal;
                lblContrasena.ForeColor = colorTextoOriginal;
                lblRol.ForeColor = colorTextoOriginal;

                // Botones vuelven a sus colores iniciales
                btnContraste.BackColor = Color.White;
                btnContraste.ForeColor = Color.Black;

                btnLeerPantalla.BackColor = Color.FromArgb(212, 175, 55); // ✅ Tu dorado original
                btnLeerPantalla.ForeColor = Color.White;

                btnIniciarSesion.BackColor = colorBotonOriginal;
                btnIniciarSesion.ForeColor = Color.White;

                btnContraste.Text = "Contraste";
                modoContrasteRojoActivo = false;
            }
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}