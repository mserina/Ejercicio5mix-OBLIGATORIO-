using Ejercicio5Mix_obligatorio_.Servicios;

namespace Ejercicio5Mix_obligatorio_{
    /// <summary>
    /// Clase principal
    /// msm - 311023
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo main, contiene el procedimiento de la aplicacion
        /// msm - 311023
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            int mes;
            int año;
            bool cerrarBucle = false;

            PeticionInterfaz pet = new PeticionImplementacion();
            
            while (!cerrarBucle)
            {
                mes = pet.peticion(0);
                año = pet.peticion(1);

                switch (mes)
                {
                    case 1:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                           cerrarBucle = true;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Tiene 28 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Tiene 30 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 5:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 6:
                        Console.WriteLine("Tiene 30 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 8:
                        Console.WriteLine("Tiene 30 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 9:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 10:
                        Console.WriteLine("Tiene 30 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 11:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                    case 12:
                        Console.WriteLine("Tiene 31 dias");
                        Console.WriteLine("Quieres hacer otra consulta s/n");
                        if (Console.ReadLine() != "s")
                        {
                            cerrarBucle = true;
                        }
                        break;
                }
            }
        }
    }
}