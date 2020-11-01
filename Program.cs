using System;
using System.Globalization;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
             Produto iten = new Produto();

            System.Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            iten.Name = Console.ReadLine();
            System.Console.Write("Preço: ");
            iten.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Quantidade: ");
            iten.Qtd = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Dados do produto: " + iten);

        }
    }
}
