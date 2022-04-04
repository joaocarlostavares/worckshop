namespace Exercicio8
{
    public class Conta
    {
        private string _titular = "";

        private int _numeroConta;

        private double _saldo;

        public string Titular {
            get { return _titular; }
            set { if(value != null && value.Length > 3){
                    _titular = value; }
                }
        }

        public int NumeroConta {
            get { return _numeroConta; }
        }
        

        public double Saldo { 
            get { return _saldo; } 
            set { if(value > 0){
                    _saldo = value; }
            }
        }

        public Conta (string nome, int conta){
            _titular = nome;
            _numeroConta = conta;
        }

        
        public Conta (string nome, int conta, double saldoinicial) : this(nome,conta){
            _saldo = saldoinicial;
        }
        
        public void Mostrar()
        {
            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Conta: {0}, Tiular: {1}, Saldo: {2}",_numeroConta, _titular, _saldo);
        }

        public void Deposito()
        {
            Console.WriteLine("Digite o valor a ser depositado:");
            double deposito = double.Parse(Console.ReadLine());

            _saldo += deposito;
            Mostrar();
        }

        public void Sacar()
        {
            Console.WriteLine("Digite o valor a ser sacado:");
            double saque = double.Parse(Console.ReadLine());

            if(saque > _saldo){
                System.Console.WriteLine("impossivel fazer saque!");
            }else{
                _saldo -= (saque + 5);
            }
            
            Mostrar();
        }
    }
}