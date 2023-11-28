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


         /// <summary>
         /// Método que crea la nueva cuenta
         /// </summary>
         /// <returns></returns>
        private CuentaBancariaDto cuentaNueva()
        {
            CuentaBancariaDto nuevaCuenta= new CuentaBancariaDto();

            Console.WriteLine("Introduzca el Id: ");
            nuevaCuenta.IdCuenta = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Introduzca el Isban: ");
            nuevaCuenta.Isban = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevaCuenta.FchAltaCuenta = Console.ReadLine();

            Console.WriteLine("Introduzca el id del cliente: ");
            nuevaCuenta.CuentaCliente = Convert.ToInt32(Console.ReadLine());

            return nuevaCuenta;

        }


        /// <summary>
        /// Método que crea el nuevo cliente
        /// </summary>
        /// <returns></returns>
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

        public void borrarCliente(List<ClienteDto> listaAntigua)
        {
            MenuInterfaz mi = new MenuImplementacion();
            string dniBuscar;

            dniBuscar = mi.pedirDni();

            //Objeto especifico:se elimina por referencia de memoria
            ClienteDto clienteABorrar = new ClienteDto();

            foreach (ClienteDto cliente in listaAntigua)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    clienteABorrar = cliente;
                    break;
                }
            }
            listaAntigua.Remove(clienteABorrar);
            
            //Posicion
            /*int posicion;
            bool aBorrar = false;
            for(posicion = 0; posicion < listaAntigua.Count; posicion++)
            {
                if (listaAntigua[posicion].DniCliente.Equals(dniBuscar))
                {
                    aBorrar = true;
                    break;
                }
            }
            if (aBorrar)
            {
                listaAntigua.RemoveAt(posicion);
            }

            else
            {
                Console.WriteLine("El cliente no existe");
            }

            listaAntigua.RemoveAt(posicion);*/

        }
    }
}
