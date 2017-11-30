using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    public class Persistencia
    {
        //Servicios para ventas

        public static bool anadirVentaConTarjeta(VentaConTarjeta v)
        {
            /*
             * Hago una copia antes de guardarlo, para que la clase que lo envió no pueda modificarlo
             */

            Venta aux = v.copiar();
            BaseDeDatos.Ventas.Add(aux);
        }

        /* UNA VEZ QUE UNA VENTA ESTÁ EN LA BD NO DEBERÍA PODER MODIFICARSE - yo esto no lo pondría
        public static bool anadirLineaVenta(LineaDeVenta l, Venta v)
        {
            //para añadir una línea a una venta que ya está en la base de datos
            throw new NotImplementedException();
        }
        */

        public static Venta getVenta(Venta v)
        {
            throw new NotImplementedException();
        }

        public static List<LineaDeVenta> getLineasVenta(Venta v)
        {
            throw new NotImplementedException();
        }

        public static List<Venta> getVentasDeArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }

        //Servicios para dependientes



        //Servicios para artículos




    }
}
