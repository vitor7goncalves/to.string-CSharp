using System;
using System.Globalization;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
             

            System.Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            System.Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade: ");
            int qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto item = new Produto( name, price, qtd);

            System.Console.WriteLine("Dados do produto: " + item);
            System.Console.WriteLine();
            System.Console.Write("Digite a quantidade de produtos a ser adicionado no estoque: ");
            int product = int.Parse(Console.ReadLine());
            item.AddItem(product);
            System.Console.WriteLine("Estoque atualizado: " + item);
            System.Console.Write("Digite a quantidade de produtos a ser removido do estoque: ");
            product = int.Parse(Console.ReadLine());
            item.RemoveItem(product);
            System.Console.WriteLine("Estoque atualizado: " + item);
        }
    }
}
