using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    /*
     * Clase que permite tener un generador de claves independiente del usuario
     * Se usará para generar claves para ventas y artículos
     */
    public class GestorDeClaves
    {
        private string id = "00000000";

        public GestorDeClaves(){ }

        public string NuevaClave()
        {
            string aux = id;
            incrementarClave();
            return aux;
        }

        private void incrementarClave()
        {
            double a;
            double.TryParse(id,out a);
            double ceros = 0;

            a++;
            for(double i=1;i<8;i++)
            {
                double x = (Math.Pow(10, i));
                if (a / x < 1)
                {
                    ceros = 8 - i;
                    break;
                }
            }

            id = "";
            for(int i = 1;i<=ceros;i++)
            {
                id += "0";
            }
            id += a.ToString();

        }
    }
}
