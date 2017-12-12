using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace CapaDePersistencia
{
    public class Coleccion<T> : KeyedCollection<String, T> where T : TipoBasico
    {
        protected override string GetKeyForItem(T item)
        {
            return item.Clave;
        }


        /*
         * No sé por qué no puedo usarla sin redefinirla si hereda de KeyedCollection
         * Lanza ArgumentNullException y KeyNotFoundException
         */

        public T item(String clave)
        {
            return this.item(clave);
        }
    }
}
