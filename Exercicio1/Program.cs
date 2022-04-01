using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta novaConta = new Conta();

            Console.WriteLine("O Titular {0} possue a conta de número {1} com o saldo de R${2}",novaConta.Titular,novaConta.Numero,novaConta.Saldo);

            
        }
    }
}