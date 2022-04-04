using System;

namespace Exercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Funcionario f = new Funcionario();

            Console.WriteLine("Digite as informações necessárias:");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Sálario: ");
            f.Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Imposto: ");
            f.Imposto = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("");
            
            f.Apresentacao();

            Console.WriteLine("");

            Console.WriteLine("Digite a porcentagem de aumento de sálario: ");
            f.AumentarSalario(Convert.ToDouble(Console.ReadLine()));

            f.Apresentacao();
            
            
        }
    }
}