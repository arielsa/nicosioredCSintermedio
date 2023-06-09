using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_06_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CRectangulo[] rectangulos = new CRectangulo[5];
            rectangulos[0] = new CRectangulo(10, 20);
            rectangulos[1] = new CRectangulo(20, 30);
            rectangulos[2] = new CRectangulo(30, 40);
            rectangulos[3] = new CRectangulo(40, 50);
            rectangulos[4] = new CRectangulo(50, 60);

            //imprimo arreglo original
            foreach (CRectangulo r in rectangulos)
            {
                Console.WriteLine(r.ToString());
            }
            //ordeno arreglo
            Array.Sort(rectangulos);
            //imprimo arreglo ordenado
            Console.WriteLine("Arreglo ordenado");
            foreach (CRectangulo r in rectangulos)
            {
                Console.WriteLine(r.ToString());
            }
        }
    }
}
