using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_02_IEnumerable
{
    internal interface IAutomovil
    {
        //calcular impuesto
        void CalcularTenencia(double imp);

        //mostrar impuesto
        void MostrarInformacion();
    }
}
