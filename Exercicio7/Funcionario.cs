namespace Exercicio7
{
    public class Funcionario
    {
        public string Nome = "";

        public double Salario;

        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porc)
        {
            Salario += (Salario * (porc/100.0));
        }

        public void Apresentacao()
        {
            Console.WriteLine("Funcionario: {0}, {1}", this.Nome, this.SalarioLiquido());
        }
    }
}