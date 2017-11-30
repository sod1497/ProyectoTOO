using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ColeccionDependientes : KeyedCollection<String,Dependiente>
    {
        protected override string GetKeyForItem(Dependiente item)
        {
            return item.NSS;
        }
    }
}
