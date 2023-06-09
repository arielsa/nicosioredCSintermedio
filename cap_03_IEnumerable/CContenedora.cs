using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_03_IEnumerable
{
    class CContenedora : IEnumerable
    {
        private int[] datos = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public IEnumerator GetEnumerator()//implementa el getenumerator necesario para la interfaz
        {
            return new ContenedorEnum(datos);//instancia la clase contenedorenum
        }
    }
    class ContenedorEnum : IEnumerator
    {
        private int[] _datos;
        private int posicion = -1;
        public ContenedorEnum(int[] datos)//los arrays son enumerables por defecto, por eso se puede hacer esto
        {
            _datos = datos;
        }
        public object Current
        {
            get
            {
                if (posicion == -1 || posicion >= _datos.Length)
                {
                    throw new InvalidOperationException();
                }
                return _datos[posicion];
            }
        }
        public bool MoveNext()
        {
            posicion++;
            return posicion < _datos.Length;//si posicion es menor que el tamaño del array, devuelve true
        }
        public void Reset()
        {
            posicion = -1;
        }
    }
    
    
}
