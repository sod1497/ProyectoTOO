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
            return Persistencia.anadir(a);
        }

        public bool borrarArticulo(Articulo a)
        {
            return Persistencia.borrar(a);
        }

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
            } HACER CONTIENEARTICULO EN PERSISTENCIA? */
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
            } HACER CONTIENEARTICULO EN PERSISTENCIA? */
        }
        public Articulo getArticulo(Articulo a)
        {
            return Persistencia.get(a);
        }

        public Coleccion<Articulo> getTodosArticulos()
        {
            return Persistencia.getTodos(new Articulo());
        }
    }
}
