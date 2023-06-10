using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_08_CallBack_MultiplesSink
{
    internal interface IEventoRefri
    {
        //eventos que tendra refri
        void EReservasBajas(int pKilos);
        void EDescongelado(int pGrados);
    }
}
