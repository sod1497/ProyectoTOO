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
         * para facilitar el extraer elementos
         */

        public T item(String clave)
        {
            T t;
            base.Dictionary.TryGetValue(clave,out t);
            return t;
        }

        public Coleccion<TipoBasico> copiar()
        {
            Coleccion<TipoBasico> aux = new Coleccion<TipoBasico>();
            foreach(TipoBasico i in this)
            {
                aux.Add(i.copiar());
            }
            return aux;
        }
    }
}
