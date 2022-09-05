using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormForma2D
{
    class Rectangulo: Poligono
    {
        double _lado1;
        double _lado2;
        public Rectangulo(double lado1, double lado2)
        {
            _lado1 = lado1;
            _lado2 = lado2;
        }
        protected override double Area()
        {
            double formula = _lado1 * _lado2;
            return formula;
        }
    }
}
