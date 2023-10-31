using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    internal class PeticionImplementacion : PeticionInterfaz
    {
        public short peticion(int condicion)
        {
            short numero;

            if (condicion == 0)
            {
                Console.WriteLine("Dame un mes (numero)");
            }
            else
            {
                Console.WriteLine("Dame un año");
            }

            numero = Convert.ToInt16(Console.ReadLine());
            return numero;
        }
    }
}
