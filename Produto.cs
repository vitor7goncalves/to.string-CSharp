using System;
using System.Globalization;
namespace produtos
{
    public class Produto
    {
        public string Name;
        public double Price;
        public int Qtd;

        public double StockValue(){
            return Price * Qtd;
        }

        public override string ToString()
        {
            return "Nome: " + Name + " - Preço: $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " - Qtd no estoque: " + Qtd + " - Valor em estoque: $ " + StockValue().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}