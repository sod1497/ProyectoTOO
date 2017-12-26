using LogicaDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ServiciosArticulos serviciosArticulo=new ServiciosArticulos();
            ServiciosDependiente serviciosDependiente=new ServiciosDependiente();
            ServiciosVenta serviciosVenta = new ServiciosVenta();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new formArticulo("3245","fs","df",false));
            Application.Run(new FPrincipal(serviciosDependiente,serviciosArticulo,serviciosVenta));
        }
    }
}
