using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicacion_BIbliodesk.Administrador;
using Aplicacion_BIbliodesk.Bibliotecario;

namespace Aplicacion_BIbliodesk
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicioEjemplaresAdmin());
        }
    }
}
