using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_11_DelegadosIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creamos el refri
            CRefri miRefri = new CRefri(70, -20);
            Random rnd = new Random();

            //variables para el multicasting, nesecitamos la instancia para poder adicionar o liminar
            DReservasBajas kilos1 = new DReservasBajas(InformeKilos);
            DReservasBajas kilos2 = new DReservasBajas(CTienda.MandaViveres);
            DDescongelado grados1 = new DDescongelado(InformeGrados);

            //adiciona los handlers
            miRefri.AdicionaMetodoReservas(kilos1);
            miRefri.AdicionaMetodoReservas(kilos2);
            miRefri.AdicionaMetodoDescongelado(grados1);

            //el refri trabaja
            while (miRefri.Kilos > 0)
            {
                miRefri.Trabajar(rnd.Next(1, 5));
            }

        }
        public static void InformeKilos(int pKilos)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mandando {0} kilos de viveres", pKilos);
        }
        public static void InformeGrados(int pGrados)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("esta a  {0} grados", pGrados);
        }
    }
}
