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

            PeticionInterfaz pet = new PeticionImplementacion();
            OperacionInterfaz op = new OperacionImplementacion();
            op.bucle();
            
            
        }
    }
}