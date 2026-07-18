using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Bibliotecario.Prestamo
{
    public partial class frmPrestamoBiblio : Form
    {
        public frmPrestamoBiblio()
        {
            InitializeComponent();
        }

        private void btnRegistrarPrestamo_Click(object sender, EventArgs e)
        {
            frmInicioBiblio inicioBiblio = Application.OpenForms["frmInicioBiblio"] as frmInicioBiblio;

            if(inicioBiblio != null)
            {
                frmRegistrarPrestamo nuevoPrestamo = new frmRegistrarPrestamo();
                inicioBiblio.AbrirFormularioEnPanel(nuevoPrestamo);
            }
            /*frmInicioBiblio menuPrincipalBibliotecario = new frmInicioBiblio();

            //frmRegistrarPrestamo PantallaRegistar = new frmRegistrarPrestamo();
            menuPrincipalBibliotecario.AbrirFormularioEnPanel(new frmRegistrarPrestamo());*/
        }
    }
}
