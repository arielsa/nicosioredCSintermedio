using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_02_IEnumerable
{
    internal class Program
    {
        /*
         public interface IEnumerable
         {
            IEnumerator GetEnumerator();
         }  
        public interface IEnumerator
        {
            bool MoveNext();//avanza al siguiente elemento de la coleccion y regresa true si pudo avanzar y false si ya no hay mas elementos
            object Current { get; } //regresa el elemento actual de la coleccion 
            void Reset();//regresa el enumerador a su estado inicial
        }
         
         */
        static void Main(string[] args)
        {
            //creamos la tienda
            CTiendaAutos tienda = new CTiendaAutos();

            //recorremos cada uno de los elementos de la 
            //estructura que espone

            foreach (CAuto auto in tienda)
            {
                auto.CalcularTenencia(0.10);
                auto.MostrarInformacion();
            }
        }
    }
}
