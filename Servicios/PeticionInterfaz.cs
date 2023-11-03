using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    /// <summary>
    /// Interfaz que contiene la cabezera de los metodos
    /// msm - 031123
    /// </summary>
    internal interface PeticionInterfaz
    {
        /// <summary>
        /// Metodo que pide el mes y el año
        /// msm - 031123
        /// </summary>
        /// <param name="condicion"></param>
        /// <returns></returns>
        public short peticion(int condicion);

    }
}
