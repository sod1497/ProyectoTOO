﻿using ModeloDeDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDePersistencia
{
    /*
     * Permite tener una única colección de cada tipo de datos
     */
    public class Singleton<T> where T:TipoBasico
    {
        private static Coleccion<T> coleccion;


        public static Coleccion<T> getColeccion()
        {
            if (coleccion == null)
            {
                coleccion = new Coleccion<T>();
            }
            return coleccion as Coleccion<T>;
        }
        
        
    }
}
