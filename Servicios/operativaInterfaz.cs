using CajeroMenuC.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    internal interface operativaInterfaz
    {
        public void DarAltaCliente(List<ClienteDto> listaAntigua);

        public void darAltaCuenta(List<CuentaBancariaDto> listaAntigua);

    }
}

