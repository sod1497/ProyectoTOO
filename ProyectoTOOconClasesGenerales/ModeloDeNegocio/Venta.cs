using System;
using System.Collections.Generic;

namespace ModeloDeDominio
{
    public abstract class Venta :TipoBasico,IEquatable<Venta>
    {

        internal string id;
        internal DateTime fecha;
        internal Dependiente dependiente;
        internal List<LineaDeVenta> lineasDeVenta;

        public Venta(string id, DateTime fecha, Dependiente dependiente)
        {
            this.id = id;
            this.fecha = fecha;
            this.dependiente = dependiente;
            this.lineasDeVenta = new List<LineaDeVenta>();
        }

        public Venta()
        {
            this.lineasDeVenta = new List<LineaDeVenta>();
        }


        public string ID
        {
            get
            {
                return this.id;
            }
        }

        public List<LineaDeVenta> LineasDeVenta
        {
            get
            {
                return this.lineasDeVenta;
            }
        }

        public List<Articulo> Articulos
        {
            get
            {
                List<Articulo> articulos = new List<Articulo>();
                foreach (LineaDeVenta l in LineasDeVenta)
                {
                    articulos.Add(l.Articulo);
                }
                return articulos;
            }
        }

        /*
         * La venta, una vez añadida a la base de datos, no tiene sentido que se modifiquen sus líneas pues suponemos que la venta
         * ha finalizado para cuando se añada en la base de datos. Por eso en la capa de persistencia solo podemos añadir ventas
         * ya completas y no podemos añadir lineas de venta a ventas que ya están en la base de datos.
         */

        public bool anadirLineaVenta(LineaDeVenta l)
        {
            //Compruebo si ya contiene la línea. Si la contiene no añade nada
            foreach(LineaDeVenta lv in this.lineasDeVenta)
            {
                if(lv.Articulo.Id.Equals(l.Articulo.Id))
                {
                    return true;
                }
            }
            
            this.lineasDeVenta.Add(l);
            return true;
        }

        public abstract TipoBasico copiar();

        public bool Equals(Venta other)
        {
            return this.Clave == other.Clave;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }

        public Dependiente Dependiente
        {
            get
            {
                return this.dependiente;
            }
            set
            {
                this.dependiente = value;
            }
        }

        public double ImporteTotal
        {
            get
            {
                double imp=0;
                foreach(LineaDeVenta l in this.lineasDeVenta)
                {
                    imp += l.Importe;
                }
                return imp;
            }
        }
        
        public string Clave
        {
            get
            {
                return this.id;
            }
        }
    }
}
