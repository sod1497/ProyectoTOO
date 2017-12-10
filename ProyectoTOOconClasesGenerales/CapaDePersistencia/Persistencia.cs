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
        public static object BaseDeDatos { get; private set; }

        //Todo debe devolver copias. Las clases básicas tienen un método copiar()

        //Servicios para dependientes


        
        public static Coleccion<T> obtenerColeccion<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux;

            if (t is Dependiente)
            {
                aux = CapaDePersistencia.BaseDatos.get<Dependiente>(new Dependiente()) as Coleccion<T>;
            }
            else if (t is Venta)
            {
                aux = CapaDePersistencia.BaseDatos.get<Venta>(new VentaSinTarjeta()) as Coleccion<T>;
            }
            else if (t is Articulo)
            {
                aux = CapaDePersistencia.BaseDatos.get<Articulo>(new Articulo()) as Coleccion<T>;
            }

            return null;
        }



        public static bool anadir<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            //recorre la lista
            //si el t no esta en la lista lo añade y devuelve true
            //si está en la lista, devuelve false.

            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            foreach (T tipo in aux)
            {
                if (tipo.clave.Equals(t.clave))
                {
                    aux.Add(t);
                    return true;
                }
            }

            return false;
        }


        public static bool borrar<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            foreach (T tipo in aux)
            {
                if (tipo.clave.Equals(t.clave))
                {
                    aux.Remove(t);
                    return true;
                }
            }

            return false;
        }


        public static bool existe<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;


            foreach (T tipo in aux)
            {
                if (tipo.clave.Equals(t.clave))
                {
                    return true;
                }
            }

            return false;
        }

        public static T get<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                throw new Exception();


            foreach (T tipo in aux)
            {
                if (tipo.clave.Equals(t.clave))
                {
                    return tipo;
                }
            }

            throw new Exception("No existe");
        }

        public static Coleccion<T> getTodos<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            return obtenerColeccion<T>(t);
        }


        public static bool darDeAlta<T>(T t) where T : ModeloDeDominio.TipoBasicoActivo
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;


            foreach (T tipo in aux)
            {
                if (tipo.clave.Equals(t.clave))
                {
                    tipo.EstaActivo = true;
                    return true;
                }
            }
            return false;
        }


        public static bool darDeBaja<T>(T t) where T : ModeloDeDominio.TipoBasicoActivo
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;


            foreach (T tipo in aux)
            {
                if (tipo.clave.Equals(t.clave))
                {
                    tipo.EstaActivo = false;
                    return true;
                }
            }
            return false;
        }
















        public static bool darDeBajaDependiente(Dependiente d)
        {
            //no se preocupa de si el dependiente esta de alta o de baja, simplemente devuelve true si lo encuentra y lo da de baja
            //false en caso contrario

            foreach (Dependiente dependiente in CapaDePersistencia.BaseDatos.get<Dependiente>(new Dependiente()))
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

            foreach (Dependiente dependiente in CapaDePersistencia.BaseDatos.get<Dependiente>(new Dependiente()))
            {
                if (dependiente.NSS.Equals(d.NSS))
                {
                    dependiente.EstaActivo = true;
                    return true;
                }
            }
            return false;
        }




        






        public static List<Venta> getVentasDeDependiente(Dependiente d, DateTime fecha)
        {
            //podemos pasarle el día 1 de un mes y año y que solo se fije en estos dos últimos
            //Por ejemplo le paso 1/enero/2017 y devuelve las ventas de enero/2017

            List<Venta> aux = new List<Venta>();

            foreach (Venta venta in CapaDePersistencia.BaseDatos.get<Venta>(new VentaSinTarjeta()))
            {
                if (venta.Dependiente.NSS.Equals(d.NSS))
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


        public static bool darDeBajaArticulo(Articulo a)
        {
            foreach (Articulo articulo in CapaDePersistencia.BaseDatos.get<Articulo>(new Articulo()))
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
            foreach (Articulo articulo in CapaDePersistencia.BaseDatos.get<Articulo>(new Articulo()))
            {
                if (articulo.Id.Equals(a.Id))
                {
                    articulo.EstaActivo = true;
                    return true;
                }
            }
            return false;
        }


        public static List<Venta> getVentasDeArticulo(Articulo a)
        {
            List<Venta> aux = new List<Venta>();

            foreach (Venta venta in CapaDePersistencia.BaseDatos.get<Venta>(new VentaSinTarjeta()))
            {

                //MIRAR!!!!!!!!!!!
                //Se supone que el break sale del segundo for
                //si no hace eso, entonces podemos estar añadiendo dos veces la misma venta
                //ademas de estar recorriendo toda las lineas de venta innecesariamente. INEFICIENTE!!!

                foreach (LineaDeVenta linea in venta.LineasDeVenta)
                {
                    if (linea.Articulo.Id.Equals(a.Id))
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




