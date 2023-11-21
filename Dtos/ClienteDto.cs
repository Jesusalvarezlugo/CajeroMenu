using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Clase  Entidad cliente
/// jal-21/11/2023 
/// </summary>

namespace CajeroMenuC.Dtos
{
    internal class ClienteDto
    {
        //Atributos(Caracteristicas)
        //son private por defecto
        long idCliente;//PK(PRIMARY KEY)
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        string dniCliente = "aaaaa";
        string fechaNacimientoCliente = "9999/12/31";
        string emailCliente = "aaaaa";
        int tlfCliente = 111111111;
        string fchAltaCliente = "9999/12/31";
        string fchBajaCliente = "9999/12/31";




        //Getters Y Setters(Get-lectura Set-escritura)
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }

        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string FechaNacimientoCliente { get => fechaNacimientoCliente; set => fechaNacimientoCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }


        //Constructores(metodos que crean objetos -new)

        public ClienteDto()
        {

        }

        public ClienteDto(string nombreCliente, string apellidosCliente, string dniCliente, string fechaNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente)
        {
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;

        }

        //toString

        override
        public string ToString()
        {
            string clienteString = "ID:  " + this.idCliente +
                "Nombre: " + this.nombreCliente +
                " \nApellidos: " + this.apellidosCliente + "\n" +
                " DNI: " + this.dniCliente +
                "\n Email: " + this.emailCliente +
                "\nTelefono: " + this.tlfCliente +
                "\n Fecha de alta: " + fchAltaCliente +
                "\n Fecha de baja: " + fchBajaCliente;
                

            return clienteString;
        }

    }
}