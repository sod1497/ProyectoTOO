using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModeloDeDominio;
using System.Collections.ObjectModel;

namespace CapaDePersistencia
{
    public class ColeccionDependientes : KeyedCollection<String,Dependiente>
    {
        protected override string GetKeyForItem(Dependiente item)
        {
            return item.NSS;
        }
    }
}
