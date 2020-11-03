using System;
using System.Globalization;
namespace produtos
{
    public class Produto
    {
        public string Name;
        public double Price;
        public int Qtd;

        public Produto(string name, double price, int qtd) 
        {
            Name = name;
            Price = price;
            Qtd = qtd;
        }

        public double StockValue()
        {
            return Price * Qtd;
        }
        public void AddItem (int addItem)
        {
            Qtd += addItem;
        }
        public void RemoveItem (int reItem)
        {
            Qtd -= reItem;
        }

        public override string ToString()
        {
            return "Nome: " + Name + " - Preço: $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " - Qtd no estoque: " + Qtd + " - Valor em estoque: $ " + StockValue().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}