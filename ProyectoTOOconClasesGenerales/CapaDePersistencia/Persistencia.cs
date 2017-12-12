using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        /*
         * Devuelve la colección de elementos extraida de la base de datos
         * Depende del tipo devolverá una u otra colección
         * Precondición: ninguna
         * Postcondición: se devuelve la colección si el tipo coincide con alguno de los definidos, sino
         *      devuelve null
         */
        
        public static Coleccion<T> obtenerColeccion<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = null;

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

            return aux;
        }

        /*
         * Añade un elemento a la colección correcta
         * Obtiene la colección y comprueba si ya está en ella
         * Precondición: ninguna
         * Postcondición: devuelve true si se ha añadido con éxito y false en caso contrario
         */

        public static bool anadir<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            //recorre la lista
            //si el t no esta en la lista lo añade y devuelve true
            //si está en la lista, devuelve false.

            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            if(!aux.Contains(t.Clave))
            {
                aux.Add(t);
                return true;
            }

            return false;
        }

        /*
         * Elimina un elemento de una colección
         * Precondición: ninguna
         * Postcondición: devuelve true si existía y se ha eliminado y false en cualquier otro caso
         * 
         */

        public static bool borrar<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            if(aux.Contains(t.Clave))
            {
                aux.Remove(t.Clave);
                return true;
            }

            return false;
        }

        /*
         * Indica si un elemento está en la colección
         * Precondición: ninguna
         * Postcondición: devuelve true si coincide, y false en caso contrario
         */

        public static bool existe<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            return aux.Contains(t.Clave);
        }

        /*
         * Devuelve un elemento concreto identificado por su clave
         * Precondición: el elemento está en la base de datos
         * Postcondición: devuelve el elemento o exepción
         * Lanza:
         * -ArgumentNullException si t.Clave es null
         * -NullPointerException si aux es null
         * -KeyNotFoundException si no existe el objeto
         */

        public static T get<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            return aux.item(t.Clave);
        }

        /*
         * Devuelve todos los elementos de una coleccion según el tipo pasado
         * Precondición: nada
         * Postcondición: devuelve la colección si los tipos coinciden, sino devuelve null;
         */

        public static Coleccion<T> getTodos<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            return obtenerColeccion<T>(t);
        }

        /*
         * Da de alta un objeto, es decir, lo pone como activo
         * Precondición: ninguna
         * Postcondición: devuelve true si se ha podido actualizar el valor
         */


        public static bool darDeAlta<T>(T t) where T : ModeloDeDominio.TipoBasicoActivo
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            try
            {
                aux.item(t.Clave).EstaActivo = true;
                return true;
            } catch(Exception)
            {
                return false;
            }

            /*  Para usar la KeyedCollection he añadido el otro método por si nos dice algo
            foreach (T tipo in aux)
            {
                if (tipo.Clave.Equals(t.Clave))
                {
                    tipo.EstaActivo = true;
                    return true;
                }
            }

            return false;

            */
        }

        /*
         * Da de alta un objeto, es decir, lo pone como activo
         * Precondición: ninguna
         * Postcondición: devuelve true si se ha podido actualizar el valor
         */

        public static bool darDeBaja<T>(T t) where T : ModeloDeDominio.TipoBasicoActivo
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            if (aux == null)
                return false;

            try
            {
                aux.item(t.Clave).EstaActivo = false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            /*
            foreach (T tipo in aux)
            {
                if (tipo.Clave.Equals(t.Clave))
                {
                    tipo.EstaActivo = false;
                    return true;
                }
            }
            return false;*/
        }














        /*

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

    */


        



        /*
         * Devuelve una Lista con las ventas de un mes/año concretos de un dependiente
         * Precondicion: ninguna
         * Postcondición: devuelve una lista con los valores que cumplan las condiciones. sino saldrá vacía
         */


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

        /*

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

    */

    /*
        * Devuelve una lista con las ventas de un artículo
        * Precondición ninguna
        * Postcondición: lista con los elementos que cumplen la condición
        */

        public static List<Venta> getVentasDeArticulo(Articulo a)
        {
            List<Venta> aux = new List<Venta>();

            foreach (Venta venta in CapaDePersistencia.BaseDatos.get<Venta>(new VentaSinTarjeta()))
            {

                //MIRAR!!!!!!!!!!! - En teoría funciona bien
                //Se supone que el break sale del segundo for
                //si no hace eso, estará recorriendo toda las lineas de venta innecesariamente. INEFICIENTE!!!

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




