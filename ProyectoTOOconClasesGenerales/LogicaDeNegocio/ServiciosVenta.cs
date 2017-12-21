using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using CapaDePersistencia;

namespace LogicaDeNegocio
{
    public class ServiciosVenta
    {

        bool anadirVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return Persistencia<Venta>.anadir(v);
            }
            return false;
            
        }
        Venta getVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return Persistencia<Venta>.get(v);
            }
            return null;
        }

        List<Venta> getVentasDeArticulo(Articulo a)
        {
            if(Persistencia<Articulo>.existe(a))
            {
                return Persistencia<Venta>.getVentasDeArticulo(a);
            }
            return null;
        }

        Dependiente getDependienteDeVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return v.Dependiente;
            }
            return null;
            
        }

    }
}
