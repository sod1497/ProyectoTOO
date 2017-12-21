using CapaDePersistencia;
using LogicaDeNegocio;
using ModeloDeDominio;
using System;
using System.Collections.Generic;


namespace CapaDePresentacionConsola
{
    class Program
    {
        static int idVenta = 0;
        static int idArticulo = 0;

        static void Main(string[] args)
        {
            //Para probar dependientes
            Console.WriteLine("Inicio");
            addDepend();
            addDepend();
            addDepend();
            mostrarDepend();

            //Para probar articulos
            addArt();
            addArt();
            addArt();

            mostrarArt();

            //Para probar ventas

            addVenta();
            addVenta();
            addVenta();

            mostrarVenta();





            Console.WriteLine("Pulsa intro para salir");
            Console.ReadLine();
        }

        public static void addDepend()
        {
            Console.WriteLine("Añadir dependiente");
            Console.WriteLine("-NSS");
            String a = Console.ReadLine();
            Console.WriteLine("-Nombre");
            String b = Console.ReadLine();
            Console.WriteLine("-Apellidos");
            String c = Console.ReadLine();

            Console.WriteLine(Persistencia<Dependiente>.anadir(new Dependiente(a, b, c, 0)) ? "Hecho" : "Error");
        }

        public static void mostrarDepend()
        {
            Console.WriteLine("Mostrar dependiente");
            Console.WriteLine("-NSS");
            Dependiente d = getDepend(Console.ReadLine());
            Console.WriteLine("NSS " + d.NSS + ", Nombre " + d.Nombre + ", Apellidos " + d.Apellidos + " y comisión " + d.ComisionPorVenta);

        }

        public static Dependiente getDepend(String a)
        {
            return Persistencia<Dependiente>.get(new Dependiente(a, "", "", 0));
        }

        public static void addArt()
        {
            Console.WriteLine("Añadir articulo");
            Console.WriteLine("-Descripcion");
            String b = Console.ReadLine();
            

            Console.WriteLine(new ServiciosArticulos().anadirArticulo(new Articulo(++idArticulo+"",b,10,21)) ? "Añadido con id "+idArticulo : "Error");
        }

        public static Articulo getArt(String e)
        {
            return new ServiciosArticulos().getArticulo(new Articulo(e,"",0,0));
        }

        public static void mostrarArt()
        {
            Console.WriteLine("Mostrar articulo");
            Console.WriteLine("-ID");
            Articulo d = getArt(Console.ReadLine());
            Console.WriteLine("ID " + d.Id + ", Descripcion " + d.Descripcion + ", Coste " + d.CosteFabrica);

        }

        public static void addVenta()
        {
            Console.WriteLine("Añadir venta");
            Console.WriteLine("-NSS de dependiente");
            String e = Console.ReadLine();
            Dependiente d = getDepend(e);


            Console.WriteLine(new ServiciosVenta().anadirVenta(new VentaSinTarjeta(++idVenta+"",DateTime.Now,d)) ? "Hecho con id "+idVenta : "Error");
        }

        public static List<LineaDeVenta> addLineas()
        {
            List<LineaDeVenta> aux = new List<LineaDeVenta>();

            Console.WriteLine("-Articulo 1");
            String e = Console.ReadLine();
            Console.WriteLine("-Cantidad");
            int f;
            int.TryParse(Console.ReadLine(),out f);
            Articulo a = getArt(e);
            aux.Add(new LineaDeVenta(a, f));

            Console.WriteLine("-Articulo 2");
            e = Console.ReadLine();
            Console.WriteLine("-Cantidad");
            int.TryParse(Console.ReadLine(), out f);
            a = getArt(e);
            aux.Add(new LineaDeVenta(a, f));

            return aux;
        }

        public static void mostrarLin(LineaDeVenta l)
        {
            Console.WriteLine("--Articulo-- "+l.Articulo.Id+" "+l.Articulo.Descripcion);
            Console.WriteLine("--Cantidad-- " + l.Cantidad);
            
        }

        public static void mostrarVenta()
        {
            Console.WriteLine("Mostrar venta");
            Console.WriteLine("-ID");
            Venta d = getVenta(Console.ReadLine());
            Console.WriteLine("ID " + d.ID + ", Nombre " + d.Fecha + ", Apellidos " + d.ImporteTotal);

            //Mostrar lineas
            foreach(LineaDeVenta l in d.LineasDeVenta)
            {
                mostrarLin(l);
            }

        }

        private static Venta getVenta(string v)
        {
            throw new NotImplementedException();
        }
    }
}
