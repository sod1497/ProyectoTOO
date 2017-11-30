using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    
    class BaseDeDatos //no es publico, es internal
    {
        private static ColeccionDependientes dependientes;
        private static ColeccionDependientes ventas;
        private static ColeccionDependientes articulos;

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

        public static ColeccionDependientes Ventas
        {
            get
            {
                if (ventas == null)
                {
                    ventas = new ColeccionDependientes();
                }
                return ventas;
            }
        }

        public static ColeccionDependientes Articulos
        {
            get
            {
                if (articulos == null)
                {
                    articulos = new ColeccionDependientes();
                }
                return articulos;
            }
        }
    }
}
