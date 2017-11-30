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

        bool anadirVentaConTarjeta(VentaConTarjeta v)
        {
            return Persistencia.anadirVentaConTarjeta(v);
        }
        bool anadirVentaSinTarjeta(VentSionTarjeta v)
        {
            return Persistencia.anadirVentaSinTarjeta(v);
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
