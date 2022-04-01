using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Triangulo
    {
        public double A;

        public double B;

        public double C;

        public double Area()
        {
            double p = Convert.ToDouble((A + B + C) / 2);
            return Math.Sqrt(p * (p- A) * (p - B) * (p - C));
        }
    }
}