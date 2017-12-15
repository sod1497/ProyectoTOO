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
            if (Persistencia.existe(v))
            {
                return Persistencia.anadir(v);
            }
            return false;
            
        }
        Venta getVenta(Venta v)
        {
            if (Persistencia.existe(v))
            {
                return Persistencia.get(v);
            }
            return null;
        }

        List<Venta> getVentasDeArticulo(Articulo a)
        {
            if(Persistencia.existe(a))
            {
                return Persistencia.getVentasDeArticulo(a);
            }
            return null;
        }

        Dependiente getDependienteDeVenta(Venta v)
        {
            if (Persistencia.existe(v))
            {
                return v.Dependiente;
            }
            return null;
            
        }

    }
}
