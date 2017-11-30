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

        //Servicios para dependientes

        public static bool anadirDependiente(Dependiente d)
        {
            throw new NotImplementedException();
        }

        public static bool borrarDependiente(Dependiente d)
        {
            throw new NotImplementedException();
        }

        public static bool contieneDependiente(Dependiente d)
        {
            throw new NotImplementedException();
        }

        public static bool darDeBajaDependiente(Dependiente d)
        {
            throw new NotImplementedException();
        }

        public static bool darDeAltaDependiente(Dependiente d)
        {
            throw new NotImplementedException();
        }

        public static Dependiente getDependiente(Dependiente d)
        {
            throw new NotImplementedException();
        }

        public static List<Dependiente> getDependientesTienda()
        {
            throw new NotImplementedException();
        }

        public static List<Venta> getVentasDeDependiente(Dependiente d, DateTime fecha)
        {
            //podemos pasarle el día 1 de un mes y año y que solo se fije en estos dos últimos
            //Por ejemplo le paso 1/enero/2017 y devuelve las ventas de enero/2017

            throw new NotImplementedException();
        }

        //Servicios para ventas

        public static bool anadirVenta(Venta v)
        {
            /*
             * Hago una copia antes de guardarlo, para que la clase que lo envió no pueda modificarlo
             */

            Venta aux = v.copiar();
            BaseDeDatos.Ventas.Add(aux);
            return true;
        }

        public static bool borrarVenta(Venta v)
        {
            throw new NotImplementedException();
        }

        public static Venta getVenta(Venta v)
        {
            throw new NotImplementedException();
        }

        public static List<Venta> getTodasVenta()
        {
            throw new NotImplementedException();
        }

        //Servicios para artículos

        public static bool anadirArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }

        public static bool borrarArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }

        public static bool darDeBajaArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }

        public static bool darDeAltaArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }

        public static Articulo getArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }

        public static List<Articulo> getTodosArticulo()
        {
            throw new NotImplementedException();
        }

        public static List<Venta> getVentasDeArticulo(Articulo a)
        {
            throw new NotImplementedException();
        }
        
    }
}
