using System;

namespace ModeloDeDominio
{
    public class Dependiente : TipoBasico, IEquatable<Dependiente>
    {

        private string nss;
        private string nombre;
        private string apellidos;
        private int comisionPorVenta;
        //private bool estaActivo;

        public Dependiente(string nss, string nombre, string apellidos, int comision)
        {
            this.nss = nss;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.comisionPorVenta = comision;
           // this.estaActivo = true;
        }
        public Dependiente(){ }

/*
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
*/

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

        public string NombreCompleto
        {
            get
            {
                return this.apellidos + ", " + this.nombre;
            }
        }

        public int ComisionPorVenta
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

        public TipoBasico copiar()
        {
            return new Dependiente(this.NSS, this.Nombre, this.Apellidos, this.ComisionPorVenta);
        }

        public bool Equals(Dependiente other)
        {
            return this.Clave == other.Clave;
        }

        public string Clave
        {
            get
            {
                return this.NSS;
            }
        }
    }
}
