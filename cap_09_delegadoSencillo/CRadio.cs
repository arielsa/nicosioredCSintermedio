using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_09_delegadoSencillo
{
    internal class CRadio
    {
        //metodo que se va a referenciar con el delegado
        //IMPORTANTE: el metodo debe tener la misma firma que el delegado y ser static
        public static void MetodoRadio(string msj)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La radio dice: {0}", msj);
        }
    }
}
