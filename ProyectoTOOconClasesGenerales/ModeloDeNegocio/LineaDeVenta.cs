

namespace ModeloDeDominio
{
    public class LineaDeVenta
    {

        private Articulo articulo; 
        private int cantidad;
    //private double importe; no se guarda, se calcula cada vez

        public LineaDeVenta(Articulo articulo, int cantidad)
        {
            this.articulo = articulo;
            this.cantidad = cantidad;
        }

        public Articulo Articulo
        {
            get
            {
                return this.articulo;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public double Importe
        {
            get
            {
                return this.Cantidad * this.Articulo.Importe;
            }
        }

        

        public LineaDeVenta copiar()
        {
            return new LineaDeVenta((Articulo) this.Articulo.copiar(), this.Cantidad);
        }

    }
}
