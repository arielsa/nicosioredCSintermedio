using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa01_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double vala = 0.0, valb = 0.0;

            string valor = "";

            IOperacion operacion = new CSuma();

            while (opcion != 5)
            {
                Console.WriteLine("1- Suma, 2-resta, 3-multi, 4-div, 5-salir");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                
                Console.WriteLine("Dame el valor de a");
                valor = Console.ReadLine();
                vala = Convert.ToDouble(valor);

                Console.WriteLine("Dame el valor de b");
                valor = Console.ReadLine();
                valb = Convert.ToDouble(valor);

                //polimorfismo:
                if (opcion == 1)
                {operacion = new CSuma();}
                else if (opcion == 2)
                {operacion = new CResta();}
                else if (opcion == 3)
                {operacion = new CMulti();}
                else if (opcion == 4)
                {operacion = new CDiv();}
                else
                {break;}

                // aqui nuestro programa ttrabaja en terminos
                //del concepto Operacion, en lugar de en
                //terminos d ecosas como suma, resta, multi, div

                operacion.Calcular(vala, valb);
                operacion.Mostrar();
            }

        }
    }
}
