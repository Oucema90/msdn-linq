using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class AggregateOperators
    {
        #region Simples

        public int Simple73()
        {
            int[] factorsOf300 = {2, 2, 3, 5, 5};
            return factorsOf300.Distinct().Count();
        }

        public int Simple74()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Count(n => n % 2 == 1);
        }

        public IEnumerable<CustomerOrderCount> Simple76()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.Select(
                x => new CustomerOrderCount {CustomerId = x.CustomerId, OrderCount = x.Orders.Count});
        }

        public IEnumerable<CategoryProducts> Simple77()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category)
                .Select(x => new CategoryProducts {Category = x.Key, ProductCount = x.Count()});
        }

        public double Simple78()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Sum();
        }

        public double Simple79()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.Sum(x => x.Length);
        }

        public IEnumerable<CategoryProducts> Simple80()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category)
                .Select(x => new CategoryProducts {Category = x.Key, TotalUnitsInStock = x.Sum(y => y.UnitStock)});
        }

        public int Simple81()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Min();
        }

        public int Simple82()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.Min(x => x.Length);
        }

        public IEnumerable<CategoryProducts> Simple83()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts
            {
                Category = x.Key,
                CheapestPrice = x.Min(y => y.UnitPrice)
            });
        }

        public IEnumerable<CategoryProducts> Simple84()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts
            {
                Category = x.Key,
                CheapestProducts = x.Where(y => y.UnitPrice == x.Min(z => z.UnitPrice))
            });
        }

        public int Simple85()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Max();
        }

        public int Simple86()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.Max(w => w.Length);
        }

        public IEnumerable<CategoryProducts> Simple87()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts
            {
                Category = x.Key,
                MostExpensivePrice = x.Max(y => y.UnitPrice)
            });
        }

        public IEnumerable<CategoryProducts> Simple88()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts
            {
                Category = x.Key,
                MostExpensiveProducts = x.Where(y => y.UnitPrice == x.Max(z => z.UnitPrice))
            });
        }

        public double Simple89()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Average();
        }

        public double Simple90()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.Average(x => x.Length);
        }

        public IEnumerable<CategoryProducts> Simple91()
        {
            var products = DataProvider.GetProductList();
            return products.GroupBy(x => x.Category).Select(x => new CategoryProducts
            {
                Category = x.Key,
                AveragePrice = x.Average(y => y.UnitPrice)
            });
        }

        public double Simple92()
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};
            return doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);
        }

        public double Simple93()
        {
            var startBalance = 100.0;
            int[] attemptedWithdrawals = {20, 10, 40, 50, 10, 70, 30};
            return attemptedWithdrawals.Aggregate(startBalance,
                (balance, nextWithdrawal) => nextWithdrawal <= balance ? balance - nextWithdrawal : balance);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nAggregates Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple73\n2. Simple74");
            for (var i = 3; i <= 20; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 73);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunAggregatesOperators()
        {
            string cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadLine();

                switch (cki)
                {
                    case "1":
                        Console.WriteLine("\nThe number of unique factors of 300:");
                        Console.WriteLine(Simple73());
                        break;
                    case "2":
                        Console.WriteLine("The number of the odd numbers in the list:");
                        Console.WriteLine(Simple74());
                        break;
                    case "3":
                        Console.WriteLine("\nNumber of orders per Customer:");
                        Display.Display.DisplayCustomerOrderCount(Simple76());
                        break;
                    case "4":
                        Console.WriteLine("\nNumber of prodcuts per Category:");
                        Display.Display.DisplayCategoryProducts(Simple77(),1);
                        break;
                    case "5":
                        Console.WriteLine("\nThe sum number of the numbers in the list");
                        Console.WriteLine(Simple78());
                        break;
                    case "6":
                        Console.WriteLine("\nThe total number of characters in these words:");
                        Console.WriteLine(Simple79());
                        break;
                    case "7":
                        Console.WriteLine("\nThe total unit in stock per category:");
                        Display.Display.DisplayCategoryProducts(Simple80(),2);
                        break;
                    case "8":
                        Console.WriteLine("\nThe minimum number is:");
                        Console.WriteLine(Simple81());
                        break;
                    case "9":
                        Console.WriteLine("\nThe shortest word length has a number of charachters long:");
                        Console.WriteLine(Simple82());
                        break;
                    case "10":
                        Console.WriteLine("\nThe cheapest price per category:");
                        Display.Display.DisplayCategoryProducts(Simple83(), 3);
                        break;
                    case "11":
                        Console.WriteLine("\nThe cheapest products per category:");
                        Display.Display.DisplayCategoryProducts(Simple84(), 4);
                        break;
                    case "12":
                        Console.WriteLine("\nThe maximum number is :");
                        Console.WriteLine(Simple85());
                        break;
                    case "13":
                        Console.WriteLine("\nThe longest word length has a number of charachters long:");
                        Console.WriteLine(Simple86());
                        break;
                    case "14":
                        Console.WriteLine("\nThe most expensive price per category:");
                        Display.Display.DisplayCategoryProducts(Simple87(), 5);
                        break;
                    case "15":
                        Console.WriteLine("\nThe most expensive products per category:");
                        Display.Display.DisplayCategoryProducts(Simple88(), 6);
                        break;
                    case "16":
                        Console.WriteLine("\nThe average number is:");
                        Console.WriteLine(Simple89());
                        break;
                    case "17":
                        Console.WriteLine("\nThe average word has a number of charachters long:");
                        Console.WriteLine(Simple90());
                        break;
                    case "18":
                        Console.WriteLine("\nThe average price per category:");
                        Display.Display.DisplayCategoryProducts(Simple91(), 7);
                        break;
                    case "19":
                        Console.WriteLine("\nTotal product of all number:");
                        Console.WriteLine(Simple92());
                        break;
                    case "20":
                        Console.WriteLine("\nEnding balance:");
                        Console.WriteLine(Simple93());
                        break;
                    default:
                        Console.WriteLine(cki == "Esc"
                            ? "\nGoing back to Main Menu"
                            : "\nNo such choice in the list\n");
                        break;
                }
            } while (cki != "Esc");
        }
    }
}
