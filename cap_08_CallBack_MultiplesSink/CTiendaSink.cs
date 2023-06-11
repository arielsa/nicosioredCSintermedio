using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_08_CallBack_MultiplesSink
{
    internal class CTiendaSink : IEventoRefri
    {
        //constructor
        public CTiendaSink()
        {
        }

        public void EDescongelado(int pGrados)
        {
           // handler vacio
        }

        //manejador del evento EReservasBajas
        public void EReservasBajas(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Reservas bajas de alimentos, estoy comprando");
            Console.WriteLine("Quedan {0} kilos", pKilos);
        }
    }
}
