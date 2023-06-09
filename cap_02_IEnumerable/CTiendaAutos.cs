using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_02_IEnumerable
{
     class CTiendaAutos
    {
        private CAuto[] disponibles; //los arreglos ya traen toda la funcionalidad de IEnumerator
        //los arrays ya tiene implementado el IEnumerator

        public CTiendaAutos()
        {
            disponibles = new CAuto[4];
            disponibles[0] = new CAuto("Spark", 200000);
            disponibles[1] = new CAuto("Matiz", 300000);
            disponibles[2] = new CAuto("Sonic", 400000);
            disponibles[3] = new CAuto("Cruze", 500000);
        }
        public IEnumerator GetEnumerator()
        {
            //REGRESA la estructura que nos interesa que
            //recorra el foreach, esta debe de implementar la interfaz
            return disponibles.GetEnumerator(); 
        }
    }
}
