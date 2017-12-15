using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using CapaDePersistencia;

namespace Servicios
{
    class ServiciosArticulos
    {
        public bool anadirArticulo(Articulo a)
        {
            if (!Persistencia.existe(a))
            {
                return Persistencia.anadir(a);
            }
            else
            {
                return false;
            }
        }

        public bool borrarArticulo(Articulo a)
        {
            if (Persistencia.existe(a))
            {
                return Persistencia.borrar(a);
            }
            else
            {
                return false;
            }
            
        }

/*
        public bool darDeAltaArticulo(Articulo a)
        {
           // if (Persistencia.contieneArticulo(d))
           // {
                if (a.EstaActivo)
                {
                    return true;
                }
                else
                {
                    return Persistencia.darDeAlta(a);
                }
           /* }
            else
            {
                return false;
            } HACER CONTIENEARTICULO EN PERSISTENCIA? /
        }

        public bool darDeBajaArticulo(Articulo a)
        {
            // if (Persistencia.contieneArticulo(d))
            // {
                if (a.EstaActivo)
                {
                    return true;
                }
                else
                {
                    return Persistencia.darDeBaja(a);
                }
            /* }
            else
            {
                return false;
            } HACER CONTIENEARTICULO EN PERSISTENCIA? /
        }

 */
        public Articulo getArticulo(Articulo a)
        {
            if (Persistencia.existe(a))
            {
                return Persistencia.get(a);
            }
            else
            {
                return null;
            }
           
        }

        public List<Articulo> getTodosArticulos()
        {
            return Persistencia.getTodos(new Articulo());
        }
    }
}
