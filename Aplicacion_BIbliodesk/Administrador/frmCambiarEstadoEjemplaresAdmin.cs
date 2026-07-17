using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_BIbliodesk.Administrador
{
    public partial class frmCambiarEstadoEjemplaresAdmin : Form
    {
        private string idEjemplar;
        private string estadoActual;
        public frmCambiarEstadoEjemplaresAdmin(string id, string estado)
        {
            InitializeComponent();

            this.idEjemplar = id;
            this.estadoActual = estado;
        }

        
    }
}
