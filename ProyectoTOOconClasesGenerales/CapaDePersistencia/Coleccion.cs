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

        public T Item(String clave)
        {
            base.Dictionary.TryGetValue(clave, out T t);
            return t;
        }

        
        public new void SetItem(int i, T t)
        {
            base.SetItem(i, t);
        }

        public new int IndexOf(T t)
        {
            return base.IndexOf(t);
        }

        public Coleccion<TipoBasico> Copiar()
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
