using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_08_CallBack_MultiplesSink
{
    internal class CRefriSink : IEventoRefri    
    {
        //metodo del sink
        private bool paro = false;
        public bool Paro { get { return paro; }  }   
        public void EReservasBajas(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-->Reservas bajas de alimentos");
            Console.WriteLine("-->Quedan {0} kilos", pKilos);
        }
        public void EDescongelado(int pGrados)//minuto 10.05
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-->El refri se descongela");
            Console.WriteLine("-->Se solicita mantenimiento con urgencia");
            if (pGrados >= 0)
                paro = true;
        }

    }
}
