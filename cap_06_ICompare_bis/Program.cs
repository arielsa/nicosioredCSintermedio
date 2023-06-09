using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_06_ICompare_OrdenamientoSecundario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //rodenamiento secundario o ordenamiento por multiples campos

            //creamos lista de personas
            List<CPersona> personas = new List<CPersona>
            {
                new CPersona { Nombre = "Alice", Edad = 30 },
                new CPersona { Nombre = "Bob", Edad = 25 },
                new CPersona { Nombre = "Alice", Edad = 20 }
            };

            // creamos una instancia de la clase comparadora
            ComparadorPersona comparador = new ComparadorPersona();

            //en el metodo .sort() de la lista de personas, le pasamos el comparador como parametro
            personas.Sort(comparador);

        }
    }
}
