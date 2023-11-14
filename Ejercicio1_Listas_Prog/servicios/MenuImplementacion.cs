//Ruben Bernal Ramos, CSI1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Listas_Prog.servicios
{
    /// <summary>
    /// Implementación de la interfaz Menu
    /// rbr - 141123
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        /// <summary>
        /// Método que mostrará el menú por consola
        /// rbr - 141123 
        /// </summary>
        public void menu()
        {
            //Muestro el menú por consola
            Console.WriteLine("#########################");
            Console.WriteLine("##########MENÚ###########");
            Console.WriteLine("#########################");
            Console.WriteLine("1. Cerrar                ");
            Console.WriteLine("2. Registrar cliente     ");
            Console.WriteLine("#########################");
        }
    }
}
