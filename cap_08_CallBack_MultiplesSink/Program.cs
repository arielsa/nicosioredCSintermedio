using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_08_CallBack_MultiplesSink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //creamos el sink
            CRefriSink miSink1 = new CRefriSink();
            CTiendaSink miSink2 = new CTiendaSink();

            //adicionamos el sink al refri
            miRefri.AgregarSink(miSink1);
            miRefri.AgregarSink(miSink2);

            //el refri hace su trabajo
            while (miRefri.Kilos > 0 && miSink1.Paro==false)
            {
                //el refri trabaja y le saca kilos al azar
                miRefri.Trabajar(rnd.Next(1, 5));
            }

        }
    }
}
