using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Mix_obligatorio_.Servicios
{
    
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void bucle()
        {
            short mes;
            short año;
            PeticionInterfaz pet = new PeticionImplementacion();
            AñoInterfaz añ = new AñoImplementacion();
            bool cerrarBucle = false;
            while (!cerrarBucle)
            {
                mes = pet.peticion(0);
                año = pet.peticion(1);

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                           cerrarBucle = true;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tiene 28 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");

                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 8:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 10:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 11:
                        Console.WriteLine("Tiene 30 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 12:
                        Console.WriteLine("Tiene 31 dias");
                        añ.año(año);
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    default:
                        Console.WriteLine("No existe");
                        break;
                }
            }
        }
    }
}
