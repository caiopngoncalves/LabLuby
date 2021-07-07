using System;
using System.Collections.Generic;
using System.Globalization;

namespace Logic
{
    class Program
    {
        static int CalcularFatorial(int Number)
        {

            int Result = Number;
            for (int i = Number - 1; i >= 1; i--)
            {
                Result *= i;
            }
            return Result;
        }

        static double CalcularPremio(double Award, string Type, double? Factor)
        {
            if (Factor == null)
            {
                switch (Type)
                {
                    case "basic":
                        break;
                    case "vip":
                        Award = Award * 1.2;
                        break;
                    case "premium":
                        Award = Award * 1.5;
                        break;
                    case "deluxe":
                        Award = Award * 1.8;
                        break;
                    case "special":
                        Award = Award * 2;
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
            else
            {
                Award = (double)(Award * Factor);
            }
            return Award;
        }

        static int ContarNumerosPrimos(int Number)
        {
            int Count = 1;
            bool Verifier = false;
            for (int i = 3; i <= Number; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        Verifier = true;
                        break;
                    }
                }
                if (Verifier == false)
                {
                    Count++;
                }
                Verifier = false;

            }
            return Count;
        }

        static int CalcularVogais(string Word)
        {
            int Count = 0;
            _ = Word.ToLower();
            char[] Vowel = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < Word.Length; i++)
            {
                for (int j = 0; j < Vowel.Length; j++)
                {
                    if (Word[i] == Vowel[j])
                    {
                        Count++;
                        break;
                    }
                }
            }
            return Count;
        }
        static string CalcularValorComDescontoFormatado(string Value, string Discount)
        {
            Value = Value.Replace(" ", null).Replace("$", null).Replace("R", null).Replace(".", null).Replace(".", ",");
            Discount = Discount.Replace("%", null);
            double money = double.Parse(Value);
            double percent = double.Parse(Discount);
            money = money - (money * percent / 100);
            string Result = String.Format("{0:C}", money);
            return Result;

        }
        static int CalcularDiferencaData(string DateInit, string DateFinal)
        {
            string[] Day = new string[2];
            Day[0] = DateInit.Substring(0, 2);
            Day[1] = DateFinal.Substring(0, 2);
            string[] Month = new string[2];
            Month[0] = DateInit.Substring(2, 2);
            Month[1] = DateFinal.Substring(2, 2);
            string[] Year = new string[2];
            Year[0] = DateInit.Substring(4, 4);
            Year[1] = DateFinal.Substring(4, 4);

            var Init = new DateTime(int.Parse(Year[0]), int.Parse(Month[0]), int.Parse(Day[0]));
            var Final = new DateTime(int.Parse(Year[1]), int.Parse(Month[1]), int.Parse(Day[1]));
            return (int)Final.Subtract(Init).TotalDays;
        }
        static int[] ObterElementosPares(int[] Array)
        {

            int Length;
            if (Array.Length % 2 == 0)
            {
                Length = Array.Length / 2;
            }
            else
            {
                if (Array[0] % 2 == 0)
                {
                    Length = Array.Length / 2 + 1;
                }
                else
                {
                    Length = Array.Length / 2;
                }
            }
            int[] Pair = new int[Length];
            Length = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] % 2 == 0)
                {
                    Pair[Length] = Array[i];
                    Length++;
                }
            }
            return Pair;
        }

        static string[] BuscarPessoa(string[] Array, String Name)
        {
            var List = new List<string>();
            foreach (string Names in Array)
            {
                if (Names.Contains(Name))
                {
                    List.Add(Names);
                }
            }
            string[] People = List.ToArray();
            return  People;
        }

        static int[,] TransformarEmMatriz(string Values)
        {
            string[] Aux = Values.Split(",");
            int[,] Matriz = new int[2, Aux.Length/2];
            int Count = 0;
            for(int j = 0; j <= Aux.Length / 2 - 1; j++)
            {
                for(int i = 0; i <= 1; i++)
                {
                    Matriz[i,j] = int.Parse(Aux[Count]);
                    Count++;
                }
            }
            return Matriz;
        }

        static int[] ObterElementosFaltantes(int[] Array1, int[] Array2)
        {
            bool Verifier = false;
            var List = new List<int>();


            for(int i = 0; i < Array1.Length; i++)
            {
                for(int j = 0; j < Array2.Length; j++)
                {
                    if(Array1[i] == Array2[j])
                    {
                        Verifier = true;
                        break;
                    }
                }
                if(Verifier == false)
                {
                    List.Add(Array1[i]);
                }
                Verifier = false;
            }
            for (int i = 0; i < Array2.Length; i++)
            {
                for (int j = 0; j < Array1.Length; j++)
                {
                    if (Array2[i] == Array1[j])
                    {
                        Verifier = true;
                        break;
                    }
                }
                if (Verifier == false)
                {
                    List.Add(Array2[i]);
                }
                Verifier = false;
            }
            int[] Array3 = List.ToArray();
            return Array3;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.1:");
            Console.WriteLine(CalcularFatorial(5));
            Console.WriteLine();

            Console.WriteLine("1.2:");
            CalcularPremio(100, "vip", null);
            CalcularPremio(100, "basic", 3);
            Console.WriteLine(CalcularPremio(100, "vip", null) + " " + CalcularPremio(100, "basic", 3));
            Console.WriteLine();

            Console.WriteLine("1.3:");
            Console.WriteLine(ContarNumerosPrimos(10));
            Console.WriteLine();

            Console.WriteLine("1.4:");
            Console.WriteLine(CalcularVogais("Luby Software"));
            Console.WriteLine();

            Console.WriteLine("1.5:");
            Console.WriteLine(CalcularValorComDescontoFormatado("R$ 6.800,00", "30%"));
            Console.WriteLine();

            Console.WriteLine("1.6:");
            Console.WriteLine(CalcularDiferencaData("10122020", "25122020"));
            Console.WriteLine();

            Console.WriteLine("1.7:");
            int[] vetor = new int[] { 1, 2, 3, 4, 5 };
            foreach (var item in ObterElementosPares(vetor)) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("1.8:");
            string[] names = new string[] 
            {
                "John Doe",
                "Jane Doe",
                "Alice Jones",
                "Bobby Louis",
                "Lisa Romero"
             };
            foreach(var x in BuscarPessoa(names, "Doe"))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (var x in BuscarPessoa(names, "Alice"))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            foreach (var x in BuscarPessoa(names, "James"))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("1.9:");

            foreach (int x in (TransformarEmMatriz("1,2,3,4,5,6")))
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();

            Console.WriteLine("1.10:");
            int[] vetor1 = new int[] { 1, 2, 3, 4, 5 };
            int[] vetor2 = new int[] { 1, 2, 5 };
            foreach(int x in ObterElementosFaltantes(vetor1, vetor2))
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.WriteLine();

            int[] vetor3 = new int[] { 1, 4, 5 };
            int[] vetor4 = new int[] { 1, 2, 3, 4, 5 };
            foreach (int x in ObterElementosFaltantes(vetor3, vetor4))
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.WriteLine();

            int[] vetor5 = new int[] { 1, 2, 3, 4 };
            int[] vetor6 = new int[] { 2, 3, 4, 5 };
            foreach (int x in ObterElementosFaltantes(vetor5, vetor6))
            {
                Console.Write(x);
                Console.Write(" ");
            }
            Console.WriteLine();
            int[] vetor7 = new int[] { 1, 3, 4, 5 };
            int[] vetor8 = new int[] { 1, 3, 4, 5 };
            foreach (int x in ObterElementosFaltantes(vetor7, vetor8))
            {
                Console.Write(x);
                Console.Write(" ");
            }
        }
    }
}
