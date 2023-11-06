using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    internal interface AñoInterfaz
    {
        /// <summary>
        /// Metodo que calcula si un año es bisiesto o no y devuelve una variable stirng que indicara los dias que tendra febrero dependiendo de si el año es bisiesto o no
        /// <author>msm - 311023</author>
        /// </summary>
        /// <returns> variable tipo string</returns>
        /// <param name="año"></param>
        public string año(short año);

    }
}
