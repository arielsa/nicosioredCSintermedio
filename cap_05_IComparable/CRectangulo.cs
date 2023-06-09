using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_06_IComparable 
{
    internal class CRectangulo : IComparable
    {
        private double ancho;
        private double alto;
        private double area;
        public CRectangulo(double pAncho, double pAlto)
        {
            ancho = pAncho;
            alto = pAlto;
            area = ancho * alto;
        }
        public void CalculaArea()
        {
            area = ancho * alto;
        }

        //el metodo sort toma el objeto actual y lo compara con otro objeto por
        //medio de la interfaz IComparable. el metodo CompareTo toma el objeto externo
        //y lo compara con el objeto actual. y devuelve -1, 1 o 0 dependiendo de la comparacion codificada
       
        public int CompareTo(object obj)//objeto externo a comparar(otor rectangulo)
        {
            //hacemos un cast del objeto a CRectangulo
            CRectangulo temp = (CRectangulo)obj;
           
            if (this.area < temp.area) { return -1; } // this es el objeto actual y temp es el objeto externo
            else if (this.area > temp.area){return 1;}
            else{return 0;}            
        }

        public override string ToString()
        {
            return string.Format("Ancho: {0}, Alto: {1}, Area: {2}", ancho, alto, area);
        }
    }
}
