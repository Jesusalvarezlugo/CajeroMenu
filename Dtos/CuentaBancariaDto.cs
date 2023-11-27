using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CajeroMenuC.Dtos
{

    /// <summary>
    /// Entidad cuenta bancaria, representa el ente cuenta bancaria del banco
    /// </summary>
    /// <author>jal-27/11/2023</author>
    internal class CuentaBancariaDto
    {
        /*
            id
            isban
            código switch
            fecha de alta
            fecha de baja
            campo que identifique al cliente
         */

        //Atributos
        long idCuenta;
        string isban= "aaaaa";
        string codswitch = "CSI1SSXX";
        string fchAltaCuenta= "9999/12/31";
        string fchBajaCuenta= "9999/12/31";
        long cuentaCliente;

       

        //Metodos Getters y Setters
        public long IdCuenta { get => idCuenta; set => idCuenta = value; }
        public string Isban { get => isban; set => isban = value; }
        public string Codswitch { get => codswitch; set => codswitch = value; }
        public string FchAltaCuenta { get => fchAltaCuenta; set => fchAltaCuenta = value; }
        public string FchBajaCuenta { get => fchBajaCuenta; set => fchBajaCuenta = value; }
        public long CuentaCliente { get => cuentaCliente; set => cuentaCliente = value; }

        //Constructores


        public CuentaBancariaDto()
        {

        }
        public CuentaBancariaDto(long id, string isban, string fchAltaCuenta,  long cuentaCliente)
        {
            this.idCuenta = idCuenta;
            this.isban = isban;           
            this.fchAltaCuenta = fchAltaCuenta;           
            this.cuentaCliente = cuentaCliente;
        }

        //Método toString

        override
        public string ToString()
        {
            string cuentaString = "Id: " + this.idCuenta + "\n Isban: " + this.isban + "\nCódigo switch: " + this.codswitch +
                "\nFecha de alta: " + this.fchAltaCuenta + "\n Fecha de baja: " + this.fchBajaCuenta +
                "\n Cuenta del cliente: " + this.cuentaCliente;
                
                

            return cuentaString;
        }
       
    }
}
