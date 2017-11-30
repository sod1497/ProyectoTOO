using System;
using System.Collections.Generic;

namespace ModeloDominio
{
    public abstract class Venta
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

        

    }
}
