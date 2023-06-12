using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap_11_DelegadosIII
{
    //aqui van los delegados
    public delegate void DReservasBajas(int pKilos);
    public delegate void DDescongelado(int pGrados);
    internal class CRefri
    {
       private int kilosAlimentos = 0;
        private int grados = 0;

        //aqui estan las variables que usaremos para invocar
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        public CRefri(int pKilos, int pGrados)
        {
            kilosAlimentos = pKilos;
            grados = pGrados;
        }

        //estos metodos permiten referenciar las variables
        //hacemos multicast
        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas += pMetodo;
        }
        public void EliminaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas -= pMetodo;
        }
        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado += pMetodo;
        }
        //propiedades para los atributos
        public int Kilos
        {
            get { return kilosAlimentos; }
            set { kilosAlimentos = value; }
        }
        public int Grados
        {
            get { return grados; }
            set { grados = value; }
        }

        public void Trabajar(int pConsumo)
        {
            //actualizamos los kilos
            kilosAlimentos -= pConsumo;

            //subimos la temperatura
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //invocamos el delegado
            if (kilosAlimentos < 10)
            {
                //invocamos el delegado
                delReservas(kilosAlimentos);
            }
            if (grados > 0)
            {
                //invocamos el delegado
                delDescongelado(grados);
            }
        }

    }
}
