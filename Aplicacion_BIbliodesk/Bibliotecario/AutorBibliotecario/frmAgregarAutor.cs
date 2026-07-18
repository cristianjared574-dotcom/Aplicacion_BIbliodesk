using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario.AutorBibliotecario
{
    public partial class frmAgregarAutor : Form
    {
        public frmAgregarAutor()
        {
            InitializeComponent();
            cmbEstado.Items.Add("ACTIVO");
            cmbEstado.Items.Add("INACTIVO");
            cmbEstado.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtAp.Text))
            {
                MessageBox.Show("Por favor, rellene los campos obligatorios.");
                return;
            }

                Conexion.ConnectionData con = new Conexion.ConnectionData();
            using (MySqlConnection conn = con.getConection())
            {
                try
                {
                    if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                    string query = "INSERT INTO autor (NOMBRE,APELLIDOP,APELLIDOM,NACIONALIDAD,ESTADO)" +
                        "VALUES (@nom,@apP,@apM,@nac,@est)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                        cmd.Parameters.AddWithValue("@apP", txtAp.Text.Trim());
                        cmd.Parameters.AddWithValue("@apM", txtAm.Text.Trim());
                        cmd.Parameters.AddWithValue("@nac", txtnacionalidad.Text.Trim());
                        cmd.Parameters.AddWithValue("@est", cmbEstado.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Autor registrado correctamente");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

    }
}
