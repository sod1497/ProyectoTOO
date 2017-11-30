namespace ModeloDominio
{
    public class Dependiente
    {

        private string nss;
        private string nombre;
        private string apellidos;
        private float comisionPorVenta;
        private bool estaActivo;

        public Dependiente(string nss, string nombre, string apellidos, float comision)
        {
            this.nss = nss;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.comisionPorVenta = comision;
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

        public string NSS
        {
            get
            {
                return this.nss;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return this.apellidos;
            }
            set
            {
                this.apellidos = value;
            }
        }

        public float ComisionPorVenta
        {
            get
            {
                return this.comisionPorVenta;
            }
            set
            {
                this.comisionPorVenta = value;
            }
        }

        public Dependiente copiar()
        {
            return new Dependiente(this.NSS, this.Nombre, this.Apellidos, this.ComisionPorVenta);
        }

    }
}