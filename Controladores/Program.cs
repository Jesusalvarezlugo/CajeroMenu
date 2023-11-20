using CajeroMenuC.Dtos;
using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaBancariaDto> listaCuentaBanc=new List<CuentaBancariaDto>();
            ClienteDto cliente1 = new ClienteDto();
            MenuInterfaz mi = new MenuImplementacion();
            operativaInterfaz oi = new operativaImplementacion();
            string respuesta = "";

            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu || respuesta == "s")
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
                        do
                        {
                            oi.DarAltaCliente(listaClientes);
                            for (int posicion = 0; posicion < listaClientes.Count; posicion++)
                            {
                                Console.WriteLine(listaClientes[posicion].ToString());
                            }
                            respuesta = mi.NuevoAltaCliente();

                        } while (respuesta == "s");

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

