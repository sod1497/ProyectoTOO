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
        
        //Para facilitar extraer elementos permito extraer elementos por clave de la KeyedCollection
        public T Item(String clave)
        {
            T t;
            base.Dictionary.TryGetValue(clave, out t);
            return t;
        }
        
        //Para permitir reemplazar elementos
        public new void SetItem(int i, T t)
        {
            base.SetItem(i, t);
        }

        //Para obtener el índice de un elemento
        public new int IndexOf(T t)
        {
            return base.IndexOf(t);
        }

        //Para devolver una copia y que no sea afectada la capa de persistencia
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
