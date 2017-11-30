using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class ColeccionVentas : KeyedCollection<String, Venta>
    {
        protected override string GetKeyForItem(Venta item)
        {
            return item.ID;
        }
    }
}
