using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x,y;
            
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os valores dos lados do triangulo X: ");
            x.A = Convert.ToDouble(Console.ReadLine());
            x.B = Convert.ToDouble(Console.ReadLine());
            x.C = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite os valores dos lados do triangulo Y: ");
            y.A = Convert.ToDouble(Console.ReadLine());
            y.B = Convert.ToDouble(Console.ReadLine());
            y.C = Convert.ToDouble(Console.ReadLine());

            double p = Convert.ToDouble((x.A + x.B + x.C) / 2);
            double areax = Math.Sqrt(p * (p- x.A) * (p - x.B) * (p - x.C));
            
            p = Convert.ToDouble((y.A + y.B + y.C) / 2);
            double areay = Math.Sqrt(p * (p- y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("O valor da área do triângulo x é: {0}",areax);
            Console.WriteLine("O valor da área do triângulo y é: {0}",areay);

        }
    }
}