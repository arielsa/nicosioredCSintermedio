using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_05_ICloneable
{
    internal interface IAutomovil
    {
        //calcular impuesto
        void CalcularTenencia(double imp);

        //mostrar impuesto
        void MostrarInformacion();
    }
}
