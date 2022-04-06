using System;
using pedido.entidades;
using pedido.entidades.enums;

namespace pedido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            Pedidostatus status = Enum.Parse<Pedidostatus>(Console.ReadLine());

            Cliente cliente = new Cliente(clientName, email, birthDate);
            Pedido order = new Pedido(DateTime.Now, status, cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Produto product = new Produto(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                ItemPedido orderItem = new ItemPedido(quantity, price, product);

                order.Additem(orderItem);
            }

            Console.WriteLine();
            order.Mostrar();
            System.Console.WriteLine("");
            order.Total();
        }
    }
}