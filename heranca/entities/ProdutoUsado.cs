namespace heranca.entities
{
    public class ProdutoUsado : Produto
    {
        public DateOnly DataFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco,DateOnly dataFabricacao) : base(nome, preco)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Pricetag()
        {
            return $"{Nome} (usado), ${Preco}  (fabricado em: {DataFabricacao})";
        }
    }
}