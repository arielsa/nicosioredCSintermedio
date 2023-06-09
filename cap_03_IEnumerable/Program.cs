using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_03_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            CContenedora datos = new CContenedora();
            foreach (int dato in datos)
            {
                Console.WriteLine(dato);
            }
        }
    }
}
