namespace heranca.entities
{
    public class ProdutoImportado : Produto
    {
        public double Taxa { get; set; }

        public ProdutoImportado()
        {
        }
        public ProdutoImportado(string nome, double preco,double taxa) : base(nome, preco)
        {
            Taxa = taxa;
        }

        public double PrecoTotal()
        {
            return Preco + Taxa;
        }
        
        public override string Pricetag()
        {
            return $"{Nome}, ${PrecoTotal()} (taxa de importação: {Taxa})";
        }


    }
}