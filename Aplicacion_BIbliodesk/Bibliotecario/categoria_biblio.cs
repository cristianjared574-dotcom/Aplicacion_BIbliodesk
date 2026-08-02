using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class categoria_biblio : Form
    {
        private Conexion AccessData;

        // 1. AGREGA ESTA VARIABLE: guarda el ID si es edición (0 = nuevo)
        private int _idCategoriaEditar = 0;

        // Constructor para agregar
        public categoria_biblio()
        {
            InitializeComponent();

            btnguardarcategoria.Text = "Guardar";
        }

        // Constructor para editar
        public categoria_biblio(int id, string nombre, string descripcion)
        {
            InitializeComponent();

            _idCategoriaEditar = id;

            txtnombre.Text = nombre;
            txtdescripcion.Text = descripcion;

            btnguardarcategoria.Text = "Actualizar cambios";
        }
        private void btnguardarcategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("Escribe el nombre de la categoría.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conn = new Conexion().getConection())
                {
                    if (conn == null)
                    {
                        MessageBox.Show("No se pudo conectar a la base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string sql;
                    if (_idCategoriaEditar > 0)
                    {
                        sql = @"UPDATE CATEGORIA
                        SET NOMBRE_CATEGORIA = @Nombre, DESCRIPCION = @Descripcion
                        WHERE ID_CATEGORIA = @Id;";
                    }
                    else
                    {
                        sql = @"INSERT INTO CATEGORIA (NOMBRE_CATEGORIA, DESCRIPCION, ESTADO)
                        VALUES (@Nombre, @Descripcion, 'ACTIVO');";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text.Trim());

                        if (_idCategoriaEditar > 0)
                            cmd.Parameters.AddWithValue("@Id", _idCategoriaEditar);

                        // ❌ YA NO PONGAS conn.Open(); → LA CLASE YA LO HIZO
                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            string mensaje = _idCategoriaEditar > 0
                                ? "Categoría actualizada correctamente."
                                : "Categoría agregada correctamente.";

                            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            conn.Close(); // ✅ Cierra al terminar
                            RegresarALista();
                        }
                        else
                        {
                            MessageBox.Show("No se hicieron cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RegresarALista()
        {
            frmInicioBiblio inicio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;
            if (inicio != null)
            {
                categorias_biblo listaNueva = new categorias_biblo();
                inicio.AbrirFormularioEnPanel(listaNueva);
            }
        }
      //  private void btncancelar_Click(object sender, EventArgs e)
      //  {
            // Limpia y regresa a la lista sin cambios
            /*frmInicioBiblio ventanaInicio = this.ParentForm as frmInicioBiblio;
            if (ventanaInicio != null)
            {
                ventanaInicio.AbrirFormularioEnPanel(new categorias_biblo());
            }*/

             
     //   }

        private void categoria_biblio_Load(object sender, EventArgs e)
        {


        }

      

        private void btncancelar_Click_1(object sender, EventArgs e)
        {
            categorias_biblo inicioCategorias = new categorias_biblo();
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if (inicioBiblio != null)
            {
                inicioBiblio.AbrirFormularioEnPanel(inicioCategorias);
            }
        }
    }
}