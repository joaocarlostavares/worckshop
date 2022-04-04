using System;

namespace Exercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Conta c;

            Console.WriteLine("Digite o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Ira ter inserção de um valor inicial?(s/n)");
            char resposta = Convert.ToChar(Console.ReadLine());
            
            switch(resposta){
                case 'n':
                    c = new Conta(titular, numero);
                    break;
                case 's':
                    Console.WriteLine("Digite o saldo inicial da conta: ");
                    double saldo = double.Parse(Console.ReadLine());
                    c = new Conta(titular, numero,saldo);
                    break;
                default:
                    c = new Conta(titular, numero);
                    break;
            }

            Console.WriteLine("");
            c.Mostrar();
            Console.WriteLine("");

            Console.WriteLine("");
            c.Deposito();
            Console.WriteLine("");

            Console.WriteLine("");
            c.Sacar();
            Console.WriteLine("");
        }
    }
}