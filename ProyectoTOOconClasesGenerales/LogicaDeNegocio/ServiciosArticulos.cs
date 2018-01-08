using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using CapaDePersistencia;

namespace LogicaDeNegocio
{
    public class ServiciosArticulos
    {

        /*
         * Recibe un articulo con una clave cualquiera y lo inserta con una nueva clave en el sistema
         * La gestion de claves la realiza el sistema, no el usuario
         * Precondición: a es no nulo y es el elemento a añadir
         * Postcondición: se devuelve un booleano que indica el resultado de la operación
         */
        public bool anadirArticulo(Articulo a)
        {
            a = new Articulo(GestorDeClaves.NuevaClave(), a.Descripcion, a.CosteFabrica, a.IVA);
            return Persistencia<Articulo>.anadir(a);
        }

        /*
         * Utiliza la clave del original y los datos del elemento nuevo para modificar los datos del 
         * guardado en la capa de persistencia
         * Precondición: original y nuevo son no nulos. original tiene la clave del elemento a modificar y nuevo
         * tiene la misma clave y los datos nuevos
         * Postcondición: se devuelve un booleano que indica el resultado de la operación
         */
        public bool modificarArticulo(Articulo original, Articulo nuevo)
        {
            Articulo d = getArticulo(original);

            if (d != null && original.Clave == nuevo.Clave)
            {
                return Persistencia<Articulo>.modificar(nuevo);
            }
            else
            {
                return false;
            }
        }

        /*
         * Recibe los datos nuevos y la clave del elemento a modificar
         * Precondición: Los valores de nombre, coste e iva cumplen la especificación
         * Postcondición: se devuelve un booleano que indica el resultado de la operación
         */
        public bool modificarArticulo(String clave, String nombre, float coste, int iva)
        {
            return modificarArticulo(new Articulo(clave, "", 0, 0), new Articulo(clave, nombre, coste, iva));
        }

        /*
         * Borra el artículo con la misma clave que a
         * Precondición: a es no nulo y tiene la clave del elemento a borrar
         * Postcondición: se devuelve un booleano que indica el resultado de la operación
         */
        public bool borrarArticulo(Articulo a)
        {
            if (Persistencia<Articulo>.existe(a))
            {
                return Persistencia<Articulo>.borrar(a);
            }
            else
            {
                return false;
            }
            
        }

        /*
         * Llama a borrarArticulo con la clave solamente
         * Precondición: ninguna
         * Postcondición: se devuelve un booleano que indica el resultado de la operación
         */
        public bool borrarArticulo(String s)
        {
            return borrarArticulo(new Articulo(s, "", 0, 0));
        }

        /*
         * Devuelve el artículo con misma clave que a
         * Precondición: a es no nulo y tiene la clave del elemento a extraer
         * Postcondición: se devuelve el artículo encontrado o null
         */
        public Articulo getArticulo(Articulo a)
        {
            if (Persistencia<Articulo>.existe(a))
            {
                return Persistencia<Articulo>.get(a);
            }
            else
            {
                return null;
            }
           
        }

        /*
         * Llama a getArticulo con solo la cadena
         * Precondición: ninguna
         * Postcondición: se devuelve el artículo encontrado o null
         */
        public Articulo getArticulo(String a)
        {
            return getArticulo(new Articulo(a, "", 0, 0));
        }

        /*
         * Devuleve una lista con todos los artículos
         * Precondición: ninguna
         * Postcondición: se devuelve la lista
         */
        public List<Articulo> getTodosArticulos()
        {
            return Persistencia<Articulo>.getTodos();
        }

        /*
         * Indica si existe un articulo con misma clave que v
         * Precondición: v es no nulo y tiene la clave del elemento a buscar
         * Postcondición: se devuelve un booleano que indica si existe
         */
        public bool existeArticulo(Articulo v)
        {
            return Persistencia<Articulo>.existe(v);
        }

        /*
         * Llama a existeArticulo con la clave solamente
         * Precondición: ninguna
         * Postcondición: se devuelve un booleano que indica si existe
         */
        public bool existeArticulo(String v)
        {
            return Persistencia<Articulo>.existe(new Articulo(v,"",0,0));
        }

        /*
         * Crea valores aleatorios para pruebas
         */
        public void cargarArticulosEjemplo(int count)
        {
            Articulo aux;
            Random random = new Random();
            String[] descripcion = { "Caja", "Cubo", "Frasco", "Botella", "Jarra", "Chuches" ,"Dulce", "Dispositivo", "Mueble", "Mobiliario","Menaje","Bebida", "Herramienta"};
            if (count < 1) count = 10;
            for (int i = 0; i < count; i++)
            {
                long l;
                long.TryParse(random.Next(100000000, 999999999).ToString(), out l);
                aux = new Articulo("0", descripcion[random.Next(0, descripcion.Length - 1)], random.Next(1, 200), 21);
                anadirArticulo(aux);
            }
        }
    }
}
