using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// 250923 - jal
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero.
        /// </summary>
        void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menu
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();

        public string NuevoAltaCliente();
    }

    
}
