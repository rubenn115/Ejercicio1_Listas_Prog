//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Listas_Prog.dto
{
    /// <summary>
    /// Clase que utilizaré como tipo objeto para añadir los clientes
    /// rbr - 141123
    /// </summary>
    internal class ClienteDto
    {
        //Declaro las variables
        string nombreCliente;
        string apellidosCliente;
        string dniCliente;
        string fchNacimientoCliente;
        string emailCliente;
        int tlfCliente;
        string fchAltaCliente;
        string fchBajaCliente;

        //Getters y Setters
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
    }
}
