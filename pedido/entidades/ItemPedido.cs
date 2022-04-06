using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pedido.entidades
{
    public class ItemPedido
    {
        public int Quantidade { get; set; }

        public double Preco { get; set; }

        public Produto Produto { get; set; }

        public ItemPedido(int quantidade, double preco, Produto produto) 
        {
            this.Quantidade = quantidade;
            this.Preco = preco;
            this.Produto = produto;
        }
        
        public double subtotal()
        {
            return Quantidade * Preco;
        }

        public override string ToString()
        {
            return Produto.Name
                + ", $"
                + Preco.ToString("F2")
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + subtotal().ToString("F2");
        }
    }
}