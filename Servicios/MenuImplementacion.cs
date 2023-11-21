using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de menú
    /// 21/11/2023 - jal
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mostrarMensajeBienvenida()
        {
            string mensaje = "Banco CSI1";

            Console.WriteLine(mensaje);
        }

        public int mostrarMenuYSeleccion()
        {
            int opcionIntroducida;
            Console.WriteLine("#########################");
            Console.WriteLine("0. Cerrar aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Crear Cuenta Bancaria");
            Console.WriteLine("3. Sacar dinero");
            Console.WriteLine("4. Transferir dinero");
            Console.WriteLine("5. Historial operaciones");
            Console.WriteLine("############################");
            Console.WriteLine("Seleccione una opcion:");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;


        }

        
    }
}
