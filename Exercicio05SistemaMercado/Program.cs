using System;

namespace Exercicio05SistemaMercado
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto1 produto1A = new Produto1(1.0, 100);
            Produto1 produto1B = new Produto1(1.5, 101);

            Produto2 produto2A = new Produto2(2.0, 200);
            Produto2 produto2B = new Produto2(2.5, 201);

            Produto3 produto3A = new Produto3(3.0, 300);
            Produto3 produto3B = new Produto3(3.5, 301);

            Cliente cliente1 = new Cliente("Ewerton", "123.456.789-10");

            Item item1 = new Item(010, produto1A, 3);
            Item item2 = new Item(011, produto2A, 2);
            Item item3 = new Item(012, produto3A, 1);

            Pedido pedido1 = new Pedido(cliente1, item1, "01");

            pedido1.AdicionarItem(item2);
            pedido1.AdicionarItem(item3);

            MostrarDadosCliente(cliente1);
            MostrarDadosPedido(pedido1);

            Console.WriteLine("\nEstoque:");
            Console.WriteLine(" - Pedido 1: " + produto1A.QtdEstoque);
            Console.WriteLine(" - Pedido 2: " + produto2A.QtdEstoque);
            Console.WriteLine(" - Pedido 3: " + produto3A.QtdEstoque);
            Console.ReadKey();
        }

        public static void MostrarDadosCliente(Cliente cliente)
        {
            Console.WriteLine("\nDados do cliente:");
            Console.WriteLine(" - Nome: " + cliente.Nome);
            Console.WriteLine(" - CPF: " + cliente.CPF);
            Console.WriteLine(" - Fone: " + cliente.Telefone);
        }
        public static void MostrarDadosPedido(Pedido pedido)
        {
            Console.WriteLine("\nDados do pedido:");
            Console.WriteLine(" - N° do pedido: " + pedido.CodPedido);
            for (int i = 0; i < pedido.ItensPedido.Count; i++)
            {
                Console.Write(" - Item n°: ");
                Console.WriteLine(pedido.ItensPedido[i].CodItem);
                Console.WriteLine("      Cód. do produto: " + pedido.ItensPedido[i].ProdutoItem.CodProduto);
                Console.WriteLine("      Qtd. do produto: " + pedido.ItensPedido[i].QtdProdutos);
                Console.WriteLine("     Preço: R$" + pedido.ItensPedido[i].PrecoItem);
            }
        }
    }
}
