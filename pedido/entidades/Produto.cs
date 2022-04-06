namespace pedido.entidades
{
    public class Produto
    {
        public string Name { get; set; }

        public double Preco { get; set; }

        public Produto()
        {
        }

        public Produto(string nome,double preco)
        {
            Name = nome;
            Preco = preco;
        }

    }
}