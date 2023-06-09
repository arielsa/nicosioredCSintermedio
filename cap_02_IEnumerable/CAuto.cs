using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_02_IEnumerable
{
    class CAuto : IAutomovil
    {
        double costo;
        double tenencia;
        string modelo;
        //constriuctor
        public CAuto(string pModelo, double pCosto)
        {
            modelo = pModelo;
            costo = pCosto;
        }
        public double Costo{get { return costo; } set { costo = value; }}
        public double Tenencia { get { return tenencia; } set { tenencia = value; }}
        //metodos de la interfaz
        public void CalcularTenencia(double imp)
        {
            tenencia = 5000 + costo * imp;
        }



        public void MostrarInformacion()
        {
            Console.WriteLine("Tu automovil {0}", modelo);
            Console.WriteLine("Costo {0}", costo);
            Console.WriteLine("Tenencia {0}", tenencia);
            Console.WriteLine("---------------------------");
        }
    }
}
