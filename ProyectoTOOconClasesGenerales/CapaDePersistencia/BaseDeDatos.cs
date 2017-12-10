using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    public class BaseDatos
    {
        private static Coleccion<ModeloDeDominio.Dependiente> dependientes;
        private static Coleccion<ModeloDeDominio.Venta> ventas;
        private static Coleccion<ModeloDeDominio.Articulo> articulos;


        public static Coleccion<T> get<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            if (t is ModeloDeDominio.Dependiente)
            {
                if (dependientes == null)
                {
                    dependientes = new Coleccion<ModeloDeDominio.Dependiente>();
                }
                return dependientes as Coleccion<T>;
            }
            else if (t is ModeloDeDominio.Venta)
            {
                if (ventas == null)
                {
                    ventas = new Coleccion<ModeloDeDominio.Venta>();
                }
                return ventas as Coleccion<T>;
            }
            else if (t is ModeloDeDominio.Articulo)
            {
                if (articulos == null)
                {
                    articulos = new Coleccion<ModeloDeDominio.Articulo>();
                }
                return articulos as Coleccion<T>;
            }


            return null;
        }
    }
}
