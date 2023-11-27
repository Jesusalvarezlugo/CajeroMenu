using CajeroMenuC.Dtos;
using CajeroMenuC.Servicios;
using System.Xml.Linq;
using System;

namespace CajeroMenuC.Controladores
     
          ///<summary>
         ///Clase que controla el flujo de la aplicacion
        /// jal-21/11/2023
       /// </summary>
{
    class Program
    {

        /// <summary>
        /// Método principal de nuestra aplicación
	    /// Define el procedimiento, es de donde toda acción salen
	    /// y a donde toda acción llega cuando acaba.
        /// jal-21/11/2023
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaBancariaDto> listaCuentaBanc=new List<CuentaBancariaDto>();           
            MenuInterfaz mi = new MenuImplementacion();
            operativaInterfaz oi = new operativaImplementacion();
            

            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                mi.mostrarMensajeBienvenida();

                opcionS = mi.mostrarMenuYSeleccion();



                switch (opcionS)
                {
                    case 0:
                        cerrarMenu = true;
                        break;

                    case 1:

                        Console.WriteLine("[INFO] Alta Cliente");
                        
                        
                            oi.DarAltaCliente(listaClientes);
                            //Con bucle FOR
                            /*for (int posicion = 0; posicion < listaClientes.Count; posicion++)
                            {
                                Console.WriteLine(listaClientes[posicion].ToString());
                            }*/

                            foreach (ClienteDto cliente  in listaClientes)
                            {
                                Console.WriteLine(cliente.ToString());
                            }                       
                                                                                                                     
                       break;

                    case 2:

                        Console.WriteLine("[INFO] Alta Cuenta Bancaria");

                        oi.darAltaCuenta(listaCuentaBanc);

                        for(int posicion=0;posicion < listaCuentaBanc.Count; posicion++)
                        {
                            Console.WriteLine(listaCuentaBanc[posicion].ToString());
                        }
                        

                        
                        break;
                }



            }



        }
    }
}

