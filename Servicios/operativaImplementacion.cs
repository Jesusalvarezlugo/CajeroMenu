using CajeroMenuC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    internal class operativaImplementacion : operativaInterfaz
    {
        public void DarAltaCliente(List<ClienteDto> listaAntigua)
        {
            ClienteDto nuevoCliente = ClienteNuevo();

            listaAntigua.Add(nuevoCliente);
        }

        public void darAltaCuenta(List<CuentaBancariaDto> listaAntigua)
        {
            CuentaBancariaDto nuevaCuenta =  cuentaNueva();

            listaAntigua.Add(nuevaCuenta);
        }

        private CuentaBancariaDto cuentaNueva()
        {
            CuentaBancariaDto nuevaCuenta= new CuentaBancariaDto();

            Console.WriteLine("Introduzca el Id: ");
            nuevaCuenta.IdCuenta = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el Isban: ");
            nuevaCuenta.Isban = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevaCuenta.FchAltaCuenta = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de baja: ");
            nuevaCuenta.FchBajaCuenta = Console.ReadLine();

            Console.WriteLine("Introduzca el id del cliente: ");
            nuevaCuenta.CuentaCliente = Convert.ToInt32(Console.ReadLine());

            return nuevaCuenta;

        }

        private ClienteDto ClienteNuevo()
        {
            

            //FORMA CORTA
            ClienteDto nuevoCliente = new ClienteDto();

            Console.WriteLine("Introduzca el id: ");
            nuevoCliente.IdCliente = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el nombre: ");
            nuevoCliente.NombreCliente = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            nuevoCliente.ApellidosCliente = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            nuevoCliente.FechaNacimientoCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el email: ");
            nuevoCliente.EmailCliente = Console.ReadLine();

            Console.WriteLine("Introduzca el telefono: ");
            nuevoCliente.TlfCliente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevoCliente.FchAltaCliente = Console.ReadLine();

            return nuevoCliente;



        }


    }
}
