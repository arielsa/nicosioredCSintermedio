using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_10_DelegadosII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //adicionamos los handlers
            miRefri.AdicionaMetodoReservas(new CRefri.DReservasBajas(InformeKilos));
            miRefri.AdicionaMetodoDescongelado(new CRefri.DDescongelado(InformeGrados));

            //el refri trabajando
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }
        }
        public static void InformeKilos(int pKilos )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Informe de Kilos");
            Console.WriteLine("Kilos: {0}", pKilos);
        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Informe de grados");
            Console.WriteLine("grados: {0}", pGrados);
        }
    }
}
