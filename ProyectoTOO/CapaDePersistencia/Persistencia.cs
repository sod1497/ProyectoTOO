using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    public class Persistencia
    {

        //Todo debe devolver copias. Las clases básicas tienen un método copiar()

        //DUDA IMPORTANTE
        //Los objetos que se añaden no deberian ser copias tambien?, no vaya a ser que se modifique el 
        //objeto que esta guardado en un programa externo y se modifique tambien en la coleccion.

        //Servicios para dependientes

        public static bool anadirDependiente(Dependiente d)
        {
            //recorre la lista de dependientes
            //si el dependiente no esta en la lista lo añade y devuelve true
            //si está en la lista, devuelve false.
            foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
            {
                if (dependiente.NSS.Equals(d.NSS))
                {
                    return false;
                }
            }

            BaseDeDatos.Dependientes.Add(d);
            return true;
        }

        public static bool borrarDependiente(Dependiente d)
        {
            if (!BaseDeDatos.Dependientes.Remove(d))
            {
                foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
                {
                    if (dependiente.NSS.Equals(d.NSS))
                    {
                        BaseDeDatos.Dependientes.Remove(dependiente);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool contieneDependiente(Dependiente d)
        {
            foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
            {
                if (dependiente.NSS.Equals(d.NSS))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool darDeBajaDependiente(Dependiente d)
        {
            //no se preocupa de si el dependiente esta de alta o de baja, simplemente devuelve true si lo encuentra y lo da de baja
            //false en caso contrario

            foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
            {
                if (dependiente.NSS.Equals(d.NSS))
                {
                    dependiente.EstaActivo = false;
                    return true;
                }
            }
            return false;
        }

        public static bool darDeAltaDependiente(Dependiente d)
        {

            //no se preocupa de si el dependiente esta de alta o de baja, simplemente devuelve true si lo encuentra y lo da de alta
            //false en caso contrario

            foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
            {
                if (dependiente.NSS.Equals(d.NSS))
                {
                    dependiente.EstaActivo = true;
                    return true;
                }
            }
            return false;
        }

        public static Dependiente getDependiente(Dependiente d)
        {
            foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
            {
                if (dependiente.NSS.Equals(d.NSS))
                {
                    return dependiente.copiar();
                }
            }
            return null;
        }

        public static List<Dependiente> getDependientesTienda()
        {
            List<Dependiente> aux = new List<Dependiente>();
            foreach (Dependiente dependiente in BaseDeDatos.Dependientes)
            {
                aux.Add(dependiente.copiar());
            }
            return aux;
        }

        public static List<Venta> getVentasDeDependiente(Dependiente d, DateTime fecha)
        {
            //podemos pasarle el día 1 de un mes y año y que solo se fije en estos dos últimos
            //Por ejemplo le paso 1/enero/2017 y devuelve las ventas de enero/2017

            List<Venta> aux = new List<Venta>();

            foreach(Venta venta in BaseDeDatos.Ventas)
            {
                if(venta.Dependiente.NSS.Equals(d.NSS))
                {
                    DateTime auxF = venta.Fecha;

                    if (fecha.Month.Equals(auxF.Month) && fecha.Year.Equals(fecha.Year))
                    {
                        aux.Add(venta);
                    }
                }
            }

            return aux;
        }

        //Servicios para ventas

        public static bool anadirVenta(Venta v)
        {
            /*
             * Hago una copia antes de guardarlo, para que la clase que lo envió no pueda modificarlo
             */

            Venta aux = v.copiar();
            BaseDeDatos.Ventas.Add(aux);
            return true;
        }

        public static bool borrarVenta(Venta v)
        {
            if(!BaseDeDatos.Ventas.Remove(v))   //Si es distinta referencia compruebo el ID
            {
                foreach(Venta venta in BaseDeDatos.Ventas)
                {
                    if (venta.ID.Equals(v.ID))
                    {
                        BaseDeDatos.Ventas.Remove(venta);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Venta getVenta(Venta v)
        {
            foreach (Venta venta in BaseDeDatos.Ventas)
            {
                if (venta.ID.Equals(v.ID))
                {
                    BaseDeDatos.Ventas.Remove(venta);
                    return venta.copiar();
                }
            }
            return null;
        }

        public static List<Venta> getTodasVenta()
        {
            List<Venta> lista = new List<Venta>();
            foreach (Venta venta in BaseDeDatos.Ventas)
            {
                lista.Add(venta.copiar()); 
            }
            return lista;
        }

        //Servicios para artículos

        public static bool anadirArticulo(Articulo a)
        {
            foreach (Articulo articulo in BaseDeDatos.Articulos)
            {
                if (articulo.Id.Equals(a.Id))
                {
                    return false;
                }
            }

            BaseDeDatos.Articulos.Add(a);
            return true;
        }

        public static bool borrarArticulo(Articulo a)
        {
            if (!BaseDeDatos.Articulos.Remove(a))
            {
                foreach (Articulo articulo in BaseDeDatos.Articulos)
                {
                    if (articulo.Id.Equals(a.Id))
                    {
                        BaseDeDatos.Articulos.Remove(articulo);
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool darDeBajaArticulo(Articulo a)
        {
            foreach (Articulo articulo in BaseDeDatos.Articulos)
            {
                if (articulo.Id.Equals(a.Id))
                {
                    articulo.EstaActivo = false;
                    return true;
                }
            }
            return false;
        }

        public static bool darDeAltaArticulo(Articulo a)
        {
            foreach (Articulo articulo in BaseDeDatos.Articulos)
            {
                if (articulo.Id.Equals(a.Id))
                {
                    articulo.EstaActivo = true;
                    return true;
                }
            }
            return false;
        }

        public static Articulo getArticulo(Articulo a)
        {
            foreach (Articulo articulo in BaseDeDatos.Articulos)
            {
                if (articulo.Id.Equals(a.Id))
                {
                    return articulo.copiar();
                }
            }
            return null;
        }

        public static List<Articulo> getTodosArticulo()
        {
            List<Articulo> aux = new List<Articulo>();
            foreach (Articulo articulo in BaseDeDatos.Articulos)
            {
                aux.Add(articulo.copiar());
            }
            return aux;
        }

        public static List<Venta> getVentasDeArticulo(Articulo a)
        {
            List<Venta> aux = new List<Venta>();

            foreach(Venta venta in BaseDeDatos.Ventas)
            {

                //MIRAR!!!!!!!!!!!
                //Se supone que el break sale del segundo for
                //si no hace eso, entonces podemos estar añadiendo dos veces la misma venta
                //ademas de estar recorriendo toda las lineas de venta innecesariamente. INEFICIENTE!!!

                foreach(LineaDeVenta linea in venta.LineasDeVenta)
                {
                    if(linea.Articulo.Id.Equals(a.Id))
                    {
                        aux.Add(venta);
                        break;
                    }
                }

            }

            return aux;
        }
        
    }
}