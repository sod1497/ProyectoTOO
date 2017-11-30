using System;

namespace ModeloDominio
{
    public class Articulo
    {

        private string id;
        private string descripcion;
        private double costeFabrica;
        private int iva;
        private bool estaActivo;

        public Articulo(string id, string descripcion, double costeFabrica, int iva)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.costeFabrica = costeFabrica;
            this.iva = iva;
            this.estaActivo = true;
        }

        public bool EstaActivo
        {
            get
            {
                return this.estaActivo;
            }
            set
            {
                this.estaActivo = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }

        public Articulo copiar()
        {
            return new Articulo(this.Id, this.Descripcion, this.CosteFabrica, this.IVA);
        }

        public double CosteFabrica
        {
            get
            {
                return this.costeFabrica;
            }
            set
            {
                this.costeFabrica = value;
            }
        }

        public int IVA
        {
            get
            {
                return this.iva;
            }
            set
            {
                this.iva = value;
            }
        }

        public double Importe
        {
            get
            {
                return this.CosteFabrica * 1.2 * (100 + this.IVA) / 100;
            }
        }

    }
}
