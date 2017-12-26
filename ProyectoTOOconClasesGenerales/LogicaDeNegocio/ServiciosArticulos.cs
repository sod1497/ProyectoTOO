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
        public bool anadirArticulo(Articulo a)
        {
            if (!Persistencia<Articulo>.existe(a))
            {
                return Persistencia<Articulo>.anadir(a);
            }
            else
            {
                return false;
            }
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

        public List<Articulo> getTodosArticulos()
        {
            return Persistencia<Articulo>.getTodos(new Articulo());
        }

        public bool existeArticulo(Articulo v)
        {
            return Persistencia<Articulo>.existe(v);
        }

        public bool existeArticulo(String v)
        {
            return Persistencia<Articulo>.existe(new Articulo(v,"",0,0));
        }
    }
}
