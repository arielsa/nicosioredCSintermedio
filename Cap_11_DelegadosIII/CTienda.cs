using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_11_DelegadosIII
{
    internal class CTienda
    {
        public static void MandaViveres(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mandando {0} kilos de viveres", pKilos);
        }
    }
}
