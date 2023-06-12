using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_10_DelegadosII
{
    internal class CRefri
    {
        //Aqui se declaran los delegados
        public delegate void DReservasBajas(int pKilos);
        public delegate void DDescongelado(int pGrados);

        private int kilosAlimentos = 0;
        private int grados = 0;

        //Variables que usan los delegados
        private DReservasBajas delReservas;
        private DDescongelado delDescongelado;

        public CRefri(int pKilos, int pGrados)
        {
            kilosAlimentos = pKilos;
            grados = pGrados;
        }
        public void AdicionaMetodoReservas(DReservasBajas pMetodo)
        {
            delReservas = pMetodo;
        }
        public void AdicionaMetodoDescongelado(DDescongelado pMetodo)
        {
            delDescongelado = pMetodo;
        }
        //propiedades para controlar los atributos
        public int Kilos { get { return kilosAlimentos; } }
        public int Grados { get { return grados; } }

        //metodo que simula el trabajo del refri
        public void Trabajar(int pConsumo)
        {
            kilosAlimentos -= pConsumo;
            grados += 1;

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("{0} kilos, {1} grados", kilosAlimentos, grados);

            //Verificamos si se cumple la condicion de los delegados
            if (kilosAlimentos < 10)
            {
                //Invocamos el delegado
                delReservas(kilosAlimentos);
            }
            if (grados > 0)
            {
                //Invocamos el delegado
                delDescongelado(grados);
            }
        }
    }
}
