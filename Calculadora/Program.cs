using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("============CALCULADORA=============");
            Console.WriteLine("====================================");
            Console.WriteLine("");
            
            char continuar;

            do
            {
                Console.WriteLine("Digite o primeiro valor: ");
                float valor1 = float.Parse(Console.ReadLine());
        
                Console.WriteLine("Digite o segundo valor: ");
                float valor2 = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite + para soma: ");
                Console.WriteLine("Digite - para subtração: ");
                Console.WriteLine("Digite * para multiplicação: ");
                Console.WriteLine("Digite / para divisão: ");
                Console.WriteLine("Digite a operação desejada: ");
                char operacao = Convert.ToChar(Console.ReadLine()[0]);
        
                Console.WriteLine("");

                float total = 0;

                switch(operacao)
                {
                    case '+':
                        total = valor1 + valor2;
                        break;
                    case '-':
                        total = valor1 - valor2;
                        break;
                    case '*':
                        total = valor1 * valor2;
                        break;
                    case '/':
                        total = valor1 / valor2;
                        break;
                    default:
                        Console.WriteLine("Operação não encontrada!");
                        break;
                }

                Console.WriteLine("O valor resultante da operação é: " + total);   

                Console.WriteLine("Deseja continuar a usar a calculadora?(s/n)");
                continuar = Convert.ToChar(Console.ReadLine());

                if(continuar != 's' && continuar != 'n')
                {
                    Console.WriteLine("");
                    Console.WriteLine("Digito não disponível");
                    Console.WriteLine("Deseja continuar a usar a calculadora?(s/n)");
                    continuar = Convert.ToChar(Console.ReadLine());
                }

            }while(continuar == 's');
            
        }

    }
}