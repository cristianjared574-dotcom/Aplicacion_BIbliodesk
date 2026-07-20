using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class categoria_biblio : Form
    {
        // ✅ 1. AGREGA ESTA VARIABLE: guarda el ID si es edición (0 = nuevo)
        private int _idCategoriaEditar = 0;

        // 📌 CONSTRUCTOR PARA AGREGAR NUEVO (el que ya tenías)
        public categoria_biblio()
        {
            InitializeComponent();

            // Conectamos eventos manualmente para seguridad
            btnguardarcategoria.Click -= btnguardarcategoria_Click;
            btnguardarcategoria.Click += btnguardarcategoria_Click;
            btncancelar.Click -= btncancelar_Click;
            btncancelar.Click += btncancelar_Click;

            // ✅ Para nuevo: limpia todo y marca como categoría nueva
            _idCategoriaEditar = 0;
            txtnombre.Clear();
            txtdescripcion.Clear();
            btnguardarcategoria.Text = "Guardar Categoría";
        }

        // ✅ 2. AGREGA ESTE NUEVO CONSTRUCTOR: recibe datos para EDITAR
        public categoria_biblio(int id, string nombre, string descripcion)
        {
            InitializeComponent();

            // Conectamos eventos
            btnguardarcategoria.Click -= btnguardarcategoria_Click;
            btnguardarcategoria.Click += btnguardarcategoria_Click;
            btncancelar.Click -= btncancelar_Click;
            btncancelar.Click += btncancelar_Click;

            // Carga los datos de la categoría seleccionada
            _idCategoriaEditar = id;
            txtnombre.Text = nombre;
            txtdescripcion.Text = descripcion;
            btnguardarcategoria.Text = "Actualizar Cambios"; // Cambia el texto del botón
        }

        private void btnguardarcategoria_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Escribe el nombre de la categoría", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = Conexion.getConection())
                {
                    string sql;

                    // Elige INSERT o UPDATE según sea nuevo o edición
                    if (_idCategoriaEditar > 0)
                    {
                        sql = @"UPDATE CATEGORIA 
                        SET NOMBRE_CATEGORIA = @Nombre, DESCRIPCION = @Descripcion
                        WHERE ID_CATEGORIA = @Id";
                    }
                    else
                    {
                        sql = @"INSERT INTO CATEGORIA (NOMBRE_CATEGORIA, DESCRIPCION, ESTADO)
                       VALUES (@Nombre, @Descripcion, 'ACTIVO')";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text.Trim());

                        if (_idCategoriaEditar > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", _idCategoriaEditar);
                        }

                        // ❌ BORRA ESTA LÍNEA: conn.Open(); → YA NO SE NECESITA
                        cmd.ExecuteNonQuery();
                    }
                }

                string mensaje = _idCategoriaEditar > 0
                    ? "✅ Categoría actualizada correctamente"
                    : "✅ Categoría guardada correctamente";

                MessageBox.Show(mensaje, "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresa a la lista YA ACTUALIZADA
                frmInicioBiblio inicio = this.ParentForm as frmInicioBiblio;
                if (inicio != null)
                {
                    inicio.AbrirFormularioEnPanel(new categorias_biblo());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Limpia y regresa a la lista sin cambios
            frmInicioBiblio ventanaInicio = this.ParentForm as frmInicioBiblio;
            if (ventanaInicio != null)
            {
                ventanaInicio.AbrirFormularioEnPanel(new categorias_biblo());
            }
        }

        private void categoria_biblio_Load(object sender, EventArgs e)
        {

        }
    }
}