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

            else
            {
                aux.Add(t);
                return true;
            }
            
            //borro las comprobaciones porque segun Vico es problema de la logica de negocio comprobar que existe
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

            else
            {
                aux.Remove(t.Clave);
                return true;
            }
            
            //borro las comprobaciones porque segun Vico es problema de la logica de negocio comprobar que existe
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
         */

        public static T get<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            Coleccion<T> aux = obtenerColeccion<T>(t);
            return (T) aux.item(t.Clave).copiar();
        }

        /*
         * Devuelve todos los elementos de una coleccion según el tipo pasado
         * Precondición: nada
         * Postcondición: devuelve la colección si los tipos coinciden, sino devuelve null;
         */

            //  REVISAR - DEBE DEVOLVER UNA COPIA, NO EL ORIGINAL

        public static List<T> getTodos<T>(T t) where T : ModeloDeDominio.TipoBasico
        {
            List<T> aux = new List<T>();
            Coleccion<T> original = obtenerColeccion<T>(t);
            foreach (T i in original)
            {
                aux.Add((T) i.copiar());
            }

            return aux;
        }

        



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




