using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_06_ICompare_OrdenamientoSecundario
{
    internal class CPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
    }
    public class ComparadorPersona : IComparer<CPersona>
    {
        int IComparer<CPersona>.Compare(CPersona x, CPersona y)
        {
            int resultado = x.Apellido.CompareTo(y.Apellido);
            if (resultado == 0)
            {
                resultado = x.Nombre.CompareTo(y.Nombre);
            }
            return resultado;
        }
    }
}
