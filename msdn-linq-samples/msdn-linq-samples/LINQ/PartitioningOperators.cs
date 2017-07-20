using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class PartitioningOperators
    {
        #region Simples

        public IEnumerable<int> Simple20()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.Take(3);
        }

        public IEnumerable<CustomerOrder> Simple21()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.SelectMany(x => x.Orders, (c, o) => new {c, o}).Where(x => x.c.Region == "WA")
                .Select(x => new CustomerOrder {CustomerId = x.c.CustomerId, OrderId = x.o.OrderId, Date = x.o.OrderDate})
                .Take(3);
        }

        public IEnumerable<int> Simple22()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.Skip(4);
        }

        public IEnumerable<CustomerOrder> Simple23()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.SelectMany(x => x.Orders, (c, o) => new {c, o})
                .Select(x => new CustomerOrder {CustomerId = x.c.CustomerId, OrderId = x.o.OrderId, Date = x.o.OrderDate })
                .Skip(2);
        }

        public IEnumerable<int> Simple24()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.TakeWhile(n => n < 6);
        }

        public IEnumerable<int> Simple25()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.TakeWhile((n, index) => n >= index);
        }

        public IEnumerable<int> Simple26()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.SkipWhile(n => n % 3 != 0);
        }

        public IEnumerable<int> Simple27()
        {
            var numbers = DataProvider.GetNumberList();
            return numbers.SkipWhile((n, index) => n >= index);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nPartitioning Operators");
            Console.WriteLine();
            for (var i = 1; i <= 8; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 19);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunPartitioningOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nFirst 3 numbers:");
                        Display.Display.DisplayInts(Simple20());
                        break;
                    case "2":
                        Console.WriteLine("\nFirst 3 orders in WA:");
                        Display.Display.DisplayCustomerOrders(Simple21(), 16);
                        break;
                    case "3":
                        Console.WriteLine("\nAll but first 4 numbers:");
                        Display.Display.DisplayInts(Simple22());
                        break;
                    case "4":
                        Console.WriteLine("\nAll but first 2 orders in WA:");
                        Display.Display.DisplayCustomerOrders(Simple23(), 16);
                        break;
                    case "5":
                        Console.WriteLine("\nFirst numbers less than 6:");
                        Display.Display.DisplayInts(Simple24());
                        break;
                    case "6":
                        Console.WriteLine("\nFirst numbers not less than their position:");
                        Display.Display.DisplayInts(Simple25());
                        break;
                    case "7":
                        Console.WriteLine("\nAll elements starting from first element divisible by 3:");
                        Display.Display.DisplayInts(Simple26());
                        break;
                    case "8":
                        Console.WriteLine("\nAll elements starting from first element less than its position:");
                        Display.Display.DisplayInts(Simple27());
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
