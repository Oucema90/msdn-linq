using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class MiscellaneousOperators
    {
        #region Simples

        public IEnumerable<int> Simple94()
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};
            return numbersA.Concat(numbersB);
        }

        public IEnumerable<string> Simple95()
        {
            var customers = DataProvider.GetCustomersList();
            var products = DataProvider.GetProductList();
            var customerNames = customers.Select(x => x.CompanyName);
            var productNames = products.Select(x => x.ProductName);
            return customerNames.Concat(productNames);
        }

        public bool Simple96()
        {
            var wordsA = new[] {"cherry", "apple", "blueberry"};
            var wordsB = new[] {"cherry", "apple", "blueberry"};
            return wordsA.SequenceEqual(wordsB);
        }

        public bool Simple97()
        {
            var wordsA = new[] {"cherry", "apple", "blueberry"};
            var wordsB = new[] {"blueberry", "apple", "cherry"};
            return wordsA.SequenceEqual(wordsB);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nMiscellaneous Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple94\n2. Simple95\n3. Simple96\n4. Simple97");
            Console.WriteLine("\nEsc. Exit");
        }
        

        #endregion

        public void RunMiscellaneousOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nAll numbers from both arrays:");
                        Display.Display.DisplayInts(Simple94());
                        break;
                    case "2":
                        Console.WriteLine("\nCustomer and product names:");
                        Display.Display.DisplayStrings(Simple95(), 1);
                        break;
                    case "3":
                        Console.WriteLine("\nThe sequences match:");
                        Console.WriteLine(Simple96());
                        break;
                    case "4":
                        Console.WriteLine("\nThe sequences match:");
                        Console.WriteLine(Simple97());
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
