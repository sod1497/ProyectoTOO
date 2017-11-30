using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    class BaseDeDatos //no es publico, es internal. Solo queremos que sea accesible desde el propio proyecto
    {
        private static ColeccionDependientes dependientes;
        private static ColeccionVentas ventas;
        private static ColeccionArticulos articulos;

        /*
         * Con esto podemos utilizar Dependientes, Ventas y Articulos como si 
         * fuesen tablas o listas pero con más métodos que simplifican su uso
         */

        public static ColeccionDependientes Dependientes
        {
            get
            {
                if (dependientes == null)
                {
                    dependientes = new ColeccionDependientes();
                }
                return dependientes;
            }
        }

        public static ColeccionVentas Ventas
        {
            get
            {
                if (ventas == null)
                {
                    ventas = new ColeccionVentas();
                }
                return ventas;
            }
        }

        public static ColeccionArticulos Articulos
        {
            get
            {
                if (articulos == null)
                {
                    articulos = new ColeccionArticulos();
                }
                return articulos;
            }
        }
    }
}
