using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Collections.ObjectModel;

namespace CapaDePersistencia
{
    class ColeccionVentas : KeyedCollection<String, Venta>
    {
        protected override string GetKeyForItem(Venta item)
        {
            return item.ID;
        }
    }
}
