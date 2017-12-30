using CapaDePersistencia;
using LogicaDeNegocio;
using ModeloDeDominio;
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

            //Elementos de ejemplo para pruebas
            serviciosDependiente.cargarDependientesEjemplo();
            serviciosArticulo.cargarArticulosEjemplo(250);
            serviciosVenta.cargarVentasEjemplo(100);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FArticulo("3245","fs","df",false));
            Application.Run(new FPrincipal(serviciosDependiente,serviciosArticulo,serviciosVenta));
        }
    }
}
