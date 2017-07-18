using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Entity;
using msdn_linq_samples.Provider;
using msdn_linq_samples.Utils;

namespace msdn_linq_samples.LINQ
{
    public class OrderingOperators
    {
        #region Simples

        public IEnumerable<string> Simple28()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.OrderBy(x => x);
        }

        public IEnumerable<string> Simple29()
        {
            string[] words = {"cherry", "apple", "blueberry"};
            return words.OrderBy(x => x.Length);
        }

        public IEnumerable<Product> Simple30()
        {
            var products = DataProvider.GetProductList();
            return products.OrderBy(x => x.ProductName);
        }

        public IEnumerable<string> Simple31()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderBy(x => x, new CaseInsensitiveComparer());
        }

        public IEnumerable<double> Simple32()
        {
            double[] doubles = {1.7, 2.3, 1.9, 4.1, 2.9};
            return doubles.OrderByDescending(x => x);
        }

        public IEnumerable<Product> Simple33()
        {
            var products = DataProvider.GetProductList();
            return products.OrderByDescending(x => x.UnitStock);
        }

        public IEnumerable<string> Simple34()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderByDescending(a => a, new CaseInsensitiveComparer());
        }

        public IEnumerable<string> Simple35()
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return digits.OrderBy(x => x.Length).ThenBy(x => x);
        }

        public IEnumerable<string> Simple36()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderBy(a => a.Length).ThenBy(a => a, new CaseInsensitiveComparer());
        }

        public IEnumerable<Product> Simple37()
        {
            var products = DataProvider.GetProductList();
            return products.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
        }

        public IEnumerable<string> Simple38()
        {
            string[] words = {"aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry"};
            return words.OrderBy(a => a.Length).ThenByDescending(a => a, new CaseInsensitiveComparer());
        }

        public IEnumerable<string> Simple39()
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return digits.Where(x => x[1] == 'i').Reverse();
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nOrdering Operators");
            Console.WriteLine();
            for (var i = 1; i <= 12; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 27);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunOrderingOperators()
        {
            string cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadLine();

                switch (cki)
                {
                    case "1":
                        Console.WriteLine("\nThe sorted list of words:");
                        Display.Display.DisplayStrings(Simple28(), 1);
                        break;
                    case "2":
                        Console.WriteLine("\nThe sorted list of words (by length):");
                        Display.Display.DisplayStrings(Simple29(), 1);
                        break;
                    case "3":
                        Console.WriteLine("\nProducts informations:");
                        Display.Display.DisplayProducts(Simple30(),"4");
                        break;
                    case "4":
                        Console.WriteLine("\nWords informations:");
                        Display.Display.DisplayStrings(Simple31(), 1);
                        break;
                    case "5":
                        Console.WriteLine("\nThe doubles from highest to lowest:");
                        Display.Display.DisplayDoubles(Simple32());
                        break;
                    case "6":
                        Console.WriteLine("\nProducts informations:");
                        Display.Display.DisplayProducts(Simple33(),"4");
                        break;
                    case "7":
                        Console.WriteLine("\nWords informations:");
                        Display.Display.DisplayStrings(Simple34(), 1);
                        break;
                    case "8":
                        Console.WriteLine("\nSorted digits:");
                        Display.Display.DisplayStrings(Simple35(), 1);
                        break;
                    case "9":
                        Console.WriteLine("\nWords informations:");
                        Display.Display.DisplayStrings(Simple36(), 1);
                        break;
                    case "10":
                        Console.WriteLine("\nProducts informations:");
                        Display.Display.DisplayProducts(Simple37(),"4");
                        break;
                    case "11":
                        Console.WriteLine("\nWords informations:");
                        Display.Display.DisplayStrings(Simple38(), 1);
                        break;
                    case "12":
                        Console.WriteLine("\nA backwards list of the digits with a second character of 'i':");
                        Display.Display.DisplayStrings(Simple39(), 1);
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
