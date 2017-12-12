using System;
using System.Collections.Generic;

namespace ModeloDeDominio
{
    public abstract class Venta :TipoBasico
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
        }
        public Venta(){ }


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
                
                /*List<LineaDeVenta> aux = new List<LineaDeVenta>();
                foreach(LineaDeVenta l in this.lineasDeVenta)
                {
                    aux.Add(l.copiar());
                }
                return aux;*/
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

        public abstract Venta copiar();

        public string Clave
        {
            get
            {
                return this.id;
            }
        }
    }
}
