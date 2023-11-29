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
            Console.WriteLine("3. Modificar cliente");
            Console.WriteLine("4. eliminar cliente");
            Console.WriteLine("5. Historial operaciones");
            Console.WriteLine("############################");
            Console.WriteLine("Seleccione una opcion:");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;


        }

        public string pedirDni()
        {
            string dni;

            Console.WriteLine("Indica el DNI del cliente");
            dni = Console.ReadLine();

            return dni;
        }

        public int menuCampos()
        {
            int opcion;
            Console.WriteLine("Elija el campo a modificar");
            Console.WriteLine("1.Nombre");
            Console.WriteLine("2.Apellidos");
            Console.WriteLine("3.DNI");
            Console.WriteLine("4.Fecha de nacimiento");
            Console.WriteLine("5.Email");
            Console.WriteLine("6.Telefono");           
            Console.WriteLine("0.salir");
            opcion = Console.ReadKey(true).KeyChar - ('0');
            
            return opcion;
        }
    }
}
