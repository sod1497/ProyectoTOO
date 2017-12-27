using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class VentaConTarjeta : Venta
    {
        private string tarjeta;

        public VentaConTarjeta(string id, DateTime fecha, Dependiente dependiente,string tarjeta) :base(id,fecha,dependiente)
        {
            this.id = id;
            this.fecha = fecha;
            this.dependiente = dependiente;
            this.tarjeta = tarjeta;
        }

        public string Tarjeta
        {
            get
            {
                return this.tarjeta;
            }
        }

        public override TipoBasico copiar()
        {
            VentaConTarjeta v = new VentaConTarjeta(this.Id, this.Fecha, (Dependiente) this.Dependiente.copiar(), this.Tarjeta);
            List<LineaDeVenta> lineas = this.LineasDeVenta;
            foreach (LineaDeVenta l in lineas)
            {
                v.LineasDeVenta.Add(l.copiar());
            }
            return v;
        }
        
    }
}
