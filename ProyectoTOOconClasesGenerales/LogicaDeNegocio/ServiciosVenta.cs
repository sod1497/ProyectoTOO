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
            return Persistencia.anadir(v);
        }
        Venta getVenta(Venta v)
        {
            return Persistencia.get(v);
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
