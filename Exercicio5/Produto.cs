namespace Exercicio5
{
    public class Produto
    {
        public string Nome="";

        public int Quantidade;

        public double Valor;

        public double ValorTotalEmEstoque(){
            return Quantidade * Valor;
        }

        public void AdicionarProdutos(int quant)
        {
            this.Quantidade += quant;
        }

        public void RemoverProdutos(int quant)
        {
            this.Quantidade -= quant;
        }
    }
}