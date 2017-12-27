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

        public bool anadirVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return Persistencia<Venta>.anadir(v);
            }
            return false;
            
        }

        public Venta getVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return Persistencia<Venta>.get(v);
            }
            return null;
        }

        public Venta getVenta(String v)
        {
            return getVenta(new VentaSinTarjeta(v, DateTime.Now, null));
        }

        public List<Venta> getVentasDeArticulo(Articulo a)
        {
            if(Persistencia<Articulo>.existe(a))
            {
                return Persistencia<Venta>.getVentasDeArticulo(a);
            }
            return null;
        }

        public List<Venta> getVentasDeArticulo(String a)
        {
            return getVentasDeArticulo(new Articulo(a, "", 0, 0));
        }

        public Dependiente getDependienteDeVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return v.Dependiente;
            }
            return null;
            
        }

        public Dependiente getDependienteDeVenta(String a)
        {
            return getDependienteDeVenta(new VentaSinTarjeta(a, DateTime.Now,null));
        }

        //devuelve true si borra la venta correctamente
        //y false si no encuentra la venta o no la borra correctamente
        public bool borrarVenta(Venta v)
        {
            if (Persistencia<Venta>.existe(v))
            {
                return Persistencia<Venta>.borrar(v);
            }
            else
            {
                return false;
            }
        }

        public bool borrarVenta(String v)
        {
            return borrarVenta(new VentaSinTarjeta(v, DateTime.Now, null));
        }

        public bool existeVenta(Venta v)
        {
            return Persistencia<Venta>.existe(v);
        }

        public bool existeVenta(String id)
        {
            return Persistencia<Venta>.existe(new VentaSinTarjeta(id,DateTime.Now,null));
        }

    }
}
