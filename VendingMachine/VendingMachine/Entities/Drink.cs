using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Entities.Enums;

namespace VendingMachine.Entities
{
    class Drink
    {
        public int Amount { get; set; }
        public double  Price { get; set; }
        public DrinkType DrinkType { get; set; }

        public Drink()
        {
        }
        public Drink(int amount, double price, DrinkType drinkType)
        {
            Amount = amount;
            Price = price;
            DrinkType = drinkType;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Tipo de bebida: ");
            sb.Append(DrinkType);
            sb.Append(". Preço: ");
            sb.Append(Price.ToString("F"));
            sb.Append(". Quantidade disponível para venda: ");
            sb.Append(Amount);            
            return sb.ToString();
        }

    }

}
