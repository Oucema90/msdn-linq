using System;
using System.Linq;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class ElementOperators
    {
        #region Simples

        public Product Simple58()
        {
            var products = DataProvider.GetProductList();
            return products.First();
        }

        public string Simple59()
        {
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return strings.First(x => x[0] == 'o');
        }

        public int Simple61()
        {
            int[] numbers = { };
            return numbers.FirstOrDefault();
        }

        public Product Simple62()
        {
            var products = DataProvider.GetProductList();
            return products.FirstOrDefault(p => p.ProductId == 789);
        }

        public int Simple64()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Where(x => x > 5).ElementAt(1);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nElements Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple58\n2. Simple59\n3. Simple61\n4. Simple62\n5. Simple64");
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunElementsOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nFirst Product details:");
                        Console.WriteLine(Simple58().ToString());
                        break;
                    case "2":
                        Console.WriteLine("\nA string starting with 'o':");
                        Console.WriteLine(Simple59());
                        break;
                    case "3":
                        Console.WriteLine("\nDefault int value:");
                        Console.WriteLine(Simple61());
                        break;
                    case "4":
                        Console.WriteLine("\nProduct 789 details:");
                        Console.WriteLine(Simple62()?.ToString());
                        break;
                    case "5":
                        Console.WriteLine("\nSecond number > 5:");
                        Console.WriteLine(Simple64());
                        break;
                    default:
                        Console.WriteLine(cki.Key == ConsoleKey.Escape
                            ? "\nGoing back to Main Menu"
                            : "\nNo such choice in the list\n");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
