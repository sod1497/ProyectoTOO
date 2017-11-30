using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Collections.ObjectModel;

namespace CapaDePersistencia
{
    class ColeccionArticulos : KeyedCollection<String, Articulo>
    {
        protected override string GetKeyForItem(Articulo item)
        {
            return item.ID;
        }
    }
}
