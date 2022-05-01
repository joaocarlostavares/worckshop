using Exercicio10.entities;
using Exercicio10.entities.exeptions;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();

                Console.WriteLine("Entre os dados da conta");
                Console.Write("Numero: ");
                int numConta = int.Parse(Console.ReadLine());
                Console.Write("Proprietario: ");
                string nome = Console.ReadLine();
                Console.Write("Balanço: ");
                double balanco = double.Parse(Console.ReadLine());
                Console.Write("limite de saque: ");
                double limite = double.Parse(Console.ReadLine());
                
                Console.Write("Valor a ser sacado: ");
                double saque = double.Parse(Console.ReadLine());
                
                Conta c = new Conta(numConta,nome,balanco,limite);
                c.Saque(saque);
                c.ToString();
            }  
            catch(DomainExeption e){
                Console.WriteLine("Erro de saque! " + e.Message);
            }
            catch(Exception e){
               Console.WriteLine("Erro inesperado! " + e.Message); 
            }
                


        }
    }
}