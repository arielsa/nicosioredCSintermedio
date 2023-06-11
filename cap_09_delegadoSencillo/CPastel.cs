using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_09_delegadoSencillo
{
    internal class CPastel
    {
        //metodo que se va a referenciar con el delegado
        //IMPORTANTE: el metodo debe tener la misma firma que el delegado y ser static
        public static void MostrarPastel(string msj)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("El pastel dice: {0}", msj);
        }
    }
}
