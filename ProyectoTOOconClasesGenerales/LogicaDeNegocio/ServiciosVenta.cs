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
            return Persistencia.anadirVenta(v);
        }
        Venta getVenta(Venta v)
        {
            return Persistencia.getVenta(v);
        }

        List<Venta> getVentasDeArticulo(Articulo a)
        {
            return Persistencia.getVentasDeArticulo(a);
        }

        Dependiente getDependienteDeVenta(Venta v)
        {
            return v.Dependiente;
        }

    }
}
