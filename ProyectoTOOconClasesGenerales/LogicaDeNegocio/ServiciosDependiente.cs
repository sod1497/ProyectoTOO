using CapaDePersistencia;
using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
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

        public bool modificarDependiente(Dependiente original, Dependiente nuevo)
        {
            Dependiente d = getDependiente(original);

            if (d != null && original.Clave == nuevo.Clave)
            {
                return Persistencia<Dependiente>.modificar(nuevo);
            }
            else
            {
                return false;
            }
        }

        public bool modificarDependiente(String clave, String nombre, String apellidos, int comision)
        {
            return modificarDependiente(new Dependiente(clave, "", "", 0), new Dependiente(clave, nombre, apellidos, comision));
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

        public bool borrarDependiente(String d)
        {
            return borrarDependiente(new Dependiente(d, "", "", 0));
        }

        //Devuelve true si existe el dependiente con clave "clave"
        public bool existeDependiente(string clave)
        {
            return existeDependiente(new Dependiente(clave, "", "", 0));
        }

        //devuelve un bool indicando si existe el dependiente
        public bool existeDependiente(Dependiente d)
        {
            return Persistencia<Dependiente>.existe(d);
        }

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

        //Usando solo la clave
        public Dependiente getDependiente(String clave)
        {
            return getDependiente(new Dependiente(clave, "", "", 0));
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
        public double calcularComision(Dependiente d, DateTime date)
        {
            double comisionTotal = 0;
            List<Venta> ventas = Persistencia<Venta>.getVentasDeDependiente(d, date);
            foreach (Venta v in ventas)
            {
                comisionTotal += v.ImporteTotal * d.ComisionPorVenta / 100;
            }

            return comisionTotal;
        }

        public List<Venta> obtenerVentasMes(Dependiente d, DateTime fecha)
        {
            return Persistencia<Dependiente>.getVentasDeDependiente(d, fecha);
        }

        public List<Dependiente> getDependientesTienda()
        {
            return Persistencia<Dependiente>.getTodos(new Dependiente());
        }

        public void cargarDependientesEjemplo()
        {
            Dependiente aux;
            Random random = new Random();
            String[] nombres = { "Paco", "Juan", "Francisca", "Juana", "Michael", "Donald" };
            String[] apellidos = { "Jimenez", "Larrea", "De Arco", "Martínez", "Jackson", "Duck" };
            for (int i = 0; i < nombres.Length; i++)
            {
                long l;
                long.TryParse(random.Next(100000000, 999999999).ToString(), out l);
                aux = new Dependiente((l * 100).ToString(), nombres[i], apellidos[i], i);
                anadirDependiente(aux);
            }
        }


    }
}
