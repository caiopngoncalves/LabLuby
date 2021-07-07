using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Entities.Enums;

namespace VendingMachine.Entities
{
    class Stock
    {

        public Sales Sale { get; set; }
        public List<Drink> Drinks { get; set; } = new List<Drink>();

        public Stock(Sales sale)
        {
            Sale = sale;
        }

        public void AddDrink(int amount, double price, DrinkType type)
        {
            Drink drink = new Drink(amount, price, type);
            Drinks.Add(drink);
        }
        public void UpdateStock(DrinkType Type)
        {
            foreach (Drink x in Drinks)
            {
                if (Type == x.DrinkType)
                {
                    if (x.Amount >= 1)
                        x.Amount -= 1;
                }
            }
        }
        public void ShowStock()
        {
            foreach (Drink x in Drinks)
            {
                Console.WriteLine(x);
                Console.WriteLine();
            }
        }
        public void ShowSales()
        {
            Console.WriteLine(Sale);
        }
        public bool CheckDrinkStock(DrinkType Type)
        {
            foreach (Drink x in Drinks)
            {
                if (x.DrinkType == Type)
                {
                    if (x.Amount >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool CheckMoney(double Money, DrinkType Type)
        {
            foreach (Drink x in Drinks)
            {
                if (x.DrinkType == Type)
                {
                    if (Money < x.Price)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return true;
        }
        public void SellDrink(DrinkType Type, double Money)
        {
            foreach (Drink x in Drinks)
            {
                if (x.DrinkType == Type)
                {
                    double Change = Sale.Sell(x.Price, Money);
                    UpdateStock(x.DrinkType);
                    Console.WriteLine("Compra realizada com sucesso");
                    Console.WriteLine("Seu troco é de: R$ " + Change.ToString("F"));
                }
            }
        }
    }
}
