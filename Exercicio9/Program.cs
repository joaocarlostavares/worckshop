using System;
using Exercicio9.entities;
using System.Collections.Generic;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            List<Pessoa> lista = new List<Pessoa>();
            
            Console.Write("Digite o numero de pessoas a serem inseridas: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<= n; i++)
            {
                Console.WriteLine($"Digite os dados da #{i} Pessoa:");
                Console.Write("Pessoa fisica ou juridica (f/j): ");
                char tipo = char.Parse(Console.ReadLine());
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                
                Console.Write("Renda anual: ");
                double renda = double.Parse(Console.ReadLine());
                
                if(tipo == 'j')
                {
                    Console.Write("Numero de funcionarios: ");
                    int numfunc = int.Parse(Console.ReadLine());

                    lista.Add(new PessoaJuridica(nome,renda,numfunc));
                }
                else
                {
                    Console.Write("Digite o gasto com saude: ");
                    double gasto = double.Parse(Console.ReadLine());
                    lista.Add(new PessoaFisica(nome,renda,gasto));
                }
            }

            Console.WriteLine("");
            double sum = 0.0;
            foreach(Pessoa p in lista)
            {
                double imposto = p.imposto();
                Console.WriteLine($"{p.Nome}, ${p.imposto()}");
                sum += imposto;
            }

            Console.WriteLine("");
            Console.WriteLine(sum);

        }
    }
}