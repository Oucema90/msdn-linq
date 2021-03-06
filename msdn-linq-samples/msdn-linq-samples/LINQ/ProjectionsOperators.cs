﻿using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Anonymous_Types;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;

namespace msdn_linq_samples.LINQ
{
    public class ProjectionsOperators
    {
        #region Simples

        public IEnumerable<int> Simple6()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Select(x => x + 1);
        }

        public IEnumerable<string> Simple7()
        {
            var products = DataProvider.GetProductList();
            return products.Select(x => x.ProductName);
        }

        public IEnumerable<string> Simple8()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return numbers.Select(x => strings[x]);
        }

        public IEnumerable<UpperLower> Simple9()
        {
            string[] words = {"aPPLE", "BlUeBeRrY", "cHeRry"};
            return words.Select(x => new UpperLower {Upper = x.ToUpper(), Lower = x.ToLower()});
        }

        public IEnumerable<DigitEven> Simple10()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] strings = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return numbers.Select(x => new DigitEven {Digit = strings[x], Even = x % 2 == 0});
        }

        public IEnumerable<Product> Simple11()
        {
            var products = DataProvider.GetProductList();
            return products.Select(x => new Product {ProductName = x.ProductName, UnitPrice = x.UnitPrice});
        }

        public IEnumerable<NumInPlace> Simple12()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Select((num, index) => new NumInPlace {Num = num, InPlace = num == index});
        }

        public IEnumerable<string> Simple13()
        {
            int[] numbers = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return numbers.Where(x => x < 5).Select(y => digits[y]);
        }

        public IEnumerable<AB> Simple14()
        {
            int[] numbersA = {0, 2, 4, 5, 6, 8, 9};
            int[] numbersB = {1, 3, 5, 7, 8};
            return numbersA.SelectMany(a => numbersB, (a, b) => new {a, b})
                .Where(x => x.a < x.b).Select(x => new AB {A = x.a, B = x.b});
        }

        public IEnumerable<CustomerOrder> Simple15()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.SelectMany(x => x.Orders, (c, o) => new {c, o}).Where(x => x.o.Total < 500.00M)
                .Select(x => new CustomerOrder {CustomerId = x.c.CustomerId, OrderId = x.o.OrderId, Total = x.o.Total});
        }

        public IEnumerable<CustomerOrder> Simple16()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.SelectMany(x => x.Orders, (c, o) => new {c, o})
                .Where(x => x.o.OrderDate > new DateTime(1998, 1, 1))
                .Select(x => new CustomerOrder {CustomerId = x.c.CustomerId, OrderId = x.o.OrderId, Date = x.o.OrderDate });
        }

        public IEnumerable<CustomerOrder> Simple17()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.SelectMany(x => x.Orders, (c, o) => new {c, o}).Where(x => x.o.Total >= 200.0M)
                .Select(x => new CustomerOrder {CustomerId = x.c.CustomerId, OrderId = x.o.OrderId, Total = x.o.Total});
        }

        public IEnumerable<CustomerOrder> Simple18()
        {
            var customers = DataProvider.GetCustomersList();
            var cutoffDate = new DateTime(1997, 1, 1);
            return customers.Where(x => x.Region == "WA").SelectMany(x => x.Orders, (c, o) => new {c, o})
                .Where(x => x.o.OrderDate >= cutoffDate)
                .Select(x => new CustomerOrder {CustomerId = x.c.CustomerId, OrderId = x.o.OrderId});
        }

        public IEnumerable<string> Simple19()
        {
            var customers = DataProvider.GetCustomersList();
            return customers.SelectMany((customer, customerIndex) => customer.Orders.Select(
                o => "Customer #" + (customerIndex + 1) + " has an order with OrderID " + o.OrderId));
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nProjections Operators");
            Console.WriteLine();
            for (var i = 1; i <= 14; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 5);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunProjectionsOperators()
        {
            string cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadLine();

                switch (cki)
                {
                    case "1":
                        Console.WriteLine("\nNumbers + 1:");
                        Display.Display.DisplayInts(Simple6());
                        break;
                    case "2":
                        Console.WriteLine("\nProduct Names:");
                        Display.Display.DisplayStrings(Simple7(),1);
                        break;
                    case "3":
                        Console.WriteLine("\nNumber strings:");
                        Display.Display.DisplayStrings(Simple8(),1);
                        break;
                    case "4":
                        Console.WriteLine("\nUpper Lower:");
                        Display.Display.DisplayUpperLowers(Simple9());
                        break;
                    case "5":
                        Console.WriteLine("\nDigit Even:");
                        Display.Display.DisplayDigitEvens(Simple10());
                        break;
                    case "6":
                        Console.WriteLine("\nProduct Info:");
                        Display.Display.DisplayProducts(Simple11(), "2");
                        break;
                    case "7":
                        Console.WriteLine("\nNumber: In-place?");
                        Display.Display.DisplayNumInPlaces(Simple12());
                        break;
                    case "8":
                        Console.WriteLine("\nNumbers < 5:");
                        Display.Display.DisplayStrings(Simple13(),1);
                        break;
                    case "9":
                        Console.WriteLine("\nPairs where a < b:");
                        Display.Display.DisplayAbs(Simple14());
                        break;
                    case "10":
                        Console.WriteLine("\nCustumer Orders Simple15:");
                        Display.Display.DisplayCustomerOrders(Simple15(), 15);
                        break;
                    case "11":
                        Console.WriteLine("\nCustumer Orders Simple16:");
                        Display.Display.DisplayCustomerOrders(Simple16(), 16);
                        break;
                    case "12":
                        Console.WriteLine("\nCustumer Orders Simple17:");
                        Display.Display.DisplayCustomerOrders(Simple17(), 17);
                        break;
                    case "13":
                        Console.WriteLine("\nCustumer Orders Simple18:");
                        Display.Display.DisplayCustomerOrders(Simple18(), 18);
                        break;
                    case "14":
                        Console.WriteLine("\nCustumer Orders Simple19:");
                        Display.Display.DisplayStrings(Simple19(),1);
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