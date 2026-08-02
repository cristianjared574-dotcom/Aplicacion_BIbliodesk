using Aplicacion_BIbliodesk.Administrador;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;


namespace Aplicacion_BIbliodesk
    {
    public partial class frmCambiarEstadoEjemplaresAdmin : Form
        {
            private Conexion ConnectionData;

            // ID interno utilizado para realizar el UPDATE
            private string idEjemplar = "";

            // Código visible, por ejemplo: EJE260003
            private string codigoEjemplar = "";

            // Estado actual del ejemplar
            private string estadoActual = "";

            // Constructor vacío necesario para el diseñador
            public frmCambiarEstadoEjemplaresAdmin()
            {
                InitializeComponent();
                CargarEstados();
            }

            // Constructor que recibe los datos de la fila seleccionada
            public frmCambiarEstadoEjemplaresAdmin(
                string id,
                string codigo,
                string estado)
            {
                InitializeComponent();

                idEjemplar = id;
                codigoEjemplar = codigo;
                estadoActual = estado;

                CargarEstados();
            }

            // Cargar los estados permitidos por el ENUM de la base de datos
            private void CargarEstados()
            {
                cmbEstado.Items.Clear();

                cmbEstado.Items.Add("DISPONIBLE");
                cmbEstado.Items.Add("PRESTADO");
                cmbEstado.Items.Add("MANTENIMIENTO");
                cmbEstado.Items.Add("BAJA");

                cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            // Se ejecuta al cargar el formulario
            private void frmCambiarEstadoEjemplaresAdmin_Load(
                object sender,
                EventArgs e)
            {
                // Mostrar la clave del ejemplar, por ejemplo EJE260003
                txtIdEjemplar.Text = codigoEjemplar;

                // Evitar que el administrador modifique el código
                txtIdEjemplar.ReadOnly = true;

                // Mostrar el estado actual en el ComboBox
                if (cmbEstado.Items.Contains(estadoActual))
                {
                    cmbEstado.SelectedItem = estadoActual;
                }
                else
                {
                    // No seleccionar nada si el estado recibido no es válido
                    cmbEstado.SelectedIndex = -1;
                }
            }

            // Evento Guardar Cambios
            private void btnGuardar_Click(object sender, EventArgs e)
            {
                // Validar que se recibió el ID interno
                if (string.IsNullOrWhiteSpace(idEjemplar))
                {
                    MessageBox.Show(
                        "No se recibió el ID interno del ejemplar.",
                        "Error de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                // Convertir el ID interno a número
                if (!int.TryParse(idEjemplar, out int id))
                {
                    MessageBox.Show(
                        "El ID interno del ejemplar no es válido.",
                        "Error de datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                // Validar que se seleccionó un estado
                if (cmbEstado.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Por favor, seleccione un estado válido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                string nuevoEstado = cmbEstado.SelectedItem
                    .ToString()
                    .Trim()
                    .ToUpper();

                // Validar que el estado coincida con el ENUM de MySQL
                if (nuevoEstado != "DISPONIBLE" &&
                    nuevoEstado != "PRESTADO" &&
                    nuevoEstado != "MANTENIMIENTO" &&
                    nuevoEstado != "BAJA")
                {
                    MessageBox.Show(
                        "El estado seleccionado no es válido: [" +
                        nuevoEstado + "]",
                        "Estado inválido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    return;
                }

                // Evitar guardar el mismo estado
                if (nuevoEstado == estadoActual)
                {
                    MessageBox.Show(
                        "El ejemplar ya tiene asignado el estado " +
                        estadoActual + ".",
                        "Sin cambios",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    return;
                }

                ConnectionData = new Conexion();
                MySqlConnection con = ConnectionData.getConection();

                if (con == null)
                {
                    return;
                }

                string query = @"
                UPDATE EJEMPLAR
                SET DISPONIBLE = @nuevoEstado
                WHERE ID_EJEMPLAR = @id";

                try
                {
                    using (MySqlCommand cmd =
                           new MySqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@nuevoEstado",
                            MySqlDbType.VarChar
                        ).Value = nuevoEstado;

                        cmd.Parameters.Add(
                            "@id",
                            MySqlDbType.Int32
                        ).Value = id;

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show(
                                "El estado del ejemplar se actualizó correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            estadoActual = nuevoEstado;

                            RegresarAListaEjemplares();
                    }
                        else
                        {
                            MessageBox.Show(
                                "No se encontró el ejemplar o no se realizaron cambios.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al actualizar el estado: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }

            // Evento Cancelar
            private void btnCancelar_Click(object sender, EventArgs e)
            {
                RegresarAListaEjemplares();
            }


            private void RegresarAListaEjemplares()
            {
                frmInicioAdmin inicioAdmin =
                    Application.OpenForms["frmInicioAdmin"] as frmInicioAdmin;

                if (inicioAdmin != null)
                {
                    frmInicioEjemplaresAdmin formularioEjemplares =
                        new frmInicioEjemplaresAdmin();

                    inicioAdmin.AbrirFormularioEnPanelAdmin(formularioEjemplares);
                }
                else
                {
                    Close();
                }
            }
    }
}
