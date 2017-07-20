using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class SetsOperators
    {
        #region Simples

        public IEnumerable<int> Simple46()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };
            return factorsOf300.Distinct();
        }

        public IEnumerable<string> Simple47()
        {
            var products = DataProvider.GetProductList();
            return products.Select(x => x.Category).Distinct();
        }

        public IEnumerable<int> Simple48()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            return numbersA.Union(numbersB);
        }

        public IEnumerable<char> Simple49()
        {
            var products = DataProvider.GetProductList();
            var customers = DataProvider.GetCustomersList();
            return products.Select(x => x.ProductName[0]).Union(customers.Select(x => x.CompanyName[0]));
        }

        public IEnumerable<int> Simple50()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            return numbersA.Intersect(numbersB);
        }

        public IEnumerable<char> Simple51()
        {
            var products = DataProvider.GetProductList();
            var customer = DataProvider.GetCustomersList();
            return products.Select(x => x.ProductName[0]).Intersect(customer.Select(x => x.CompanyName[0]));
        }

        public IEnumerable<int> Simple52()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            return numbersA.Except(numbersB);
        }

        public IEnumerable<char> Simple53()
        {
            var products = DataProvider.GetProductList();
            var customers = DataProvider.GetCustomersList();
            return products.Select(x => x.ProductName[0]).Except(customers.Select(x => x.CompanyName[0]));
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nSet Operators");
            Console.WriteLine();
            for (var i = 1; i <= 8; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 45);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunSetsOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nPrime factors of 300:");
                        Display.Display.DisplayInts(Simple46());
                        break;
                    case "2":
                        Console.WriteLine("\nCategory names:");
                        Display.Display.DisplayStrings(Simple47(), 1);
                        break;
                    case "3":
                        Console.WriteLine("\nUnique numbers from both arrays:");
                        Display.Display.DisplayInts(Simple48());
                        break;
                    case "4":
                        Console.WriteLine("\nUnique first letters from Product names and Customer names:");
                        Display.Display.DisplayChars(Simple49());
                        break;
                    case "5":
                        Console.WriteLine("\nCommon numbers shared by both arrays:");
                        Display.Display.DisplayInts(Simple50());
                        break;
                    case "6":
                        Console.WriteLine("\nCommon first letters from Product names and Customer names:");
                        Display.Display.DisplayChars(Simple51());
                        break;
                    case "7":
                        Console.WriteLine("\nNumbers in first array but not second array:");
                        Display.Display.DisplayInts(Simple52());
                        break;
                    case "8":
                        Console.WriteLine("\nFirst letters from Product names, but not from Customer names:");
                        Display.Display.DisplayChars(Simple53());
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
