using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    /// <summary>
    /// Implementacion de la interfaz, en esta clase se almacenara toda la logica de los metodos
    /// <author>msm - 311023</author>
    /// </summary>
    internal class AñoImplementacion : AñoInterfaz
    {
        public string año(short año)
        {
            string feb;
            //Este if indicara que si un año es divisible por 4 y no es divisible entre 100 sera bisiesto
            //Sin embargo si el año es divisible por 100 pero tambien es divisible por 400 tambien sera bisiesto
            //Si año no es divisible por 4 o es divisible por 100 y no por 400, el año no sera bisiesto
            
            
            if( (año % 4 == 0 && año % 100 != 0) || (año % 400 ==0) )
            {
                Console.WriteLine("Es bisiesto");
                //Guardamos dentro de la variable feb (creado posteriormente)
                //el valor y, valor que luego usaremos en el main para determinar los 
                //dias que tiene febrero
                feb = "y";
            }
            else
            {
                Console.WriteLine("No es bisiesto");
                feb = "n";
            }
            return feb;
        }
    }
}
