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
            //if (!Persistencia.contieneDependiente(d))
            //{
                //PASAR A PERSISTENCIA
                /*List<Dependiente> dependientes = Persistencia.getDependientesTienda();
                foreach (Dependiente x in dependientes)
                {
                    if (x.NSS == d.NSS)
                    {
                        return false;
                    }
                }*/
                return Persistencia.anadir(d);
            //}
            /*else
            {
                return false;
            }*/
        }

        //devuelve true si borra el dependiente correctamente
        //y false si no encuentra el dependiente o no lo borra correctamente
        public bool borrarDependiente(Dependiente d)
        {
            //PASAR A PERSISTENCIA
            /*List<Dependiente> dependientes = Persistencia.getDependientesTienda();
            foreach (Dependiente x in dependientes)
            {
                if (x.NSS == d.NSS)
                {*/
                    return Persistencia.borrar(d);
            /*    }
            }
            return false;*/
        }

        //devuelve true si ya esta activo o lo ha puesto activo
        //y false se ha habido un error al activarlo
        public bool darDeAltaDependiente(Dependiente d)
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
        }

        //devuelve true si no esta activo o lo ha puesto inactivo
        //y false se ha habido un error al inactivarlo
        public bool darDeBajaDependiente(Dependiente d)
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
            
        }

        //devuelve un dependiente dado el NSS
        public Dependiente getDependiente(Dependiente d)
        {
            return Persistencia.get(d);
        }

        //si no existe el nombre introducido, devuelve null
        //si hay más de un cliente con el mismo nombre, los devuelve todos
        public List<string> getNSS(Dependiente d)
        {
            //PASAR A PERSISTENCIA ??
            if (Persistencia.existe(d))
            {
                List<string> NSSs = new List<string>();
                Coleccion<Dependiente> dependientes = Persistencia.getTodos(new Dependiente());
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
        public float calcularComision(Dependiente d)
        {
            float comisionTotal = 0; 
            List<Venta> ventas = Persistencia.getVentasDeDependiente(d, new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day) /*fecha*/);
            foreach(Venta x in ventas)
            {
                comisionTotal += d.ComisionPorVenta;
            }

            return comisionTotal;
        }

        public List<Venta> obtenerVentasMes(Dependiente d , DateTime fecha)
        {
            return Persistencia.getVentasDeDependiente(d, fecha);
        }

        public Coleccion<Dependiente> getDependientesTienda()
        {
            return Persistencia.getTodos(new Dependiente());
        }
    }
}
