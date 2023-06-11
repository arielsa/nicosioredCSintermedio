using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_09_delegadoSencillo
{
    public delegate void MiDelegado(string m);//definimos el delegado, en este caso esta a la altura del namespace
    internal class Program
    {
        static void Main(string[] args)
        {
            // creamos un delegado y lo referenciamos a un metodo
            MiDelegado delegado = new MiDelegado(CRadio.MetodoRadio);

            //ahora por medio del delegado hacemos uso del metodo
            delegado("Hola");

            //ahora referenciamos el delegado a otro metodo
            delegado = new MiDelegado(CPastel.MostrarPastel);

            //ahora por medio del delegado hacemos uso del metodo
            delegado("Feliz cumpleaños");
        }
    }
}
