using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeDominio
{
    public class VentaSinTarjeta : Venta
    {
        public VentaSinTarjeta(string id, DateTime fecha, Dependiente dependiente) : base(id, fecha, dependiente)
        {

        }

        public VentaSinTarjeta copiar()
        {
            VentaSinTarjeta v = new VentaSinTarjeta(this.Id,this.fecha,this.Dependiente.copiar());
            List<LineaDeVenta> lineas = this.LineasDeVenta;
            foreach (LineaDeVenta l in lineas)
            {
                v.LineasDeVenta.Add(l.copiar());
            }
            return v;
        }
    }
}
