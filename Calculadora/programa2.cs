using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculador
{
    class Program2
    {
        static void Main2(string[] args)
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("============CALCULADORA=============");
            Console.WriteLine("====================================");
            Console.WriteLine("");    
            
            char continuar;
           
            do
            {
                Console.WriteLine("Digite + para soma: ");
                Console.WriteLine("Digite - para subtração: ");
                Console.WriteLine("Digite * para multiplicação: ");
                Console.WriteLine("Digite / para divisão: ");
                Console.WriteLine("Digite a operação desejada: ");
               
                char operacao = Convert.ToChar(Console.ReadLine());
                
                Console.WriteLine("");
                
                float valor = 0;
                
                switch(operacao)
                {
                    case '+':
                        valor = Soma();
                        break;
                    case '-':
                        valor = subtracao();
                        break;
                    case '*':
                        valor = multiplicacao();
                        break;
                    case '/':
                        valor = divisao();
                        break;
                    default:
                        Console.WriteLine("Operação não encontrada!");
                        break;
                }
                Console.WriteLine("O valor resultante da operação é: " + valor);   
                
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
        static float Soma(){
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());    
           
            Console.WriteLine("Digite o segundo valor: ");        
            float valor2 = float.Parse(Console.ReadLine());
            
            return valor1 + valor2;
        }
        static float subtracao(){
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());   
            
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            return valor1 - valor2;   
        }
        static float multiplicacao(){
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
           
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            return valor1 * valor2;
        }
        static float divisao(){
            Console.WriteLine("Digite o primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            
            return valor1 / valor2;
        }
    }
}