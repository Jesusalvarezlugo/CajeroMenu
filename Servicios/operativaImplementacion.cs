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

            Console.WriteLine("Introduzca el dni: ");
            nuevoCliente.DniCliente = Console.ReadLine();

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

        public void modificarCliente(List<ClienteDto> listaAntigua)
        {
            MenuInterfaz mi=new MenuImplementacion();
            string dniBuscar=mi.pedirDni();
            int opcion;
            bool cerrarMenu = false;

            ClienteDto clienteAModificar= new ClienteDto();

            foreach(ClienteDto cliente in listaAntigua)
            {
                if (cliente.DniCliente.Equals(dniBuscar))
                {
                    while (!cerrarMenu)
                    {
                        opcion = mi.menuCampos();

                        switch(opcion)
                        {
                            case 0:
                                Console.WriteLine("-----[INFO] se cerrara el menu------");
                                cerrarMenu = true;
                                break;

                            case 1:
                                Console.WriteLine("-----[INFO] Se modificara el nombre-----");
                                string nombreM;
                                Console.WriteLine("introduce el nombre para modificar");
                                nombreM = Console.ReadLine();

                                cliente.NombreCliente = nombreM;
                                break;

                            case 2:
                                Console.WriteLine("-----[INFO] Se modificara el apellido-----");
                                string apellidoM;
                                Console.WriteLine("Introduce el apellido a modificar");
                                apellidoM = Console.ReadLine();

                                cliente.ApellidosCliente = apellidoM;
                                break;

                            case 3:
                                Console.WriteLine("-----[INFO] Se modificara el dni-----");
                                string dniM;
                                Console.WriteLine("introduce el dni a modificar");
                                dniM= Console.ReadLine();

                                cliente.DniCliente = dniM;
                                break;

                            case 4:
                                Console.WriteLine("-----[INFO] Se modificara la fecha de nacimiento-----");
                                string fchNacM;
                                Console.WriteLine("introduce la fecha  a modificar");
                                fchNacM = Console.ReadLine();

                                cliente.FechaNacimientoCliente = fchNacM;
                                break;

                            case 5:
                                Console.WriteLine("-----[INFO] Se modificara el email-----");
                                string emailM;
                                Console.WriteLine("introduce el email  a modificar");
                                emailM = Console.ReadLine();

                                cliente.EmailCliente = emailM;
                                break;

                            case 6:
                                Console.WriteLine("-----[INFO] Se modificara el telefono-----");
                                int telefonoM;
                                Console.WriteLine("introduce la fecha  a modificar");
                                telefonoM =Int32.Parse(Console.ReadLine());

                                cliente.TlfCliente = telefonoM;
                                break;

                                clienteAModificar = cliente;
                        }
                    }
                    

                    
                }
            }
        }
    }
}
