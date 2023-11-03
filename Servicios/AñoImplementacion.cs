using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    
    internal class AñoImplementacion : AñoInterfaz
    {
        public void año(short año)
        {
            //Este if indicara que si un año es divisible por 4 y no es divisible entre 100 sera bisiesto
            //Sin embargo si el año es divisible por 100 pero tambien es divisible por 400 tambien sera bisiesto
            //Si no se cumple ninguna de las condiones anteriores el año no sera bisiesto
            if( (año % 4 == 0 && año % 100 != 0) || (año % 400 ==0))
            {
                Console.WriteLine("Es bisiesto");
                int bisiesto = 0;
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }
        }
    }
}
