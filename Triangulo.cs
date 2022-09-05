using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormForma2D
{
    class Triangulo: Poligono
    {
        double _base;
        double _altura;
        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            _base = baseTriangulo;
            _altura = alturaTriangulo;
        }
        protected override double Area()
        {
            //Formula triangulo equilatero ya que no conocemos la altura o los angulos
            //double formula = (Math.Pow(_lado1,2) * Math.Sqrt(3))/4;
            double formula = (_base * _altura) / 2;
            return formula;
        }
    }
}
