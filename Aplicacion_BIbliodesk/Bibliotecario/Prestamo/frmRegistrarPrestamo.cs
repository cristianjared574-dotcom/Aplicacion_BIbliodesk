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
        private int idEjemplareSeleccionado = 0;


        public frmRegistrarPrestamo()
        {
            InitializeComponent();

            dtpPrestamo.Value = DateTime.Now;
            dtpDevolucion.Value = DateTime.Now.AddDays(30);
        }

        private void picBuscarUsuario_MouseHover(object sender, EventArgs e)
        {
            ToolTipAyuda.SetToolTip(picBuscarUsuario, "Buscar usuario por su ID");
        }

        private void picBuscarLibro_MouseHover(object sender, EventArgs e)
        {
            ToolTipAyuda.SetToolTip(picBuscarLibro, "Buscar Libro");
        }




        private void picBuscarUsuario_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtIdUsuario.Text))
            {
                MessageBox.Show("Ingrese el ID del usuario.");
                txtIdUsuario.Focus();
                return;
            }

            try
            {
                //conectamos a la bases de datos 
                AccesoConexion = new Conexion();
                MySqlConnection conexionDB = AccesoConexion.getConection();

                //creamos la consulta
                string consulta = @"SELECT NOMBRE, APELLIDOP, APELLIDOM, CORREO, TELEFONO FROM USUARIO WHERE ID_USUARIO = @id AND ESTADO = 'ACTIVO'";

                //creamos un adaptador para almacenar los resultados de la consulta
                MySqlCommand comando = new MySqlCommand(consulta, conexionDB);
                //Valor de Id
                comando.Parameters.AddWithValue("@id", txtIdUsuario.Text);

                MySqlDataReader Adapter = comando.ExecuteReader();

                if (Adapter.Read())
                {
                    //guardae el ID del usuario
                    idUsuarioSeleccionado = Convert.ToInt32(txtIdUsuario.Text);

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
                MessageBox.Show(ex.Message);
            }


        }

        private void picBuscarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTituloLibro.Text))
            {
                MessageBox.Show("Ingrese el título del libro.");
                txtTituloLibro.Focus();
                return;
            }

            try
            {
                // Conectar a la base de datos
                Conexion accesoConexion = new Conexion();
                MySqlConnection conexionDB = accesoConexion.getConection();

                // Consulta para buscar el libro
                string consulta = @"SELECT 
                        E.ID_EJEMPLAR,
                        L.TITULO,
                        CONCAT(A.NOMBRE, ' ', A.APELLIDOP, ' ', A.APELLIDOM) AS AUTOR
                    FROM LIBRO L
                    INNER JOIN EJEMPLAR E ON L.ID_LIBRO = E.ID_LIBRO
                    INNER JOIN LIBRO_AUTOR LA ON L.ID_LIBRO = LA.ID_LIBRO
                    INNER JOIN AUTOR A ON LA.ID_AUTOR = A.ID_AUTOR
                    WHERE L.TITULO = @titulo
                    AND L.ESTADO = 'ACTIVO'
                    AND E.DISPONIBLE = 'ACTIVO'
                    ORDER BY E.ID_EJEMPLAR
                    LIMIT 1;";

                // Crear el comando
                MySqlCommand comando = new MySqlCommand(consulta, conexionDB);

                // Enviar el título escrito
                comando.Parameters.AddWithValue("@titulo", txtTituloLibro.Text);

                // Ejecutar la consulta
                MySqlDataReader Adapter = comando.ExecuteReader();

                if (Adapter.Read())
                {
                    //guardae el ID del ejemplar disponible
                    idEjemplareSeleccionado = Convert.ToInt32(Adapter["ID_EJEMPLAR"]);

                    lblClaveEjemplar.Text = "Clave del ejemplar: " + Adapter["ID_EJEMPLAR"].ToString();
                    lblNombreLibro.Text = "Libro: " + Adapter["TITULO"].ToString();
                    lblAutorLibro.Text = "Autor: " + Adapter["AUTOR"].ToString();
                }
                else
                {
                    MessageBox.Show("El libro no existe o no hay ejemplares disponibles.", "Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    idEjemplareSeleccionado = 0;
                    lblClaveEjemplar.Text = "Clave del ejemplar:";
                    lblNombreLibro.Text = "Libro:";
                    lblAutorLibro.Text = "Autor:";
                }

                Adapter.Close();
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnGuardarPrestamo_Click(object sender, EventArgs e)
        {
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

                // Consulta para registrar las fechas del préstamo
                string consulta = @"INSERT INTO PRESTAMO (ID_USUARIO,ID_EJEMPLAR,FECHA_INICIO,FECHA_DEVOLUCION,ESTADO) VALUES(@idUsuario,@idEjemplar,@idEmpleado,@fechaInicio,@fechaDevolucion,'ACTIVO');";

                // Crear el comando
                MySqlCommand comando = new MySqlCommand(consulta, conexionDB);

                
                 //ejemplar y empleado seleccionados.
                 
                comando.Parameters.AddWithValue("@idUsuario", idUsuarioSeleccionado);
                comando.Parameters.AddWithValue("@idEjemplar", idEjemplareSeleccionado);
                

                // Guardar las fechas seleccionadas en los DateTimePicker
                comando.Parameters.AddWithValue("@fechaInicio",dtpPrestamo.Value);

                comando.Parameters.AddWithValue("@fechaDevolucion",dtpDevolucion.Value);

                // Ejecutar el INSERT
                int filasAfectadas = comando.ExecuteNonQuery();

                if(filasAfectadas > 0)
                {
                    MessageBox.Show("Préstamo registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el producto");
                }


                // Cerrar la conexión
                conexionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el préstamo: " + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }

}
