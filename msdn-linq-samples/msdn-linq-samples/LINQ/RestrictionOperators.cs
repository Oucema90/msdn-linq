using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class RestrictionOperators
    {
        #region Simples

        public IEnumerable<int> Simple1()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};

            return numbers.Select(x => x).Where(x => x < 5);
        }

        public IEnumerable<Product> Simple2()
        {
            var products = DataProvider.GetProductList();
            return products.Select(x => x).Where(x => x.UnitStock == 0);
        }

        public IEnumerable<Product> Simple3()
        {
            var products = DataProvider.GetProductList();
            return products.Select(x => x).Where(x => x.UnitStock > 0 && x.UnitPrice > 3.00M);
        }

        public IEnumerable<Customer> Simple4()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.Select(c => c).Where(c => c.Region == "WA");
        }

        public IEnumerable<string> Simple5()
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

            return digits.Where((digit, index) => digit.Length < index);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nProjections Operators");
            Console.WriteLine();
            for (var i = 1; i <= 5; i++)
                Console.WriteLine("{0}. Simple{1}", i, i);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunRestrictionOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nNumbers < 5:");
                        Display.Display.DisplayInts(Simple1());
                        break;
                    case "2":
                        Console.WriteLine("\nSold out products:");
                        Display.Display.DisplayProducts(Simple2(),
                            cki.KeyChar.ToString());
                        break;
                    case "3":
                        Console.WriteLine("\nIn-stock products that cost more than 3.00:");
                        Display.Display.DisplayProducts(Simple3(),
                            cki.KeyChar.ToString());
                        break;
                    case "4":
                        Console.WriteLine("\nCustomers from Washington and their orders:");
                        Display.Display.DisplayCustomers(Simple4());
                        break;
                    case "5":
                        Console.WriteLine("\nShort digits:");
                        Display.Display.DisplayStrings(Simple5());
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