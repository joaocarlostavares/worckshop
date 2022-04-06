using pedido.entidades.enums;
using pedido.entidades;

namespace pedido.entidades
{
    public class Pedido
    {
         public DateTime Data { get; set; }
        public Pedidostatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();

        public Pedido()
        {
        }

        public Pedido(DateTime data, Pedidostatus status, Cliente cliente) 
        {
            this.Data = data;
            this.Status = status;
            this.Cliente = cliente;
        }

        public void Additem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void Removeitem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public 
    }
}