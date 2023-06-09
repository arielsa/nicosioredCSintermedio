using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Programa01_01
{
    internal class CResta : IOperacion
    {
        private double r = 0;
        private ArrayList resultados = new ArrayList();

        public void Calcular(double a, double b)
        {
            r = a - b;
        }

        public void Mostrar()
        {
            Console.WriteLine("El resultado de la resta es {0}", r);
            resultados.Add(r);
        }
        //metodos propios de la clase
        public void muestraResultados()
        {
            foreach (double r in resultados)
            {
                Console.WriteLine(r);
            }
        }   
    }
}
