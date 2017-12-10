using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Collections.ObjectModel;

namespace CapaDePersistencia
{
    public class Coleccion<T> : KeyedCollection<String, T> where T : TipoBasico
    {
        protected override string GetKeyForItem(T item)
        {
            return item.clave;
        }
    }
}
