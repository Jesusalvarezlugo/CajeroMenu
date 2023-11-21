using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// 21/11/2023
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero.
        /// 21/11/2023
        /// </summary>
        void mostrarMensajeBienvenida();

        /// <summary>
        /// Metodo que muestra el menu
        /// 21/11/2023
        /// </summary>
        /// <returns>opcionSeleccionada</returns>
        public int mostrarMenuYSeleccion();

        
    }

    
}
