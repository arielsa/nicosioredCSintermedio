using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_05_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAuto Auto1 = new CAuto( "Jetta", 100000);

            //varable referenciada a la misma instancia:
            CAuto Auto2 = Auto1;

            Auto1.CalcularTenencia(0.16);
            Auto2.CalcularTenencia(0.16);

            //impresion de los datos    
            Auto1.MostrarInformacion();
            Auto2.MostrarInformacion();
            Console.WriteLine("------------");

            //hacemos un cambio en auto1
            Auto1.Costo = 120;

            //imprimimos de nuevo
            Auto1.MostrarInformacion();
            Auto2.MostrarInformacion();
            Console.WriteLine("###################");

            //creamos un clon de auto1
            CAuto Auto3 = (CAuto)Auto1.Clone();

            Auto1.MostrarInformacion();
            Auto3.MostrarInformacion();
            Console.WriteLine("------------");

            //hacemos un cambio en auto1
            Auto1.Costo = 11111111;
            Auto1.MostrarInformacion();
            Auto3.MostrarInformacion();
            Console.WriteLine("###################");







        }
    }
}
