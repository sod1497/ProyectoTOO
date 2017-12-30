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
        private static GestorDeClaves gestorDeClaves = new GestorDeClaves();

        public bool anadirVenta(Venta v)
        {
            if (!Persistencia<Venta>.existe(v))
            {
                Venta nueva;
                if(v is VentaConTarjeta)
                {
                    nueva = new VentaConTarjeta(gestorDeClaves.NuevaClave(), v.Fecha, v.Dependiente, ((VentaConTarjeta)v).Tarjeta);
                                   }
                else
                {
                    nueva = new VentaSinTarjeta(gestorDeClaves.NuevaClave(), v.Fecha, v.Dependiente);
                                    }
                foreach (LineaDeVenta l in v.LineasDeVenta)
                {
                    nueva.anadirLineaVenta(l);
                }
                return Persistencia<Venta>.anadir(nueva);
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

        public List<Venta> getVentas()
        {
            return Persistencia<Venta>.getTodos();
        }

        public void cargarVentasEjemplo(int numero)
        {
            Venta venta;
            Random random = new Random();
            List<Dependiente> dependientes = Persistencia<Dependiente>.getTodos();
            List<Articulo> articulos = Persistencia<Articulo>.getTodos();

            for (int j = 0; j < numero; j++)
            {
                if (random.Next(0, 1) == 1)
                {
                    venta = new VentaConTarjeta("0", DateTime.Now, dependientes[random.Next(0, dependientes.Count - 1)], (random.Next(1000000000, 999999999)).ToString());
                }
                else
                {
                    venta = new VentaSinTarjeta("0", DateTime.Now, dependientes[random.Next(0, dependientes.Count - 1)]);
                }
                List<LineaDeVenta> lineas = new List<LineaDeVenta>();
                LineaDeVenta linea;
                for (int i = 0, n = random.Next(1, 20); i < n; i++)
                {
                    linea = new LineaDeVenta(articulos[random.Next(0, articulos.Count - 1)], random.Next(1, 10));
                    venta.anadirLineaVenta(linea);
                }
                anadirVenta(venta);
            }
        }

    }
}
