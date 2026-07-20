using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario.Prestamo
{
    public partial class frmRegistrarPrestamo : Form
    {
        private Conexion AccesoConexion;
        private int idUsuarioSeleccionado = 0;
        private int idEjemplarSeleccionado = 0;


        public frmRegistrarPrestamo()
        {
            InitializeComponent();

            dtpPrestamo.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now.AddDays(14);
        }

        private void picBuscarUsuario_MouseHover(object sender, EventArgs e)
        {
            ToolTipAyuda.SetToolTip(picBuscarUsuario, "Buscar usuario");
        }

        private void picBuscarLibro_MouseHover(object sender, EventArgs e)
        {
            ToolTipAyuda.SetToolTip(picBuscarLibro, "Buscar Libro");
        }




        private void picBuscarUsuario_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMatriculaUsuario.Text))
            {
                MessageBox.Show("Ingrese la matricula del usuario.");
                txtMatriculaUsuario.Focus();
                return;
            }

            try
            {
                //conectamos a la bases de datos 
                AccesoConexion = new Conexion();
                MySqlConnection conexionDB = AccesoConexion.getConection();

                if(conexionDB == null)
                {
                    return;
                }

                //creamos la consulta buscando al usuario
                string consulta = @"SELECT ID_USUARIO, NOMBRE, APELLIDOP, APELLIDOM, CORREO, TELEFONO FROM USUARIO WHERE MATRICULA_USUARIO = @matricula AND ESTADO = 'ACTIVO'";

                //creamos un adaptador para almacenar los resultados de la consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexionDB);
                //Valor de Id
                comando.Parameters.AddWithValue("@matricula", txtMatriculaUsuario.Text.Trim());

                //lector de datos
                MySqlDataReader Adapter = comando.ExecuteReader();

                if (Adapter.Read())
                {
                    //guardae el ID del usuario
                    idUsuarioSeleccionado = Convert.ToInt32(Adapter["ID_USUARIO"]);

                    lblNombreUsuario.Text = "Nombre: " + Adapter["NOMBRE"].ToString() + " " + Adapter["APELLIDOP"].ToString() + " " + Adapter["APELLIDOM"].ToString();
                    lblCorreoUsuario.Text = "Correo: " + Adapter["CORREO"].ToString();
                    lblTelefonoUsuario.Text = "Telefono: " + Adapter["TELEFONO"].ToString();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario.");
                    idUsuarioSeleccionado = 0;
                    lblNombreUsuario.Text = "Nombre:";
                    lblCorreoUsuario.Text = "Correo:";
                    lblTelefonoUsuario.Text = "Telefono";
                }

                Adapter.Close();
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar al usuario" + ex.Message);
            }


        }

        private void picBuscarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClaveEjemplar.Text))
            {
                MessageBox.Show("Ingrese la clave del ejemplar.");
                txtClaveEjemplar.Focus();
                return;
            }

            try
            {
                // Conectar a la base de datos
                Conexion accesoConexion = new Conexion();
                MySqlConnection conexionDB = accesoConexion.getConection();

                if( conexionDB == null )
                {
                    return;
                }

                // Consulta para buscar el libro
                string consulta = @"SELECT 
                        E.ID_EJEMPLAR,
                        E.CLAVE_EJEMPLAR,
                        E.DISPONIBLE,
                        L.TITULO,
                        CONCAT(A.NOMBRE, ' ', A.APELLIDOP, ' ', A.APELLIDOM) AS AUTOR
                    FROM EJEMPLAR E
                    INNER JOIN LIBRO L ON E.ID_LIBRO = L.ID_LIBRO
                    INNER JOIN LIBRO_AUTOR LA ON L.ID_LIBRO = LA.ID_LIBRO
                    INNER JOIN AUTOR A ON LA.ID_AUTOR = A.ID_AUTOR
                    WHERE E.CLAVE_EJEMPLAR = @claveEjemplar AND L.ESTADO = 'ACTIVO';";

                // Crear el comando
                MySqlCommand comando = new MySqlCommand(consulta, conexionDB);

                // Enviar el título escrito
                comando.Parameters.AddWithValue("@claveEjemplar", txtClaveEjemplar.Text.Trim());

                // lector de datos
                MySqlDataReader Adapter = comando.ExecuteReader();

                if (Adapter.Read())
                {
                    String disponibilidad = Adapter["DISPONIBLE"].ToString();

                    if (disponibilidad == "DISPONIBLE")
                    {
                        //guardae el ID del ejemplar disponible
                        idEjemplarSeleccionado = Convert.ToInt32(Adapter["ID_EJEMPLAR"]);

                        lblClaveEjemplar.Text = "Clave del ejemplar: " + Adapter["CLAVE_EJEMPLAR"].ToString();
                        lblNombreLibro.Text = "Libro: " + Adapter["TITULO"].ToString();
                        lblAutorLibro.Text = "Autor: " + Adapter["AUTOR"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El ejemplar se encuentra como " + disponibilidad, "Ejemplar no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarDatosEjemplar();
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo registrar este ejemplar. Verifique que la clave sea correcta y que aparezca como disponible en el sistema.", "Verificar Ejemplar",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpiarDatosEjemplar();
                }

                Adapter.Close();
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el ejemplar" + ex.Message);
            }


        }
        //limpiar datos del libro
        private void LimpiarDatosEjemplar()
        {
            idEjemplarSeleccionado = 0;

            lblClaveEjemplar.Text = "Clave del ejemplar:";
            lblNombreLibro.Text = "Libro:";
            lblAutorLibro.Text = "Autor:";

            txtClaveEjemplar.Focus();
        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
            // Validar que se haya seleccionado un usuario
            if (idUsuarioSeleccionado == 0)
            {
                MessageBox.Show("Primero debe buscar y seleccionar un usuario.","Usuario requerido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            // Validar que se haya seleccionado un ejemplar
            if (idEjemplarSeleccionado == 0)
            {
                MessageBox.Show("Primero debe buscar y seleccionar un ejemplar.","Ejemplar requerido",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            // Validar que la fecha de devolución sea posterior a la fecha de préstamo
            if (dtpDevolucion.Value.Date <= dtpPrestamo.Value.Date)
            {
                MessageBox.Show("La fecha de devolución debe ser posterior a la fecha de préstamo.","Fechas incorrectas",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                dtpDevolucion.Focus();
                return;
            }

            try
            {
                // Conectar a la base de datos
                Conexion accesoConexion = new Conexion();
                MySqlConnection conexionDB = accesoConexion.getConection();

                if (conexionDB == null)
                {
                    return;
                }

                // Consulta para registrar el préstamo
                string consulta = @"INSERT INTO PRESTAMO (ID_USUARIO,ID_EJEMPLAR,FECHA_INICIO,FECHA_DEVOLUCION,ESTADO) VALUES(@idUsuario,@idEjemplar,@fechaInicio,@fechaDevolucion,'ACTIVO');";

                // Crear el comando
                MySqlCommand comando = new MySqlCommand(consulta, conexionDB);

                
                 //ejemplar y empleado seleccionados.
                 
                comando.Parameters.AddWithValue("@idUsuario", idUsuarioSeleccionado);
                comando.Parameters.AddWithValue("@idEjemplar", idEjemplarSeleccionado);
                

                // Guardar las fechas seleccionadas en los DateTimePicker
                comando.Parameters.AddWithValue("@fechaInicio",dtpPrestamo.Value);

                comando.Parameters.AddWithValue("@fechaDevolucion",dtpDevolucion.Value);

                // Ejecutar el INSERT
                int filasAfectadas = comando.ExecuteNonQuery();

                if(filasAfectadas > 0)
                {
                    //Obtener el ID generado por MYSQL
                    int idPrestamo = Convert.ToInt32(comando.LastInsertedId);

                    //generar el folio del prestamo (es decir la clave)
                    string folioPrestamo = "PRE" + idPrestamo.ToString("D3");

                    //Guarda el folio
                    string ConsultaFolio = @"UPDATE PRESTAMO
                            SET FOLIO_PRESTAMO = @folio
                            WHERE ID_PRESTAMO = @idPrestamo;";

                    MySqlCommand comandoFolio = new MySqlCommand(ConsultaFolio, conexionDB);

                    comandoFolio.Parameters.AddWithValue("@folio", folioPrestamo);

                    comandoFolio.Parameters.AddWithValue("@idPrestamo", idPrestamo);

                    comandoFolio.ExecuteNonQuery();

                    //Cambiar el estado del ejemplar
                    string ConsultaEjemplar = @"UPDATE EJEMPLAR 
                            SET DISPONIBLE = 'PRESTADO'
                            WHERE ID_EJEMPLAR = @idEjemplar;";

                    MySqlCommand comandoEjemplar = new MySqlCommand(ConsultaEjemplar, conexionDB);

                    comandoEjemplar.Parameters.AddWithValue("@idEjemplar", idEjemplarSeleccionado);

                    comandoEjemplar.ExecuteNonQuery();

                    MessageBox.Show("Préstamo registrado correctamente.\n" + "Folio: " + folioPrestamo, "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormularioPrestamo();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el prestamo.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Cerrar la conexión
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormularioPrestamo()
        {
            txtMatriculaUsuario.Clear();
            txtClaveEjemplar.Clear();

            idUsuarioSeleccionado = 0;
            idEjemplarSeleccionado = 0;

            lblNombreUsuario.Text = "Nombre:";
            lblCorreoUsuario.Text = "Correo:";
            lblTelefonoUsuario.Text = "Teléfono:";

            lblClaveEjemplar.Text = "Clave del ejemplar:";
            lblNombreLibro.Text = "Libro:";
            lblAutorLibro.Text = "Autor:";

            dtpPrestamo.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now.AddDays(14);

            txtMatriculaUsuario.Focus();
        }

    }

}
