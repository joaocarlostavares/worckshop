using Exercicio10.entities.exeptions;

namespace Exercicio10.entities
{
    public class Conta
    {
        public int NumConta { get; set; }

        public string Nome { get; set; }

        public double Balance { get; set; }

        public double Limite { get; set; }

        public Conta()
        {
        }

        public Conta(int conta, string nome, double balanco, double limite)
        {
            NumConta = conta;
            Nome = nome;
            Balance = balanco;
            Limite = limite;
        }

        public void Saque(double valor)
        {
            if(valor > Limite)
            {
                throw new DomainExeption("Valor a ser sacado passa do limite");
            }
            else if(valor > Balance)
            {
                throw new DomainExeption("Valor exede o balanço");
            }
            
            Balance-= valor;

        }

        public void Deposito(double valor)
        {
            Balance += valor;
        }

        public override string ToString()
        {
            string texto = $"Novo Saldo: {Balance}";
            return texto;
        }
    }
}