using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pj_w4_ManejoDeArchivos_Encriptacion
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
            //Application.Run(new frmComprimir()); proyecto1
            //Application.Run(new frmRegistro()); //proyecto2
            //Application.Run(new frmRegistroProductos()); //proyecto3
            //Application.Run(new frmEmpleadoXML());   //proyecto4
            Application.Run(new frmArrEmpleadoJSON()); //proyecto 5
        }
    }
}
