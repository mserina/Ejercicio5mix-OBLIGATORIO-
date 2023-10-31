using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void bucle(int mes, int año)
        {
            PeticionInterfaz pet = new PeticionImplementacion();
            bool cerrarBucle = false;
            while (!cerrarBucle)
            {
                mes = pet.peticion(0);
                año = pet.peticion(1);
            }
        }
    }
}
