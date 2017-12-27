
using ModeloDeDominio;
using System;
using System.Collections.Generic;

namespace ProyectoToo.Comparers
{
    public class ComparerDependienteNSS : IComparer<Dependiente>
    {
        public int Compare(Dependiente x, Dependiente y)
        {
            return String.Compare(x.NSS, y.NSS);
        }
        
    }

    public class ComparerDependienteNombre : IComparer<Dependiente>
    {
        public int Compare(Dependiente x, Dependiente y)
        {
            int i = String.Compare(x.Apellidos, y.Apellidos);
            if(i==0)
            {
                return String.Compare(x.Nombre, y.Nombre);
            }
            else
            {
                return i;
            }
        }
    }

    public class ComparerDependienteComision : IComparer<Dependiente>
    {
        public int Compare(Dependiente x, Dependiente y)
        {
            return (x.ComisionPorVenta - y.ComisionPorVenta) < 0 ? -1:1;
        }

    }
}
