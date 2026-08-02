using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;


namespace Aplicacion_BIbliodesk.Bibliotecario
{
    public partial class categoria_biblio : Form
    {
        private Conexion AccessData;


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

        private string GenerarClaveCategoria()
        {
            string ultimaClave = "CO00";
            using (MySqlConnection conn = new Conexion().getConection())
            {
                string sql = "SELECT IFNULL(MAX(CLAVE_CATEGORIA), 'CO00') FROM CATEGORIA";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    var res = cmd.ExecuteScalar();
                    if (res != null && res != DBNull.Value)
                        ultimaClave = res.ToString();
                }
            }
            int num = int.Parse(ultimaClave.Replace("CO", "")) + 1;
            return $"CO{num:D2}";
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
                    string claveNueva = "";
                    if (_idCategoriaEditar > 0)
                    {
                        sql = @"UPDATE CATEGORIA
                        SET NOMBRE_CATEGORIA = @Nombre, DESCRIPCION = @Descripcion
                        WHERE ID_CATEGORIA = @Id;";
                    }
                    else
                    {
                        claveNueva = GenerarClaveCategoria();
                        sql = @"INSERT INTO CATEGORIA (CLAVE_CATEGORIA, NOMBRE_CATEGORIA, DESCRIPCION, ESTADO)
                                VALUES (@Clave, @Nombre, @Descripcion, 'ACTIVO');";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtnombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@Descripcion", txtdescripcion.Text.Trim());
                        if (_idCategoriaEditar > 0)
                        {
                            cmd.Parameters.AddWithValue("@Id", _idCategoriaEditar);
                        }
                        else
                        {
                            
                            cmd.Parameters.AddWithValue("@Clave", claveNueva);
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {

                            string mensaje = _idCategoriaEditar > 0
                                ? "Categoría actualizada correctamente."
                                : $"Categoría agregada.\nClave generada: {claveNueva}";

                            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                           

                            RegresarALista(); 
                        }
                        else
                        {
                            MessageBox.Show("No se hicieron cambios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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