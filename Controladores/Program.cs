using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 250923 - jal
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 250923 - jal
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {

            MenuInterfaz mi = new MenuImplementacion();

            mi.mostrarMensajeBienvenida();

            //variable que controla la entrada y salida del bucle while
            bool cerrarMenu = false;

            //contener la opcion del usuario
            int opcionSeleccionada;


            //desde la primera iteracion debe cumplirse la condicion
            while (!cerrarMenu)
            {

                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                switch (opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO]- se ejecuta caso 0");
                        cerrarMenu = true;
                        break;

                    case 1:
                        Console.WriteLine("[INFO]- se ejecuta caso 1");
                        break;

                    case 2:
                        Console.WriteLine("[INFO]- se ejecuta caso 2");
                        break;

                    case 3:
                        Console.WriteLine("[INFO]- se ejecuta caso 3");
                        break;

                    case 4:
                        Console.WriteLine("[INFO]- se ejecuta caso 4");
                        break;

                    case 5:
                        Console.WriteLine("[INFO]- se ejecuta caso 5");
                        break;

                    default:

                        Console.WriteLine("[INFO] - La opcion seleccionada no esta disponible");
                        break;
                }

            }



        }
    } 
}
            
