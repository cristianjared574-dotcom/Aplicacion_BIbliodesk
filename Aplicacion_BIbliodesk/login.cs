using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk
{
    public partial class login : Form
    {
        private readonly SpeechSynthesizer voz = new SpeechSynthesizer();
        public static Empleado EmpleadoActual { get; private set; }

        public login()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cboRol.Items.AddRange(new string[] { "ADMINISTRADOR", "BIBLIOTECARIO" });
            txtContrasena.PasswordChar = '*';
        }

        private void login_Load(object sender, EventArgs e) { }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cboRol.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtContrasena.Text))
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
                    MessageBox.Show($"¡Bienvenido {EmpleadoActual.NombreCompleto}!", "Acceso concedido");
                    voz.SpeakAsync($"Bienvenido al sistema {EmpleadoActual.NombreCompleto}");

                    // ✅ ABRIR EL FORMULARIO SEGÚN EL ROL
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

                    this.Hide(); // Oculta el login
                }
                else
                {
                    MessageBox.Show("El rol seleccionado no coincide con tu cuenta", "Error");
                    voz.SpeakAsync("El rol no coincide");
                    txtContrasena.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario, contraseña incorrectos o cuenta inactiva", "Error");
                voz.SpeakAsync("Datos incorrectos");
                txtContrasena.Clear();
            }
        }

        private Empleado ValidarCredenciales(string usuario, string contrasena)
        {
            Empleado empleado = null;
            string hash = Conexion.CifrarContrasena(contrasena);

            try
            {
                using (MySqlConnection conn = Conexion.ObtenerConexion())
                {
                    string sql = @"SELECT ID_EMPLEADO, CONCAT(NOMBRE, ' ', APELLIDOP) AS NOMBRE_COMPLETO,
                                          USERNAME, ROL, ESTADO
                                   FROM EMPLEADO
                                   WHERE USERNAME = @Usu 
                                     AND PASSWORD = @Hash 
                                     AND ESTADO = 'ACTIVO'";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usu", usuario);
                        cmd.Parameters.AddWithValue("@Hash", hash);

                        using (MySqlDataReader lector = cmd.ExecuteReader())
                        {
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar: " + ex.Message, "Error");
            }
            return empleado;
        }

        private void btnLeerPantalla_Click(object sender, EventArgs e)
        {
            voz.SpeakAsync("Selecciona tu rol, escribe usuario y contraseña para acceder");
        }

        private void btnMasLetra_Click(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font.FontFamily, this.Font.Size + 1);
        }

        private void btnMenosLetra_Click(object sender, EventArgs e)
        {
            if (this.Font.Size > 8)
                this.Font = new Font(this.Font.FontFamily, this.Font.Size - 1);
        }
    }
}