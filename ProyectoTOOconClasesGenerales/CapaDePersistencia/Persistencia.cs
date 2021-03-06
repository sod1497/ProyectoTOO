﻿using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    public class Persistencia<T> where T : TipoBasico
    {

        //Todo debe devolver copias. Las clases básicas tienen un método copiar()

        //Servicios para dependientes

        /*
         * Devuelve la colección de elementos extraida de la base de datos
         * Depende del tipo devolverá una u otra colección
         * Precondición: ninguna
         * Postcondición: se devuelve la colección si el tipo coincide con alguno de los definidos, sino
         *      devuelve null
         */

        public static Coleccion<T> obtenerColeccion()
        {
            return Singleton<T>.getColeccion() as Coleccion<T>;
        }

        /*
         * Añade un elemento a la colección correcta
         * Obtiene la colección y comprueba si ya está en ella
         * Precondición: ninguna
         * Postcondición: devuelve true si se ha añadido con éxito y false en caso contrario
         */

        public static bool anadir(T t)
        {
            //recorre la lista
            //si el t no esta en la lista lo añade y devuelve true
            //si está en la lista, devuelve false.

            Coleccion<T> aux = Persistencia<T>.obtenerColeccion();
            if (aux == null)
                return false;

            else
            {
                try
                {
                    aux.Add(t);
                    return true;
                }catch(ArgumentException)
                {
                    return false;
                }
            }
            
            //borro las comprobaciones porque segun Vico es problema de la logica de negocio comprobar que existe
        }

        /*
         * Reemplaza la instancia vieja por la nueva
         * Precondición: el elemento t es no nulo y tiene la misma clave que el elemento a modificar
         * Postcondición: t se emplaza en el elemento que tenía la misma clave que él
         */

        public static bool modificar(T t)
        {
            Coleccion<T> aux = Persistencia<T>.obtenerColeccion();
            if (aux == null)
                return false;

            else
            {
                int i = aux.IndexOf(t);
                aux.SetItem(i,t);
                return true;
            }

        }

        /*
         * Elimina un elemento de una colección
         * Precondición: t es no nulo y tiene la misma clave que el elemento a borrar
         * Postcondición: devuelve true si existía y se ha eliminado y false en cualquier otro caso
         */

        public static bool borrar(T t)
        {
            Coleccion<T> aux = Persistencia<T>.obtenerColeccion();
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
         * Precondición: t es no nulo y tiene la clave del elemento a buscar
         * Postcondición: devuelve true si coincide, y false en caso contrario
         */

        public static bool existe(T t)
        {
            Coleccion<T> aux = Persistencia<T>.obtenerColeccion();
            if (aux == null)
                return false;

            return aux.Contains(t.Clave);
        }

        /*
         * Devuelve un elemento concreto identificado por su clave
         * Precondición: t es no nulo y tiene la clave del elemento a buscar
         * Postcondición: devuelve el elemento o exepción
         */

        public static T get(T t)
        {
            Coleccion<T> aux = Persistencia<T>.obtenerColeccion();
            return (T) aux.Item(t.Clave).copiar();
        }

        /*
         * Devuelve todos los elementos de una coleccion según el tipo pasado
         * Precondición: nada
         * Postcondición: devuelve la colección si los tipos coinciden, sino devuelve null;
         */
         

        public static List<T> getTodos()
        {
            List<T> aux = new List<T>();
            Coleccion<T> original = Persistencia<T>.obtenerColeccion();
            foreach (T i in original)
            {
                aux.Add((T) i.copiar());
            }

            return aux;
        }
        

        /*
         * Devuelve una Lista con las ventas de un mes/año concretos de un dependiente
         * Precondicion: d es no nulo y tiene la clave del dependiente a buscar
         * Postcondición: devuelve una lista con los valores que cumplan las condiciones. sino saldrá vacía
         */


        public static List<Venta> getVentasDeDependiente(Dependiente d, DateTime fecha)
        {
            //podemos pasarle el día 1 de un mes y año y que solo se fije en estos dos últimos
            //Por ejemplo le paso 1/enero/2017 y devuelve las ventas de enero/2017

            //Podría separar en varias clases de persistencia, pero así no cambia la interfaz y el código ya hecho 
            //no se ve afectado

            Persistencia<Venta> persistenciaVenta = new Persistencia<Venta>();
            Persistencia<Dependiente> persistenciaDependiente = new Persistencia<Dependiente>();

            List<Venta> aux = new List<Venta>();

            foreach (Venta venta in Singleton<Venta>.getColeccion())
            {
                if (venta.Dependiente.Clave.Equals(d.Clave))    //hay que buscar al dependiente por la clave, no por el NSS(pues podria cambiar a identificacion por nombre, por ej)
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
        * Precondición a es no nulo y tiene la clave del elemento a buscar
        * Postcondición: lista con los elementos que cumplen la condición
        */

        public static List<Venta> getVentasDeArticulo(Articulo a)
        {
            List<Venta> aux = new List<Venta>();

            foreach (Venta venta in Singleton<Venta>.getColeccion())
            {

                //MIRAR!!!!!!!!!!! - En teoría funciona bien
                //Se supone que el break sale del segundo for
                //si no hace eso, estará recorriendo toda las lineas de venta innecesariamente. INEFICIENTE!!!

                foreach (LineaDeVenta linea in venta.LineasDeVenta)
                {
                    if (linea.Articulo.Clave.Equals(a.Clave))   //hay que buscar al articulo por la clave, no por el ID(pues podria cambiar a identificacion por nombre, por ej)
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




