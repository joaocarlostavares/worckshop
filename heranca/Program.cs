using heranca.entities;

namespace heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Produto> lista = new List<Produto>();

            Console.Write("digite o numero de produtos: ");
            int numeroProdutos = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <=numeroProdutos; i++){
                Console.WriteLine($"dados do #{i} produto");

                Console.Write("comum, importado, usado (c,i,u): ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("digite o nome do produto: ");
                string nome = Console.ReadLine(); 
                Console.Write("digite o preco do produto: ");
                double preco = double.Parse(Console.ReadLine());
                
                switch(tipo)
                {
                    case 'i':
                        Console.Write("digite o valor da taxa: ");
                        double taxa = double.Parse(Console.ReadLine());
                        lista.Add(new ProdutoImportado(nome,preco,taxa));
                        break;
                    case 'u':
                        Console.Write("digite a data de fabricação: ");
                        DateOnly data = DateOnly.Parse(Console.ReadLine());
                        lista.Add(new ProdutoUsado(nome,preco,data));
                        break;
                    case 'c':
                        lista.Add(new Produto(nome,preco));
                        break;
                    default:
                        Console.WriteLine("erro");
                        break;
                }
            }
            
            System.Console.WriteLine("");

            System.Console.WriteLine("PRICE TAGS:");
            
            foreach(Produto p in lista)
            {
                System.Console.WriteLine(p.Pricetag());
            }
            
        }
    }
}