using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDominio;

namespace LogicaDeNegocio
{
    public class ServiciosVenta
    {

        bool anadirVenta(Venta v)
        {
            return Persistencia.anadirVenta(v);
        }
        bool anadirLineaVenta(LineaDeVenta l, Venta v)
        {
            return Persistencia.anadirLineaVenta(l, v);
        }
        Venta getVenta(Venta v)
        {
            return Persistencia.getVenta(v);
        }
        List<LineaDeVenta> getLineasVenta(Venta v)
        {
            return Persistencia.getLineasVenta(v);
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
