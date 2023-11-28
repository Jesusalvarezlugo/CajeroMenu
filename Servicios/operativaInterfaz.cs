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
        /// <summary>
        /// Método para dar de alta un cliente.
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void DarAltaCliente(List<ClienteDto> listaAntigua);

        /// <summary>
        /// Método para dar de alta una cuenta
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCuenta(List<CuentaBancariaDto> listaAntigua);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void borrarCliente(List<ClienteDto> listaAntigua);

    }
}

