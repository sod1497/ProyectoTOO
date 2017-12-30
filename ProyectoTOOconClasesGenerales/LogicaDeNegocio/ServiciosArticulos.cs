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
        //Gestiona las claves de los articulos
        private static GestorDeClaves gestorDeClaves = new GestorDeClaves();

        /*
         * Recibe un articulo con una clave cualquiera y lo inserta con una nueva clave en el sistema
         * La gestion de claves la realiza el sistema, no el usuario
         */
        public bool anadirArticulo(Articulo a)
        {
            a = new Articulo(gestorDeClaves.NuevaClave(), a.Descripcion, a.CosteFabrica, a.IVA);
            return Persistencia<Articulo>.anadir(a);
        }

        /*
         * Utiliza la clave del original y los datos del elemento nuevo para modificar los datos del 
         * guardado en la capa de persistencia
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
         */
        public bool modificarArticulo(String clave, String nombre, float coste, int iva)
        {
            return modificarArticulo(new Articulo(clave, "", 0, 0), new Articulo(clave, nombre, coste, iva));
        }

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

        public bool borrarArticulo(String s)
        {
            return borrarArticulo(new Articulo(s, "", 0, 0));
        }

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

        public Articulo getArticulo(String a)
        {
            return getArticulo(new Articulo(a, "", 0, 0));
        }

        public List<Articulo> getTodosArticulos()
        {
            return Persistencia<Articulo>.getTodos();
        }

        public bool existeArticulo(Articulo v)
        {
            return Persistencia<Articulo>.existe(v);
        }

        public bool existeArticulo(String v)
        {
            return Persistencia<Articulo>.existe(new Articulo(v,"",0,0));
        }

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
