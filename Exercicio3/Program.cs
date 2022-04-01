using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa 1: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Digite o idade da pessoa 1: ");
            p1.Idade = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite o nome da pessoa 2: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Digite o idade da pessoa 2: ");
            p2.Idade = Convert.ToInt32(Console.ReadLine());
            
            string maisVelha;
            if(p1.Idade > p2.Idade){
                maisVelha = p1.Nome;
            }
            else{
                maisVelha = p2.Nome;
            }

            Console.WriteLine("As informações da pessoa 1 são: {0}, {1} e as informações da pessoa 2 são: {2}, {3}", p1.Nome,p1.Idade,p2.Nome,p2.Idade);
            Console.WriteLine("A pessoa mais velha é: {0}", maisVelha);
        }
    }
}