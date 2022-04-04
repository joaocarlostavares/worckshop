using System;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Retangulo r = new Retangulo();

            Console.WriteLine("Dê entrada nos dados do retângulo:");
            Console.Write("Langura: ");
            r.Largura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Altura: ");
            r.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            
            Console.WriteLine("Area: {0}", r.Area());
            Console.WriteLine("Perimetro: {0}", r.Perimetro());
            Console.WriteLine("Diagonal: {0}", r.Diagonal());
            
        }
    }
}