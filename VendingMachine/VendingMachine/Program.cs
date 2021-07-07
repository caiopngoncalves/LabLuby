using System;
using VendingMachine.Entities;
using VendingMachine.Entities.Enums;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Sales Sale = new Sales();
            Stock Stock = new Stock(Sale);

            Stock.AddDrink(5, 2.00, DrinkType.Soda);
            Stock.AddDrink(5, 3.00, DrinkType.Juice);
            Stock.AddDrink(5, 1.00, DrinkType.Water);
            Stock.AddDrink(5, 5.00, DrinkType.Vodka);
            Stock.AddDrink(5, 2.50, DrinkType.Beer);
            Stock.AddDrink(5, 6.50, DrinkType.Whiskey);

            bool Status = true;

            while (Status == true)
            {
                Console.WriteLine("Digite 0 caso queira sair");
                Console.WriteLine("Digite 1 caso queira comprar uma bebida");
                Console.WriteLine("Digite 2 caso queira saber o estoque de bebidas");
                Console.WriteLine("Digite 3 caso queira saber o total de vendas da máquina");
                string Option = Console.ReadLine();
                Console.Clear();

                switch (Option)
                {
                    case "0":
                        Console.WriteLine("A máquina foi desligada");
                        Status = false;
                        break;
                    case "1":
                        Console.WriteLine("Qual bebida você gostaria de comprar?");
                        Console.WriteLine();
                        for (int i = 0; i <= 5; i++)
                        {
                            string[] TypeOfDrink = { "Refrigerante", "Suco", "Água", "Vodka", "Beer", "Whisky" };
                            Console.WriteLine("Digite " + i + " para comprar " + TypeOfDrink[i]);
                        }
                        Option = Console.ReadLine();
                        Console.Clear();
                        double Money;
                        string aux;
                        switch (Option)
                        {

                            case "0":
                                if (Stock.CheckDrinkStock(DrinkType.Soda))
                                {

                                    Console.WriteLine("Você escolheu comprar Refrigerante cujo valor é de R$2,00");
                                    Console.WriteLine("Digite a quantidade de dinheiro (Exemplo 10,00):");
                                    aux = Console.ReadLine();
                                    Console.Clear();
                                    _ = aux.Replace(',', '.');
                                    Money = double.Parse(aux);
                                    while (!Stock.CheckMoney(Money, DrinkType.Soda))
                                    {
                                        Console.WriteLine("Faltam R$ " + (2 - Money).ToString("F") + ". Por favor insira mais dinheiro (Exemplo de formato: 10,00)");
                                        Money += double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }

                                    Stock.SellDrink(DrinkType.Soda, Money);
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Não há refrigerante em estoque");
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                            case "1":
                                if (Stock.CheckDrinkStock(DrinkType.Juice))
                                {
                                    Console.WriteLine("Você escolheu comprar suco cujo valor é de R$3,00");
                                    Console.WriteLine("Digite a quantidade de dinheiro (Exemplo 10,00):");
                                    aux = Console.ReadLine();
                                    Console.Clear();
                                    _ = aux.Replace(',', '.');
                                    Money = double.Parse(aux);
                                    while (!Stock.CheckMoney(Money, DrinkType.Juice))
                                    {                                     
                                        Console.WriteLine("Faltam R$ " + (3 - Money).ToString("F") + ". Por favor insira mais dinheiro (Exemplo de formato: 10,00)");
                                        Money += double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    Stock.SellDrink(DrinkType.Juice, Money);
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Não há suco em estoque");
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                            case "2":
                                if (Stock.CheckDrinkStock(DrinkType.Water))
                                {
                                    Console.WriteLine("Você escolheu comprar água cujo valor é de R$1,00");
                                    Console.WriteLine("Digite a quantidade de dinheiro (Exemplo 10,00):");
                                    aux = Console.ReadLine();
                                    Console.Clear();
                                    _ = aux.Replace(',', '.');
                                    Money = double.Parse(aux);
                                    while (!Stock.CheckMoney(Money, DrinkType.Water))
                                    {
                                        Console.WriteLine("Faltam R$ " + (1 - Money).ToString("F") + ". Por favor insira mais dinheiro (Exemplo de formato: 10,00)");
                                        Money += double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    Stock.SellDrink(DrinkType.Water, Money);
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Não há água em estoque");
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                            case "3":
                                if (Stock.CheckDrinkStock(DrinkType.Vodka))
                                {
                                    Console.WriteLine("Você escolheu comprar Vodka cujo valor é de R$5,00");
                                    Console.WriteLine("Digite a quantidade de dinheiro (Exemplo 10,00):");
                                    aux = Console.ReadLine();
                                    Console.Clear();
                                    _ = aux.Replace(',', '.');
                                    Money = double.Parse(aux);
                                    while (!Stock.CheckMoney(Money, DrinkType.Vodka))
                                    {
                                        Console.WriteLine("Faltam R$ " + (5 - Money).ToString("F") + ". Por favor insira mais dinheiro (Exemplo de formato: 10,00)");
                                        Money += double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    Stock.SellDrink(DrinkType.Vodka, Money);
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Não há vodka em estoque");
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                            case "4":
                                if (Stock.CheckDrinkStock(DrinkType.Beer))
                                {
                                    Console.WriteLine("Você escolheu comprar Cerveja cujo valor é de R$2,50");
                                    Console.WriteLine("Digite a quantidade de dinheiro (Exemplo 10,00):");
                                    aux = Console.ReadLine();
                                    Console.Clear();
                                    _ = aux.Replace(',', '.');
                                    Money = double.Parse(aux);
                                    while (!Stock.CheckMoney(Money, DrinkType.Beer))
                                    {                                     
                                        Console.WriteLine("Faltam R$ " + (2.5 - Money).ToString("F") + ". Por favor insira mais dinheiro (Exemplo de formato: 10,00)");
                                        Money += double.Parse(Console.ReadLine());
                                        Console.Clear();
                                    }
                                    Stock.SellDrink(DrinkType.Beer, Money);
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Não há Cerveja em estoque");
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                            case "5":
                                if (Stock.CheckDrinkStock(DrinkType.Whiskey))
                                {
                                    Console.WriteLine("Você escolheu comprar Whisky cujo valor é de R$6,50");
                                    Console.WriteLine("Digite a quantidade de dinheiro (Exemplo 10,00):");
                                    aux = Console.ReadLine();
                                    Console.Clear();
                                    _ = aux.Replace(',', '.');
                                    Money = double.Parse(aux);
                                    while (!Stock.CheckMoney(Money, DrinkType.Whiskey))
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Faltam R$ " + (6.5 - Money).ToString("F") + ". Por favor insira mais dinheiro (Exemplo de formato: 10,00)");
                                        Money += double.Parse(Console.ReadLine());
                                    }
                                    Stock.SellDrink(DrinkType.Whiskey, Money);
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                                else

                                {
                                    Console.WriteLine("Não há whisky em estoque");
                                    Console.WriteLine("Digite uma tecla para continuar");
                                    _ = Console.ReadLine();
                                    Console.Clear();
                                    break;
                                }
                            default:
                                Console.WriteLine("Tecla digitada está errada");
                                Console.WriteLine("Precione uma tecla para continuar");
                                _ = Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                        break;
                    case "2":
                        Stock.ShowStock();
                        Console.WriteLine("Precione uma tecla para continuar");
                        _ = Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Stock.ShowSales();
                        Console.WriteLine("Precione uma tecla para continuar");
                        _ = Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Tecla digitada está errada");
                        Console.WriteLine("Precione uma tecla para continuar");
                        _ = Console.ReadLine();
                        Console.Clear();
                        break;

                }
            }
        }
    }
}
