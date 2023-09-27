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

        }
    } 
}
            
