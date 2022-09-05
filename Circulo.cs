using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormForma2D
{
    class Circulo : Forma2D
    {
        double _radio;
        public Circulo(double radio)
        {
            _radio = radio;
        }
        protected override double Area()
        {
            double formula = Math.Pow(_radio, 2) * Math.PI;
            return formula;
        }
    }
}
