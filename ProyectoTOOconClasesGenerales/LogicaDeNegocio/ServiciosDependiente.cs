using CapaDePersistencia;
using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class ServiciosDependiente
    {
        //devuelve true si guarda el dependiente
        //y false si el dependiente ya existe o ha habido un error al añadirlo
        public bool anadirDependiente(Dependiente d)
        {
            if (!Persistencia<Dependiente>.existe(d))
            {
                return Persistencia<Dependiente>.anadir(d);
            }
            else
            {
                return false;
            }
        }

        //devuelve true si borra el dependiente correctamente
        //y false si no encuentra el dependiente o no lo borra correctamente
        public bool borrarDependiente(Dependiente d)
        {
            if (Persistencia<Dependiente>.existe(d))
            {
                return Persistencia<Dependiente>.borrar(d);
            }
            else
            {
                return false;
            }
        }

        //devuelve true si ya esta activo o lo ha puesto activo
        //y false se ha habido un error al activarlo
       /*public bool darDeAltaDependiente(Dependiente d)
        {
            if (Persistencia.existe(d))
            {
                if (d.EstaActivo)
                {
                    return true;
                }
                else
                {
                    return Persistencia.darDeAlta(d);
                }
            }
            else
            {
                return false;
            }
        }*/

        //devuelve true si no esta activo o lo ha puesto inactivo
        //y false se ha habido un error al inactivarlo
        /*public bool darDeBajaDependiente(Dependiente d)
        {
            if (Persistencia.existe(d))
            {
                if (!d.EstaActivo)
                {
                    return true;
                }
                else
                {
                    return Persistencia.darDeBaja(d);
                }
            }
            else
            {
                return false;
            }
            
        }*/

        //devuelve un dependiente dado el NSS
        public Dependiente getDependiente(Dependiente d)
        {
            if (Persistencia<Dependiente>.existe(d))
            {
                return Persistencia<Dependiente>.get(d);
            }
            else
            {
                return null;
            }
            
        }

        //si no existe el nombre introducido, devuelve null
        //si hay más de un cliente con el mismo nombre, los devuelve todos
        public List<string> getNSS(Dependiente d)
        {
            if (Persistencia<Dependiente>.existe(d))
            {
                List<string> NSSs = new List<string>();
                List<Dependiente> dependientes = Persistencia<Dependiente>.getTodos(d);
                foreach (Dependiente x in dependientes)
                {
                    if (x.Nombre.Equals(d.Nombre))
                    {
                        NSSs.Add(x.NSS);
                    }
                }
                return NSSs;
            }
            else
            {
                return null;
            }
            
        }

        //a partir de las ventas de ese dependiente (este mes), y de la comision que se 
        //lleva por cada una, calcula la comision total
        public float calcularComision(Dependiente d , DateTime date)
        {
            float comisionTotal = 0; 
            List<Venta> ventas = Persistencia<Dependiente>.getVentasDeDependiente(d, date);
            foreach(Venta x in ventas)
            {
                comisionTotal += d.ComisionPorVenta;
            }

            return comisionTotal;
        }

        public List<Venta> obtenerVentasMes(Dependiente d , DateTime fecha)
        {
            return Persistencia<Dependiente>.getVentasDeDependiente(d, fecha);
        }

        public List<Dependiente> getDependientesTienda()
        {
            return Persistencia<Dependiente>.getTodos(new Dependiente());
        }
    }
}
